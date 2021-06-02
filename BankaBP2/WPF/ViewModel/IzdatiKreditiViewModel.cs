using BankaBP2;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.ViewModel
{
  public  class IzdatiKreditiViewModel:BindableBase
    {

        public ObservableCollection<Model.IzdatiKrediti> Klijenti { get; set; }
        public MyICommand DeleteCommand { get; set; }
        public MyICommand AddCommand { get; set; }
        public MyICommand UpdateCommand { get; set; }

        private Model.IzdatiKrediti selektovaniKlijent;

        private string fnText;
        private string lnText;

        private string pltText;
        private string zirText;

        BankaBP2.CRUD.Izdati_krediti_OP kliOP = new BankaBP2.CRUD.Izdati_krediti_OP();
        public IzdatiKreditiViewModel()
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
                    kliOP.UpdateZir(SelektovaniKlijent.ID_ODLUKE, selektovaniKlijent.RISK_ID, selektovaniKlijent.JMBG_KLI, selektovaniKlijent.JMBG_RAD);
                }
            }


        }

        public Model.IzdatiKrediti SelektovaniKlijent
        {
            get { return selektovaniKlijent; }
            set
            {
                selektovaniKlijent = value;
                DeleteCommand.RaiseCanExecuteChanged();
                UpdateCommand.RaiseCanExecuteChanged();
            }
        }
        Model.IzdatiKrediti kli;

        public void LoadStudents()
        {
            ObservableCollection<Model.IzdatiKrediti> klijenti = new ObservableCollection<Model.IzdatiKrediti>();


            using (var db = new Model1Container())
            {
                foreach (var item in db.IzdatiKreditis)
                {
               

                    kli = new Model.IzdatiKrediti();
                    kli.ID_ODLUKE = item.OdobrenjeOdlukaID_ODLUKE;
                    kli.RISK_ID = item.OdobrenjeRISKID_KOMISIJE;
                    kli.JMBG_KLI = item.KlijentJMBG_KLI;
                    kli.JMBG_RAD = item.SluzbenikJMBG_RAD;

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

            BankaBP2.IzdatiKrediti k = new IzdatiKrediti();
            k.OdobrenjeOdlukaID_ODLUKE = selektovaniKlijent.ID_ODLUKE;
            k.OdobrenjeRISKID_KOMISIJE = selektovaniKlijent.RISK_ID;
            k.KlijentJMBG_KLI = selektovaniKlijent.JMBG_KLI;
            k.SluzbenikJMBG_RAD = selektovaniKlijent.JMBG_RAD;

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
        public string ZIRTEXT
        {
            get { return zirText; }
            set
            {
                if (zirText != value)
                {
                    zirText = value;
                    OnPropertyChanged("ZIRTEXT");
                }
            }
        }

        

        private void OnAdd()
        {
            Klijenti.Add(new Model.IzdatiKrediti { ID_ODLUKE = Int32.Parse(FNText), RISK_ID = Int32.Parse(LNText), JMBG_KLI = Int32.Parse(PLTText), JMBG_RAD = Int32.Parse(ZIRTEXT) });
            kliOP.AddZir(Int32.Parse(FNText), Int32.Parse(LNText), Int32.Parse(ZIRTEXT), Int32.Parse(PLTText));
        }
    }
}
