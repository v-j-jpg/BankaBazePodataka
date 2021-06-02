using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.ViewModel
{
  public  class KlijentiWindowViewModel:BindableBase
    {
        public MyICommand<string> NavCommand { get; private set; }
        private KlijentViewModel klijentViewModel = new KlijentViewModel();
        private HomeViewModel homeViewModel = new HomeViewModel();
        private BindableBase currentViewModel;
        private ZirantViewModel zirantViewModel = new ZirantViewModel();
        private SluzbenikViewModel sluzbenikViewModel = new SluzbenikViewModel();
        private RiskViewModel riskViewModel = new RiskViewModel();
        private OdlukaViewModel odlukaViewModel = new OdlukaViewModel();
        private OdobrenjeViewModel odobrenjeViewModel = new OdobrenjeViewModel();
        private IzdatiKreditiViewModel IzdatiKreditiViewModel = new IzdatiKreditiViewModel();

        public KlijentiWindowViewModel()
        {
            NavCommand = new MyICommand<string>(OnNav);
            CurrentViewModel = homeViewModel;

        }


        public BindableBase CurrentViewModel
        {
            get { return currentViewModel; }
            set
            {
                SetProperty(ref currentViewModel, value);
            }
        }

        private void OnNav(string destination)
        {
            switch (destination)
            {

                case "home":
                    CurrentViewModel = homeViewModel;
                    break;

                case "klijent":
                    CurrentViewModel = klijentViewModel;
                    break;

                case "zirant":
                    CurrentViewModel = zirantViewModel;
                    break;

                case "sluzbenik":
                    CurrentViewModel = sluzbenikViewModel;
                    break;

                case "odluka":
                    CurrentViewModel = odlukaViewModel;
                    break;

                case "risk":
                    CurrentViewModel = riskViewModel;
                    break;

                case "odobrenje":
                    CurrentViewModel = odobrenjeViewModel;
                    break;

                case "izdati":
                    CurrentViewModel = IzdatiKreditiViewModel;
                    break;
            }

        }
    }
}
