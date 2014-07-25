using System.Collections.Generic;
using ClickPizza.WindowsPhone.Model;

namespace ClickPizza.WindowsPhone.Data
{
    public interface IRepository
    {
        IEnumerable<PizzaDetailsModel> PizzaCollection { get; }
        PizzaDetailsModel GetPizzaById(int id);
    }
}
