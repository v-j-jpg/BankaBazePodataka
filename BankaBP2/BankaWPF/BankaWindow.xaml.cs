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
        }
        public void Init()
        {

            BankaBP2.CRUD.Banka_OP operations_bank = new BankaBP2.CRUD.Banka_OP();
            // operations_bank.AddBank("Baaankica");

            foreach (var item in operations_bank.ReadBank())
            {
                Ispis.Text += item.ID + "  " + item.Naziv + "\n";
            }

            //operations_bank.UpdateBank("Blanka");
            // operations_bank.DeleteBank("NovaBanka");
        }
    }
    }
}
