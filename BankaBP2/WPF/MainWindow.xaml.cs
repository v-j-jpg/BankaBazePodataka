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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WPF.View.BankaWindow window = new View.BankaWindow();
            WPF.ViewModel.BankaViewModel VM = new ViewModel.BankaViewModel();
            window.DataContext = VM;
            window.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WPF.View.FilijalaWindow window = new View.FilijalaWindow();
            window.ShowDialog();
        }

        private void Sluzbenici_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Klijenti_Click(object sender, RoutedEventArgs e)
        {
           View.KlijentiWindow win = new View.KlijentiWindow();
            win.ShowDialog();
         
        }
    }
}
