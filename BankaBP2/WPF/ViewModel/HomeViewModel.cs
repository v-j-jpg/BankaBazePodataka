﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.ViewModel
{
    public class HomeViewModel:BindableBase
    {
        private string homeViewStartMessage = "Hello!";

        public string HomeViewStartMessage
        {
            get { return homeViewStartMessage; } //return "Hello!";
        }
    }
}
