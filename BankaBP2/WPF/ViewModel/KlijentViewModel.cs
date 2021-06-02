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
                //if (item.IME_KLI==FNText || item.PRZ_KLI==LNText || item.ZirantID_ZIR==Int32.Parse(ZIRTEXT))
                //{
                //    Klijenti.Contains();
                //}
            }
          

        }

        public Model.Klijent SelektovaniKlijent
        {
            get { return selektovaniKlijent; }
            set
            {
                selektovaniKlijent = value;
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }
        Model.Klijent kli;

        public void LoadStudents()
        {
            ObservableCollection<Model.Klijent> klijenti = new ObservableCollection<Model.Klijent>();

            

            using (var db = new Model1Container())
            {
                foreach (var item in db.Klijents)
                {
                    kli = new Model.Klijent();
                    kli.IME_KLI = item.IME_KLI;
                    kli.PRZ_KLI = item.PRZ_KLI;
                    kli.JMBG_KLI = item.JMBG_KLI;
                    kli.PLT_KLI = (int)item.PLT_KLI;
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
            Klijenti.Remove(SelektovaniKlijent);
            BankaBP2.Klijent k = new Klijent();
            k.IME_KLI = selektovaniKlijent.IME_KLI;
            k.JMBG_KLI = selektovaniKlijent.JMBG_KLI;
            k.PRZ_KLI = selektovaniKlijent.PRZ_KLI;
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
            Klijenti.Add(new Model.Klijent { IME_KLI = FNText, PRZ_KLI = LNText, PLT_KLI = Int32.Parse(PLTText), ZirantID_ZIR = Int32.Parse(ZIRTEXT)});
            kliOP.AddKLi(FNText, LNText, Int32.Parse(ZIRTEXT), Int32.Parse(PLTText));
        }
    }
}
