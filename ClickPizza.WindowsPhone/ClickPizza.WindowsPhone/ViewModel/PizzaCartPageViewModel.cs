using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace ClickPizza.WindowsPhone.ViewModel
{
    public class PizzaCartPageViewModel : ViewModelBase
    {
        public PizzaCartPageViewModel()
        {
            GoToCheckoutCommand = new RelayCommand(GoToCheckout, CanCheckout);
        }
        
        void Refresh()
        {
            _pizzaCartCollection = new ObservableCollection<PizzaDetailsViewModel>(App.Repository.GetPizzaCollection().Select(pizzadetails => new PizzaDetailsViewModel(pizzadetails)));
        }

        private ObservableCollection<PizzaDetailsViewModel> _pizzaCartCollection;

        public IEnumerable<PizzaDetailsViewModel> PizzaCartCollection
        {
            get { return _pizzaCartCollection; }
        }

        #region CheckoutButton

        public RelayCommand GoToCheckoutCommand { get; private set; }

        private void GoToCheckout()
        {
            
        }

        private bool CanCheckout()
        {
            return true;
        }

        #endregion


    }
}