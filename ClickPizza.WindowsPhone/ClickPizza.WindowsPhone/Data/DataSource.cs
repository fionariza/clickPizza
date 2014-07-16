using System.Collections.Generic;
using ClickPizza.WindowsPhone.Model;

namespace ClickPizza.WindowsPhone.Data
{
    public class DataSource
    {
        private IEnumerable<PizzaDetailsModel> _pizzaCollection;

        public DataSource(IRepository repository)
        {
            _pizzaCollection = repository.GetPizzaList();
        }

        public IEnumerable<PizzaDetailsModel> PizzaCollection
        {
            get { return _pizzaCollection; }
        }
    }
}
