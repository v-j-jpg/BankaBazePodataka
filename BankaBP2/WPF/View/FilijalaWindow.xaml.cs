using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BankaBP2;

namespace WPF.View
{
    /// <summary>
    /// Interaction logic for FilijalaWindow.xaml
    /// </summary>
    public partial class FilijalaWindow : Window
    {
        public static BindingList<Filijala> filijale;

        BankaBP2.CRUD.Filijala_OP filOP = new BankaBP2.CRUD.Filijala_OP();
        BankaBP2.CRUD.Banka_OP banka_Op = new BankaBP2.CRUD.Banka_OP();

        public FilijalaWindow()
        {
            InitializeComponent();
            
            filijale = new BindingList<Filijala>(filOP.ReadFil().ToList());
            Filijalas.ItemsSource = filijale;
            listaBanaka.ItemsSource = new BindingList<Banka>(banka_Op.ReadBanks().ToList());
            listaBanakaEdit.ItemsSource = new BindingList<Banka>(banka_Op.ReadBanks().ToList());
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Filijalas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Filijala fil = (Filijala)Filijalas.SelectedItem;

            if (fil != null)
            {
                FIL_ID.Text = fil.ID_FIL.ToString();
                ADR_FIL.Text = fil.ADR_FIL;
                listaBanakaEdit.SelectedItem = fil.BankaID_Banka.ToString();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //save change
            Filijala f = new Filijala();
            if (FIL_ID.Text!=null && ADR_FIL!=null)
            {
                Banka banka = listaBanakaEdit.SelectedItem as Banka;
                filOP.UpdateBank(Int32.Parse(FIL_ID.Text), ADR_FIL.Text,banka.ID_Banka);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            filijale = new BindingList<Filijala>(filOP.ReadFil().ToList());
            Filijalas.ItemsSource = filijale;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (ADR_FIL != null)
            {
               Banka banka= listaBanaka.SelectedItem as Banka;

                filOP.AddFil(ADR_FIL_Copy.Text, banka.ID_Banka);
            
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Filijala fil = (Filijala)Filijalas.SelectedItem;

            if (fil != null)
            {
                filOP.DeleteFilijala(fil);
            }
        }
    }
}
