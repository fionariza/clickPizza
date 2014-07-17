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

        private StubRepository()
        { }

        public IEnumerable<PizzaDetailsModel> GetPizzaCollection()
        {
            for (var i = 1; i < 11; i++)
            {
                
                string path = @"../Assets/PizzaImages/"+ new Random().Next(1,4)+".jpg";
                yield return new PizzaDetailsModel(path, @"Pizza № " + i, "Some composition", i * i, i + i, i *   100 / 3.0F);
            }
        }
    }
}
