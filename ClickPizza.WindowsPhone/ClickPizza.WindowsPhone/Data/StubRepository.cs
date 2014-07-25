using System;
using System.Collections.Generic;
using System.IO;
using ClickPizza.WindowsPhone.Model;

namespace ClickPizza.WindowsPhone.Data
{
    public class StubRepository :IRepository
    {
        private static readonly StubRepository _stubRepository = new StubRepository();

        public static StubRepository Instance
        {
            get
            {
                {
                    return _stubRepository;
                }                                                                                             
            }
        }

        private readonly IList<PizzaDetailsModel> _pizzaCollection = new List<PizzaDetailsModel>();
        public IEnumerable<PizzaDetailsModel> PizzaCollection { get { return _pizzaCollection; }  }

        public PizzaDetailsModel GetPizzaById(int id)
        {
            return _pizzaCollection[id];
        }
        private StubRepository()
        {

            for (var i = 1; i < 11; i++)
            {
                var path = @"../Assets/PizzaImages/"+ new Random().Next(1,4)+".jpg";
                _pizzaCollection.Add(new PizzaDetailsModel(i,path, @"Pizza № " + i, "Some composition", i * i, i + i, i *   100 / 3.0F));
            }
        }

        
    }
}
