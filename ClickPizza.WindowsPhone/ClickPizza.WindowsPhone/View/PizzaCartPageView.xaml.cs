using System;
using System.Windows;
using ClickPizza.WindowsPhone.ViewModel;
using Microsoft.Phone.Controls;

namespace ClickPizza.WindowsPhone.View
{
    public partial class PizzaCartPageView : PhoneApplicationPage
    {
        // Constructor
        public PizzaCartPageView()
        {
            InitializeComponent();
            DataContext = new PizzaCartPageViewModel();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/PizzaCheckoutPageView.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}