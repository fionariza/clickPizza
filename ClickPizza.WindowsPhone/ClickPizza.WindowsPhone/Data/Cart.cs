using ClickPizza.WindowsPhone.ViewModel;

namespace ClickPizza.WindowsPhone.Data
{
    public class Cart
    {
        private Cart()
        {
            CartButton = new PizzaCartButtonViewModel();
            CartPage = new PizzaCartPageViewModel();
        }

        static Cart _cartinstance;

        public static Cart Instance
        {
            get
            {
                if (_cartinstance == null) _cartinstance = new Cart();
                return _cartinstance;
            }
        }

        public PizzaCartButtonViewModel CartButton { get; set; }

        public  PizzaCartPageViewModel CartPage { get; set; }
    }


}
