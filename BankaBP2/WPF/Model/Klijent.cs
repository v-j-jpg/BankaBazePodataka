using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

namespace WPF.Model
{
  public  class Klijent : INotifyPropertyChanged
    {
        private int jmgb_kli;

        public int JMBG_KLI
        {
            get { return jmgb_kli; }
            set
            {
                jmgb_kli = value;
                OnPropertyChanged("JMBG_KLI");

            }
        }

        private string ime_kli;

        public string IME_KLI
        {
            get { return ime_kli; }
            set
            {
                ime_kli = value;
                OnPropertyChanged("IME_KLI");

            }
        }
        private string prz_kli;

        public string PRZ_KLI
        {
            get { return prz_kli; }
            set
            {
                prz_kli = value;
                OnPropertyChanged("PRZ_KLI");


            }
        }
        private int plt_kli;

        public int PLT_KLI
        {
            get { return plt_kli; }
            set { 
                plt_kli = value;
                OnPropertyChanged("PLT_KLI");
                }
        }

        private int zirantID_ZIR;

        public int ZirantID_ZIR
        {
            get { return zirantID_ZIR; }
            set { zirantID_ZIR = value; OnPropertyChanged("ZirantID_ZIR"); }
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
