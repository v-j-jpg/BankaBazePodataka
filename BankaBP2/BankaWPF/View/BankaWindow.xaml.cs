using BankaWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BankaWPF
{
    /// <summary>
    /// Interaction logic for BankaWindow.xaml
    /// </summary>
    public partial class BankaWindow : Window
    {
        public BankaWindow()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            BankaWindow window = new BankaWindow();
            BankaViewModel VM = new BankaViewModel();
            window.DataContext = VM;
           // window.ShowDialog();

        }
    }
    
}
