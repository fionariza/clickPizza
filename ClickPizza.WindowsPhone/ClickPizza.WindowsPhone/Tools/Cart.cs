using System.Collections.Generic;
using System.Collections.ObjectModel;
using ClickPizza.WindowsPhone.ViewModel;

namespace ClickPizza.WindowsPhone.Tools
{
    public class Cart
    {
        private Cart(){}

        static readonly Cart _cartinstance = new Cart();

        public static Cart Instance
        {
            get { return _cartinstance; }
        }

        private ObservableCollection<PizzaDetailsViewModel> _cartCollection = new ObservableCollection<PizzaDetailsViewModel>();

        public IEnumerable<PizzaDetailsViewModel> CartCollection
        {
            get { return _cartCollection; }
        }

        public void Add(PizzaDetailsViewModel pizzaDetails)
        {
            _cartCollection.Add(pizzaDetails);
        }

        public void Remove(PizzaDetailsViewModel pizzaDetails)
        {
            _cartCollection.Remove(pizzaDetails);
        }

    }
}
