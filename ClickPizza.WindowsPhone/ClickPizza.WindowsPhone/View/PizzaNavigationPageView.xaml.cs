using System;
using ClickPizza.WindowsPhone.ViewModel;
using Microsoft.Phone.Controls;

namespace ClickPizza.WindowsPhone.View
{
    public partial class PizzaNavigationPageView : PhoneApplicationPage
    {
        // Constructor
        public PizzaNavigationPageView()
        {
            InitializeComponent();
            DataContext = new PizzaNavigationPageViewModel();
        }

    }
}