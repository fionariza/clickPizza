using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using ClickPizza.WindowsPhone.Data;
using ClickPizza.WindowsPhone.Tools;
using GalaSoft.MvvmLight;
using Microsoft.Phone.Controls;

namespace ClickPizza.WindowsPhone.ViewModel
{
    public class PizzaCartPageViewModel : ViewModelBase
    {
        public PizzaCartPageViewModel()
        {
            _pizzaCheckoutCollection = new ObservableCollection<PizzaDetailsViewModel>(Cart.Instance.CartCollection);
            var phoneApplicationFrame = Application.Current.RootVisual as PhoneApplicationFrame;
            if (phoneApplicationFrame != null)
                phoneApplicationFrame.Navigated += phoneApplicationFrame_Navigated;
        }


        void phoneApplicationFrame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            _pizzaCheckoutCollection = new ObservableCollection<PizzaDetailsViewModel>(Cart.Instance.CartCollection);
        }

        private ObservableCollection<PizzaDetailsViewModel> _pizzaCheckoutCollection;

        public IEnumerable<PizzaDetailsViewModel> PizzaCheckoutCollection
        {
            get { return _pizzaCheckoutCollection; }
        }
    }
}