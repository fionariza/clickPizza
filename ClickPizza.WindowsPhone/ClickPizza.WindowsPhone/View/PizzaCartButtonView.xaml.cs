using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using ClickPizza.WindowsPhone.ViewModel;
using Microsoft.Phone.Controls;

namespace ClickPizza.WindowsPhone.View
{
    public partial class PizzaCartButtonView : UserControl
    {
        public PizzaCartButtonView()
        {
            InitializeComponent();
            DataContext = new PizzaCartButtonViewModel();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var phoneApplicationFrame = Application.Current.RootVisual as PhoneApplicationFrame;
            if (phoneApplicationFrame != null)
                phoneApplicationFrame.Navigate(new Uri("/View/PizzaCartPageView.xaml",UriKind.Relative));
        }
    }
}
