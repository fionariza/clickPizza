using System.Collections.Generic;
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
                yield return new PizzaDetailsModel(@"/Assets/AppllicationIcon.png", @"Pizza № " + i, "Some composition", i * i, i + i, i * 100 / 3);
            }
        }
    }
}
