using System;
using System.Collections.Generic;
using ClickPizza.WindowsPhone.Model;
using ClickPizza.WindowsPhone.ViewModel;
using Microsoft.Phone.Controls;

namespace ClickPizza.WindowsPhone.Data
{
    public class Cart
    {
        private Cart()
        {
            PizzaCartCollection = new Dictionary<PizzaDetailsModel, int>();
        }

        Dictionary<PizzaDetailsModel,int> PizzaCartCollection { get; set; }

        public void Update(PizzaDetailsModel pizzaDetails, int count)
        {
            if (count == 0){ PizzaCartCollection.Remove(pizzaDetails);
                return;
            }
            PizzaCartCollection[pizzaDetails] = count;
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

    }

}
