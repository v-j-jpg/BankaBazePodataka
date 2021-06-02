using BankaBP2;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.ViewModel
{
   public class OdlukaViewModel:BindableBase
    {
        public ObservableCollection<Model.Odluka> Klijenti { get; set; }
        public MyICommand DeleteCommand { get; set; }
        public MyICommand AddCommand { get; set; }
        public MyICommand UpdateCommand { get; set; }

        private Model.Odluka selektovaniKlijent;

        private string fnText;
        private string lnText;

        BankaBP2.CRUD.Odluka_OP kliOP = new BankaBP2.CRUD.Odluka_OP();

        public OdlukaViewModel()
        {
            LoadStudents();
            DeleteCommand = new MyICommand(OnDelete, CanDelete);
            AddCommand = new MyICommand(OnAdd);
            UpdateCommand = new MyICommand(OnUpdate);


        }

        private void OnUpdate()
        {

            foreach (var item in Klijenti)
            {
                if (SelektovaniKlijent.ID_ODLUKA.Equals(item.ID_ODLUKA))
                {
                    kliOP.UpdateZir(SelektovaniKlijent.ID_ODLUKA, selektovaniKlijent.Odobreno,selektovaniKlijent.DAT_OD);
                }
            }


        }

        public Model.Odluka SelektovaniKlijent
        {
            get { return selektovaniKlijent; }
            set
            {
                selektovaniKlijent = value;
                DeleteCommand.RaiseCanExecuteChanged();
                UpdateCommand.RaiseCanExecuteChanged();
            }
        }
        Model.Odluka kli;

        public void LoadStudents()
        {
            ObservableCollection<Model.Odluka> klijenti = new ObservableCollection<Model.Odluka>();

            int v2;

            using (var db = new Model1Container())
            {
                foreach (var item in db.Odlukas)
                {


                    kli = new Model.Odluka();
                    kli.ID_ODLUKA = item.ID_ODLUKE;
                    kli.Odobreno = item.Odobreno;
                    kli.DAT_OD = item.DAT_ODLUKE;

                    klijenti.Add(kli);
                }
            }

            Klijenti = klijenti;
        }

        private bool CanDelete()
        {
            return SelektovaniKlijent != null;
        }

        private void OnDelete()
        {


            BankaBP2.Odluka k = new Odluka
            {
                ID_ODLUKE = selektovaniKlijent.ID_ODLUKA,
                Odobreno = selektovaniKlijent.Odobreno,
                DAT_ODLUKE = selektovaniKlijent.DAT_OD
            };
            Klijenti.Remove(SelektovaniKlijent);
            kliOP.DeleteKli(k);

        }

        public string FNText
        {
            get { return fnText; }
            set
            {
                if (fnText != value)
                {
                    fnText = value;
                    OnPropertyChanged("FNText");
                }
            }
        }

        public string LNText
        {
            get { return lnText; }
            set
            {
                if (lnText != value)
                {
                    lnText = value;
                    OnPropertyChanged("LNText");
                }
            }
        }




        private void OnAdd()
        {

            kliOP.AddZir(FNText, LNText);

            Klijenti.Add(new Model.Odluka { Odobreno = FNText,DAT_OD=LNText });
        }
    }
}

