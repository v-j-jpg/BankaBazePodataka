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

namespace WPF.View
{
    /// <summary>
    /// Interaction logic for BankaWindow.xaml
    /// </summary>
    public partial class BankaWindow : Window
    {
        public BankaWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            BankaBP2.CRUD.Banka_OP banka_OP = new BankaBP2.CRUD.Banka_OP();
            banka_OP.AddBank(NoviNaziv.Text);

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            BankaBP2.CRUD.Banka_OP banka_OP = new BankaBP2.CRUD.Banka_OP();
            banka_OP.DeleteBank(Int32.Parse(txtID.Text));
        }
    }
}
