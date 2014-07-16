using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using ClickPizza.WindowsPhone.ViewModel;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace ClickPizza.WindowsPhone.View
{
    public partial class PizzaDetailsView : UserControl
    {
        public PizzaDetailsView()
        {
            InitializeComponent();
            DataContext = new PizzaDetailsViewModel();
        }
    }
}
