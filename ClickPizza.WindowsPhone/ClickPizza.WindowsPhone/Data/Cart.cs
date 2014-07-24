using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using ClickPizza.WindowsPhone.Model;

namespace ClickPizza.WindowsPhone.Data
{
    public sealed class Cart
    {
        private Cart()
        {
            PizzaCartDictionary = new Dictionary<PizzaDetailsModel, int>();
        }

        public event EventHandler CollectionChanged;

        private void OnCollectionChanged()
        {
            var handler = CollectionChanged;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        private Dictionary<PizzaDetailsModel, int> PizzaCartDictionary;

        public int Count
        {
            get { return PizzaCartDictionary.Sum(kv => kv.Value); }
        }

        public IEnumerable<PizzaCartItemModel> PizzaCartCollection
        {
            get 
            {
                return PizzaCartDictionary.Select(keyValue => new PizzaCartItemModel(keyValue.Key,keyValue.Value));
            }
        }

        public void Update(PizzaDetailsModel pizzaDetails, int count)
        {
            if (count == 0) { Delete(pizzaDetails); return; }
            PizzaCartDictionary[pizzaDetails] = count;
            OnCollectionChanged();
        }

        public void Delete(PizzaDetailsModel pizzaDetails)
        {
           if (PizzaCartDictionary.Remove(pizzaDetails))
            OnCollectionChanged();
        }

        static Cart _cartinstance;

        public static Cart Instance
        {
            get { return _cartinstance ?? (_cartinstance = new Cart()); }
        }

    }

}
