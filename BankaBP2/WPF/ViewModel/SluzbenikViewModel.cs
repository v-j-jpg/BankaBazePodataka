using BankaBP2;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.ViewModel
{
    public class SluzbenikViewModel:BindableBase
    {
        public ObservableCollection<Model.Sluzbenik> Klijenti { get; set; }
        public MyICommand DeleteCommand { get; set; }
        public MyICommand AddCommand { get; set; }
        public MyICommand UpdateCommand { get; set; }

        private Model.Sluzbenik selektovaniKlijent;

        private string fnText;
        private string lnText;

        private string pltText;
        private string zirText;

        BankaBP2.CRUD.Sluzbenik_OP kliOP = new BankaBP2.CRUD.Sluzbenik_OP();
        public SluzbenikViewModel()
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
                if (SelektovaniKlijent.JMBG_RAD.Equals(item.JMBG_RAD))
                {
                    kliOP.UpdateKli(SelektovaniKlijent.IME_RAD, selektovaniKlijent.PRZ_RAD, selektovaniKlijent.FilijalaID_FIL, selektovaniKlijent.FilijalaBankaID_Banka,item.JMBG_RAD);
                }
            }


        }

        public Model.Sluzbenik SelektovaniKlijent
        {
            get { return selektovaniKlijent; }
            set
            {
                selektovaniKlijent = value;
                DeleteCommand.RaiseCanExecuteChanged();
                UpdateCommand.RaiseCanExecuteChanged();
            }
        }
        Model.Sluzbenik kli;

        public void LoadStudents()
        {
            ObservableCollection<Model.Sluzbenik> klijenti = new ObservableCollection<Model.Sluzbenik>();

            int v2;

            using (var db = new Model1Container())
            {
                foreach (var item in db.Sluzbeniks)
                {

                    kli = new Model.Sluzbenik();
                    kli.IME_RAD = item.IME_RAD;
                    kli.PRZ_RAD = item.PRZ_RAD;
                    kli.JMBG_RAD = item.JMBG_RAD;
                    kli.FilijalaID_FIL = item.Filijala.ID_FIL;
                    kli.FilijalaBankaID_Banka = item.Filijala.BankaID_Banka ;
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
          
            BankaBP2.Sluzbenik k = new Sluzbenik();
            k.IME_RAD = selektovaniKlijent.IME_RAD;
            k.JMBG_RAD = selektovaniKlijent.JMBG_RAD;
            k.PRZ_RAD = selektovaniKlijent.PRZ_RAD;
            kliOP.DeleteKli(k);
            Klijenti.Remove(SelektovaniKlijent);

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
        public string PLTText
        {
            get { return pltText; }
            set
            {
                if (pltText != value)
                {
                    pltText = value;
                    OnPropertyChanged("PLTText");
                }
            }
        }
        
        private string bank;

        public string BankText
        {
            get { return bank; }
            set { bank = value; OnPropertyChanged("BankText"); }
        }



        private void OnAdd()
        {
            Klijenti.Add(new Model.Sluzbenik { IME_RAD = FNText, PRZ_RAD = LNText, FilijalaID_FIL = Int32.Parse(PLTText), FilijalaBankaID_Banka = Int32.Parse(BankText) });
            kliOP.AddKLi(FNText, LNText, Int32.Parse(PLTText), Int32.Parse(BankText));
        }
    }
}
