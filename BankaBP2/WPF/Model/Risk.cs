using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Model
{
    public class Risk : INotifyPropertyChanged
    {


        private int ID;

        public int ID_KOMISIJE
        {
            get { return ID; }
            set { ID = value; OnPropertyChanged("ID_KOMISIJE"); }
        }
        private string br;

        public string BR_CLANOVA
        {
            get { return br; }
            set { br = value; OnPropertyChanged("BR_CLANOVA"); }
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
