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
            СartDictionary = new Dictionary<int, int>();
        }

        static Cart _cartinstance;

        public static Cart Instance
        {
            get { return _cartinstance ?? (_cartinstance = new Cart()); }
        }
        
        public event EventHandler CollectionChanged;

        private void OnCollectionChanged()
        {
            var handler = CollectionChanged;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        public Dictionary<int, int> СartDictionary { get; private set; }

        public int Count
        {
            get { return СartDictionary.Sum(kv => kv.Value); }
        }

        public IEnumerable<PizzaCartItemModel> CartCollection
        {
            get
            {
                return СartDictionary.Select(kv => new PizzaCartItemModel(kv.Key, kv.Value));
            }
        }

        public void Update(int pizzaId, int count)
        {
            if (count == 0) 
                СartDictionary.Remove(pizzaId);
            else
                СartDictionary[pizzaId] = count;
            OnCollectionChanged();
        }
        
    }

}
