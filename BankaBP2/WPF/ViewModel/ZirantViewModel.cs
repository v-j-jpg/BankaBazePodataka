using BankaBP2;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.ViewModel
{
   public class ZirantViewModel:BindableBase
    {
        public ObservableCollection<Model.Zirant> Klijenti { get; set; }
        public MyICommand DeleteCommand { get; set; }
        public MyICommand AddCommand { get; set; }
        public MyICommand UpdateCommand { get; set; }

        private Model.Zirant selektovaniKlijent;

        private string fnText;
        private string lnText;

        private string pltText;

        BankaBP2.CRUD.Zirant_OP kliOP = new BankaBP2.CRUD.Zirant_OP();
        public ZirantViewModel()
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
                if (SelektovaniKlijent.ID_ZIR.Equals(item.ID_ZIR))
                {
                    kliOP.UpdateZir(SelektovaniKlijent.IME_ZIR, selektovaniKlijent.PRZ_ZIR, selektovaniKlijent.PLT_ZIR, selektovaniKlijent.ID_ZIR);
                }
            }


        }

        public Model.Zirant SelektovaniKlijent
        {
            get { return selektovaniKlijent; }
            set
            {
                selektovaniKlijent = value;
                DeleteCommand.RaiseCanExecuteChanged();
                UpdateCommand.RaiseCanExecuteChanged();
            }
        }
        Model.Zirant kli;

        public void LoadStudents()
        {
            ObservableCollection<Model.Zirant> klijenti = new ObservableCollection<Model.Zirant>();

            int v2;

            using (var db = new Model1Container())
            {
                foreach (var item in db.Zirants)
                {
                    if (item.PLT_ZIR == null)
                        v2 = default(int);
                    else
                        v2 = item.PLT_ZIR.Value;

                    kli = new Model.Zirant();
                    kli.IME_ZIR = item.IME_ZIR;
                    kli.PRZ_ZIR = item.PRZ_ZIR;
                    kli.ID_ZIR = item.ID_ZIR;
                    kli.PLT_ZIR = v2;
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
        
            BankaBP2.Zirant k = new Zirant();
            k.IME_ZIR= selektovaniKlijent.IME_ZIR;
            k.PRZ_ZIR = selektovaniKlijent.PRZ_ZIR;
            k.PLT_ZIR = selektovaniKlijent.PLT_ZIR;
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
     

    
        private void OnAdd()
        {
            Klijenti.Add(new Model.Zirant { IME_ZIR = FNText, PRZ_ZIR = LNText, PLT_ZIR = Int32.Parse(PLTText) });
            kliOP.AddZir(FNText, LNText, Int32.Parse(PLTText));
        }
    }
}
