using BankaBP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF.Model;
using WPF.View;

namespace WPF.ViewModel
{
    public class BankaViewModel
    {    
        private IList<Model.Banka> banke_lista;
        Model.Banka banka;
        public BankaViewModel()
        {
           
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

        private ICommand _SubmitCommand;
        public ICommand SubmitCommand
        {
            get
            {
                if (_SubmitCommand == null)
                {
                    _SubmitCommand = new RelayCommand(param => this.Submit(),null);
                }
                return _SubmitCommand;
            }
        }

        private void Submit()
        {
            ////ADD
            //BankaBP2.CRUD.Banka_OP banka_OP = new BankaBP2.CRUD.Banka_OP();
            //banka_OP.AddBank(banka.NoviNaziv);

            //MessageBox.Show("jej");
        }

        private ICommand _DeleteCommand;
        public ICommand DeleteCommand
        {
            get
            {
                if (_DeleteCommand == null)
                {
                    _DeleteCommand = new RelayCommand(param => this.Delete(), null);
                }
                return _DeleteCommand;
            }
        }

        private void Delete()
        {

            ////UPDATE
            //BankaBP2.CRUD.Banka_OP banka_OP = new BankaBP2.CRUD.Banka_OP();
            //banka_OP.DeleteBank(banka.ID);
            MessageBox.Show("Bank is deleted!");

        }
    }
}
