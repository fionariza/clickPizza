using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ClickPizza.WindowsPhone.Data;
using GalaSoft.MvvmLight;

namespace ClickPizza.WindowsPhone.ViewModel
{

    public class PizzaSelectionPageViewModel : ViewModelBase
    {
        public PizzaSelectionPageViewModel()
        {
            _pizzaCollection = new ObservableCollection<PizzaDetailsViewModel>(
                App.Repository.GetPizzaCollection().Select(pizzaDetailsModel=> new PizzaDetailsViewModel(pizzaDetailsModel)));
        }

        private readonly ObservableCollection<PizzaDetailsViewModel> _pizzaCollection ;

        public IEnumerable<PizzaDetailsViewModel> PizzaCollection
        {
            get { return _pizzaCollection; }
        }

    }
}