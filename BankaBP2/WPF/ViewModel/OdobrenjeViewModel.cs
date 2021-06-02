using BankaBP2;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.ViewModel
{
  public  class OdobrenjeViewModel:BindableBase
    {

        public ObservableCollection<Model.Odobrenje> Klijenti { get; set; }
        public MyICommand DeleteCommand { get; set; }
        public MyICommand AddCommand { get; set; }
        public MyICommand UpdateCommand { get; set; }

        private Model.Odobrenje selektovaniKlijent;

        private string fnText;
        private string lnText;

        BankaBP2.CRUD.Odobrenje_OP kliOP = new BankaBP2.CRUD.Odobrenje_OP();

        public OdobrenjeViewModel()
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
                if (SelektovaniKlijent.ID_ODLUKE.Equals(item.ID_ODLUKE))
                {
                    kliOP.UpdateZir(SelektovaniKlijent.ID_ODLUKE, selektovaniKlijent.RISK_ID);
                }
            }


        }

        public Model.Odobrenje SelektovaniKlijent
        {
            get { return selektovaniKlijent; }
            set
            {
                selektovaniKlijent = value;
                DeleteCommand.RaiseCanExecuteChanged();
                UpdateCommand.RaiseCanExecuteChanged();
            }
        }
        Model.Odobrenje kli;

        public void LoadStudents()
        {
            ObservableCollection<Model.Odobrenje> klijenti = new ObservableCollection<Model.Odobrenje>();

            int v2;

            using (var db = new Model1Container())
            {
                foreach (var item in db.Odobrenjes)
                {


                    kli = new Model.Odobrenje();
                    kli.ID_ODLUKE = item.OdlukaID_ODLUKE;
                    kli.RISK_ID = item.RISKID_KOMISIJE;
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


            BankaBP2.Odobrenje k = new Odobrenje
            {
                OdlukaID_ODLUKE = selektovaniKlijent.ID_ODLUKE,
                RISKID_KOMISIJE = selektovaniKlijent.RISK_ID
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

            kliOP.AddZir(Int32.Parse(FNText),Int32.Parse(LNText));

            Klijenti.Add(new Model.Odobrenje { ID_ODLUKE= Int32.Parse(FNText),RISK_ID = Int32.Parse(LNText) });
        }
    }
}

