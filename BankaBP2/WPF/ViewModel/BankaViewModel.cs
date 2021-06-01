using BankaBP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.Model;
using WPF.View;

namespace WPF.ViewModel
{
    public class BankaViewModel
    {    
        private IList<Model.Banka> banke_lista;

        public BankaViewModel()
        {
            Model.Banka banka;
            banke_lista = new List<Model.Banka>();

            //Read
            using (var db=new Model1Container())
            {
                foreach (var item in db.Bankas)
                {   
                    banka= new Model.Banka();
                    banka.ID = item.ID_Banka;
                    banka.Naziv = item.Naziv;
                    banke_lista.Add(banka);
                }
            }
      
           

        }

        public IList<Model.Banka> Banke
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
            //{
            //    //add { CommandManager.RequerySuggested += value; }
            //    //remove { CommandManager.RequerySuggested -= value; }
            //}

            public void Execute(object parameter)
            {
              
            }

            #endregion
        }
    }
}
