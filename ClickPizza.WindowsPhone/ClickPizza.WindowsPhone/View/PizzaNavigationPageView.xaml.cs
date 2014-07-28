using System;
using System.Windows;
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
        }

        private void ChoosePizzaButton_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/PizzaSelectionPageView.xaml", UriKind.Relative));
        }

        private void DayPizza_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void Constructor_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void Settings_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/PizzaSettingsPageView.xaml", UriKind.Relative));
        }
    }
}