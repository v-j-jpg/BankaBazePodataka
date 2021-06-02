using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Model
{
  public  class Sluzbenik: INotifyPropertyChanged
    {
        private int jmbg_rad;

        public int JMBG_RAD
        {
            get { return jmbg_rad; }
            set { jmbg_rad = value; OnPropertyChanged("JMBG_RAD"); }
        }

        private string ime;

        public string IME_RAD
        {
            get { return ime; }
            set { ime = value; OnPropertyChanged("IME_RAD"); }
        }

        private string prz;

        public string PRZ_RAD
        {
            get { return prz; }
            set { prz = value; OnPropertyChanged("PRZ_RAD"); }
        }
        // k.Filijala.ID_FIL = id_fil;
      //  k.Filijala.BankaID_Banka = id_bank;
        private int filijalaID_FIL;

        public int FilijalaID_FIL
        {
            get { return filijalaID_FIL; }
            set { filijalaID_FIL = value; OnPropertyChanged("FilijalaID_FIL"); }
        }

        private int bankaID;

        public int FilijalaBankaID_Banka
        {
            get { return bankaID; }
            set { bankaID = value; OnPropertyChanged("FilijalaBankaID_Banka"); }
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
