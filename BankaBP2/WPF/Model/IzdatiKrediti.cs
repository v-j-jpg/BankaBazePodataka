using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WPF.Model
{
   public class IzdatiKrediti: INotifyPropertyChanged
    {

        private int id;

        public int ID_ODLUKE
        {
            get { return id; }
            set { id = value; OnPropertyChanged("ID_ODLUKE"); }
        }

        private int ris;

        public int RISK_ID
        {
            get { return ris; }
            set { ris = value; OnPropertyChanged("RISK_ID"); }
        }
        private int jmbg_rad;

        public int JMBG_RAD
        {
            get { return jmbg_rad; }
            set { jmbg_rad = value; OnPropertyChanged("JMBG_RAD"); }
        }

        private int jmbg_kli;

        public int JMBG_KLI
        {
            get { return jmbg_kli; }
            set { jmbg_kli = value; OnPropertyChanged("JMBG_KLI"); }
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

        #endregion
    }
}
