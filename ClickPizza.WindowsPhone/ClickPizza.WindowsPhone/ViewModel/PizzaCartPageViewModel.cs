using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ClickPizza.WindowsPhone.Data;
using GalaSoft.MvvmLight;

namespace ClickPizza.WindowsPhone.ViewModel
{
    public class PizzaCartPageViewModel : ViewModelBase
    {
        public PizzaCartPageViewModel()
        {
            _pizzaCartCollection = new ObservableCollection<PizzaCartItemViewModel>(Cart.Instance.CartCollection.Select(x => new PizzaCartItemViewModel(x)));
        }

        void Refresh()
        {
            _pizzaCartCollection = new ObservableCollection<PizzaCartItemViewModel>(Cart.Instance.CartCollection.Select(x=>new PizzaCartItemViewModel(x)));
        }

        private ObservableCollection<PizzaCartItemViewModel> _pizzaCartCollection;

        public IEnumerable<PizzaCartItemViewModel> PizzaCartCollection
        {
            get { return _pizzaCartCollection; }
        }

    }
}