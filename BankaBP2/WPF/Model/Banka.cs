using BankaBP2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Model
{
  public  class Banka
    {

        private int id;

        public int ID
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("ID");

            }
        }

        private string naziv;

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value;
                OnPropertyChanged("Naziv");

                //UPDATE
                BankaBP2.CRUD.Banka_OP banka_OP = new BankaBP2.CRUD.Banka_OP();
                banka_OP.UpdateBank(value, ID);
            }
        }
        private string noviNaziv;

        public string NoviNaziv
        {
            get { return noviNaziv; }
            set
            {
                noviNaziv = value;
                OnPropertyAdded("NoviNaziv");

              
            }
        }


        #region INotifyPropertyChanged Members  

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler propertyAdded;
        private void OnPropertyAdded(string propertyName)
        {
            if (propertyAdded != null)
            {  //Add
                BankaBP2.CRUD.Banka_OP banka_OP = new BankaBP2.CRUD.Banka_OP();
                banka_OP.AddBank(propertyName);
                propertyAdded(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
