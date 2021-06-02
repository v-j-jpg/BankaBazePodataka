using BankaBP2;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.ViewModel
{
    public class RiskViewModel : BindableBase
    {
        public ObservableCollection<Model.Risk> Klijenti { get; set; }
        public MyICommand DeleteCommand { get; set; }
        public MyICommand AddCommand { get; set; }
        public MyICommand UpdateCommand { get; set; }

        private Model.Risk selektovaniKlijent;

        private string fnText;
        private string lnText;

        BankaBP2.CRUD.RISK_OP kliOP = new BankaBP2.CRUD.RISK_OP();

        public RiskViewModel()
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
                if (SelektovaniKlijent.ID_KOMISIJE.Equals(item.ID_KOMISIJE))
                {
                    kliOP.UpdateZir(SelektovaniKlijent.ID_KOMISIJE, selektovaniKlijent.BR_CLANOVA);
                }
            }


        }

        public Model.Risk SelektovaniKlijent
        {
            get { return selektovaniKlijent; }
            set
            {
                selektovaniKlijent = value;
                DeleteCommand.RaiseCanExecuteChanged();
                UpdateCommand.RaiseCanExecuteChanged();
            }
        }
        Model.Risk kli;

        public void LoadStudents()
        {
            ObservableCollection<Model.Risk> klijenti = new ObservableCollection<Model.Risk>();

            int v2;

            using (var db = new Model1Container())
            {
                foreach (var item in db.RISKs)
                {


                    kli = new Model.Risk();
                    kli.ID_KOMISIJE = item.ID_KOMISIJE;
                    kli.BR_CLANOVA = item.BR_CLANOVA;
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
       

            BankaBP2.RISK k = new RISK
            {
                ID_KOMISIJE = selektovaniKlijent.ID_KOMISIJE,
                BR_CLANOVA = selektovaniKlijent.BR_CLANOVA
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
          
           kliOP.AddZir(LNText);
            
            Klijenti.Add(new Model.Risk { BR_CLANOVA = LNText });
        }
    }
  
}
