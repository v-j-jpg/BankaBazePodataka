using BankaWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;

namespace BankaWPF.ViewModel
{
    public class BankaViewModel
    {
    //    BankaBP2.CRUD.Banka_OP operations_bank = new BankaBP2.CRUD.Banka_OP();
    //        // operations_bank.AddBank("Baaankica");

    //        foreach (var item in operations_bank.ReadBank())
    //        {
    //            Ispis.Text += item.ID + "  " + item.Naziv + "\n";
    //        }

    ////operations_bank.UpdateBank("Blanka");
    //// operations_bank.DeleteBank("NovaBanka");
    ///
    
  

        private IList<Banka> banke_lista;

        public BankaViewModel()
        {
            banke_lista = new List<Banka>
            {
                    new Banka{Naziv="Columbiana",ID=45},
                    new Banka{Naziv="Columbiana2",ID=46},
                    new Banka{Naziv="Columbiana1",ID=47},
            };
        }

        public IList<Banka> banke
        {
            get { return banke_lista; }
            set { banke_lista = value; }
        }

        private ICommand mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }

        private class Updater : ICommand
        {
            #region ICommand Members  

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {

            }

            #endregion
        }
    }
}


