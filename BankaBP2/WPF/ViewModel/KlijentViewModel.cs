using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using BankaBP2;

namespace WPF.ViewModel
{
   public class KlijentViewModel:BindableBase
    {
        public ObservableCollection<Model.Klijent> Klijenti { get; set; }
        public MyICommand DeleteCommand { get; set; }
        public MyICommand AddCommand { get; set; }
        public MyICommand UpdateCommand { get; set; }

        private Model.Klijent selektovaniKlijent;

        private string fnText;
        private string lnText;

        private string pltText;
        private string zirText;

        BankaBP2.CRUD.Klijent_OP kliOP = new BankaBP2.CRUD.Klijent_OP();
        public KlijentViewModel()
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
                if (SelektovaniKlijent.JMBG_KLI.Equals(item.JMBG_KLI))
                {
                    kliOP.UpdateKli(SelektovaniKlijent.IME_KLI, selektovaniKlijent.PRZ_KLI,selektovaniKlijent.ZirantID_ZIR, selektovaniKlijent.PLT_KLI,item.JMBG_KLI);
                }
            }
          

        }

        public Model.Klijent SelektovaniKlijent
        {
            get { return selektovaniKlijent; }
            set
            {
                selektovaniKlijent = value;
                DeleteCommand.RaiseCanExecuteChanged();
                UpdateCommand.RaiseCanExecuteChanged();
            }
        }
        Model.Klijent kli;

        public void LoadStudents()
        {
            ObservableCollection<Model.Klijent> klijenti = new ObservableCollection<Model.Klijent>();

            int v2;

            using (var db = new Model1Container())
            {
                foreach (var item in db.Klijents)
                {
                    if (item.PLT_KLI == null)
                        v2 = default(int);
                    else
                        v2 = item.PLT_KLI.Value;

                    kli = new Model.Klijent();
                    kli.IME_KLI = item.IME_KLI;
                    kli.PRZ_KLI = item.PRZ_KLI;
                    kli.JMBG_KLI = item.JMBG_KLI;
                    kli.PLT_KLI = v2;
                    kli.ZirantID_ZIR= item.ZirantID_ZIR;
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
            
            BankaBP2.Klijent k = new Klijent();
            k.IME_KLI = selektovaniKlijent.IME_KLI;
            k.JMBG_KLI = selektovaniKlijent.JMBG_KLI;
            k.PRZ_KLI = selektovaniKlijent.PRZ_KLI;
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

        private string fnTextUpdate;

        public string FNTEXTUpdate
        {
            get { return fnTextUpdate; }
            set { fnTextUpdate = value; }
        }
        private string lntextUpdate;

        public string LNTextUpdate
        {
            get { return lntextUpdate; }
            set { lntextUpdate = value; }
        }

        private string pltTextUpdate;

        public string PLTTextUpdate
        {
            get { return pltTextUpdate; }
            set { pltTextUpdate = value; }
        }

        private string zirId;

        public string ZIRTEXTUpdate
        {
            get { return zirId; }
            set { zirId = value; }
        }


        private void OnAdd()
        {
            Klijenti.Add(new Model.Klijent { IME_KLI = FNText, PRZ_KLI = LNText, PLT_KLI = Int32.Parse(PLTText), ZirantID_ZIR = Int32.Parse(ZIRTEXT)});
            kliOP.AddKLi(FNText, LNText, Int32.Parse(ZIRTEXT), Int32.Parse(PLTText));
        }
    }
}
