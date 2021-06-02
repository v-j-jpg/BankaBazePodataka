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
            }

        }
    }
}
