using System.Collections.Generic;
using System.Linq;
using ClickPizza.WindowsPhone.Model;
using ClickPizza.WindowsPhone.ViewModel;

namespace ClickPizza.WindowsPhone.Data
{
    public class DataSource
    {
        private IEnumerable<PizzaDetailsModel> _pizzaCollection;

        public DataSource(IRepository repository)
        {
            _pizzaCollection = repository.GetPizzaCollection();
        }

        public IEnumerable<PizzaDetailsViewModel> PizzaCollection
        {
            get 
            {
                return _pizzaCollection.Select(pizzaDetailsModel => new PizzaDetailsViewModel(pizzaDetailsModel));
            }
        }
    }
}
