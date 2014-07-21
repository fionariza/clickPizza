using System.Threading;

namespace ClickPizza.WindowsPhone.Model
{
    public class PizzaCartItemModel
    {
        public PizzaCartItemModel()
        {
        }

        public PizzaDetailsModel PizzaDetails { get; set; }

        public int Count { get; set; }
    }
}