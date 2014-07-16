using System.Collections.Generic;
using ClickPizza.WindowsPhone.Model;
using ClickPizza.WindowsPhone.ViewModel;

namespace ClickPizza.WindowsPhone.Data
{
    public interface IRepository
    {
        IEnumerable<PizzaDetailsModel> GetPizzaCollection();
    }
}
