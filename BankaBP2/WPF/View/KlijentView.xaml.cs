﻿using System;
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

namespace WPF.View
{
    /// <summary>
    /// Interaction logic for KlijentView.xaml
    /// </summary>
    public partial class KlijentView : UserControl
    {
        public KlijentView()
        {
            InitializeComponent();
            this.DataContext = new WPF.ViewModel.KlijentViewModel();
        }
    }
}
