using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Model
{
 public   class Odobrenje: INotifyPropertyChanged
    {
        private int ID;

        public int ID_ODLUKE
        {
            get { return ID; }
            set { ID = value; OnPropertyChanged("ID_ODLUKE"); }
        }
        private int RIS;

        public int RISK_ID
        {
            get { return RIS; }
            set { RIS = value; OnPropertyChanged("RISK_ID"); }
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
