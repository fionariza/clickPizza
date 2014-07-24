using System.Threading;

namespace ClickPizza.WindowsPhone.Model
{
    public class PizzaCartItemModel
    {
        public PizzaCartItemModel()
        {
        }

        public PizzaCartItemModel(PizzaDetailsModel pizzaDetails,int count)
        {
            PizzaDetails = pizzaDetails;
            Count = count;
        }

        public PizzaDetailsModel PizzaDetails { get; set; }

        public int Count { get; set; }
    }
}