using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Model
{
   public class Zirant : INotifyPropertyChanged
    {
        private int id_zir;

        public int ID_ZIR
        {
            get { return id_zir; }
            set
            {
                id_zir = value;
                OnPropertyChanged("ID_ZIR");

            }
        }

        private string ime_zir;

        public string IME_ZIR
        {
            get { return ime_zir; }
            set
            {
                ime_zir = value;
                OnPropertyChanged("IME_ZIR");

            }
        }
        private string prz_kli;

        public string PRZ_ZIR
        {
            get { return prz_kli; }
            set
            {
                prz_kli = value;
                OnPropertyChanged("PRZ_ZIR");


            }
        }
        private int plt_kli;

        public int PLT_ZIR
        {
            get { return plt_kli; }
            set
            {
                plt_kli = value;
                OnPropertyChanged("PLT_ZIR");
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

        #endregion
    }
}
