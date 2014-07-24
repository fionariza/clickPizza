using System.Threading;

namespace ClickPizza.WindowsPhone.Model
{
    public class PizzaCartItemModel
    {
        public PizzaCartItemModel()
        {
        }

        public PizzaCartItemModel(int pizzaId,int count)
        {
            PizzaId = pizzaId;
            Count = count;
        }

        public int PizzaId { get; set; }

        public int Count { get; set; }
    }
}