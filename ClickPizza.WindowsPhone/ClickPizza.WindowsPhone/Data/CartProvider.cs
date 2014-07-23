using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickPizza.WindowsPhone.Data
{
    public class CartProvider
    {
        public CartProvider()
        { }

        public Cart Cart
        {
            get { return Cart.Instance; }
        }
    }
}
