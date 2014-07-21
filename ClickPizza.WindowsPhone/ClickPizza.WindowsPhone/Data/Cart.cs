using System.Collections.Generic;
using System.Collections.ObjectModel;
using ClickPizza.WindowsPhone.ViewModel;

namespace ClickPizza.WindowsPhone.Data
{
    public class Cart
    {
        private Cart()
        {}

        static readonly Cart _cartinstance = new Cart();

        public static Cart Instance
        {
            get { return _cartinstance; }
        }

        PizzaCartButtonViewModel CartButton { get; set; }

        PizzaCartPageViewModel CartPage { get; set; }
    }
}
