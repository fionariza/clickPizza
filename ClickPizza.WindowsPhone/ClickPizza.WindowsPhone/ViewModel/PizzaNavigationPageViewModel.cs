using System;
using System.Windows;
using ClickPizza.WindowsPhone.Data;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.Phone.Controls;

namespace ClickPizza.WindowsPhone.ViewModel
{
    public class PizzaNavigationPageViewModel : ViewModelBase
    {

        public PizzaNavigationPageViewModel()
        {
            NavigateCommand = new RelayCommand<string>(Navigation);
        }
        
        private void Navigation(string obj)
        {
            Cart.Instance.CartButton.Count++;
            var phoneApplicationFrame = Application.Current.RootVisual as PhoneApplicationFrame;
            if (phoneApplicationFrame != null)
                phoneApplicationFrame.Navigate(new Uri("/View/"+obj, UriKind.Relative));
        }

        public RelayCommand<string> NavigateCommand { get; private set; }

    }
}