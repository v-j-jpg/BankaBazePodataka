using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Model
{
   public class Odluka: INotifyPropertyChanged
    {
        private int ID;

        public int ID_ODLUKA
        {
            get { return ID; }
            set { ID = value; OnPropertyChanged("ID_ODLUKA"); }
        }
        private string o;

        public string Odobreno
        {
            get { return o; }
            set { o = value; OnPropertyChanged("Odobreno"); }
        }
        private string dat;

        public string DAT_OD
        {
            get { return dat; }
            set { dat = value; OnPropertyChanged("DAT_OD"); }
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
