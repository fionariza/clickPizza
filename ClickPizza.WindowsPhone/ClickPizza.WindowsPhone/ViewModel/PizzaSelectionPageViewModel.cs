using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace ClickPizza.WindowsPhone.ViewModel
{
    public class PizzaSelectionPageViewModel : ViewModelBase
    {
        public PizzaSelectionPageViewModel()
        {
            _pizzaCollection = new ObservableCollection<PizzaDetailsViewModel>(
                App.Repository.GetPizzaCollection.Select(pizzaDetailsModel=> new PizzaDetailsViewModel(pizzaDetailsModel)));
            AddToCartCommand=new RelayCommand(AddToCart);
        }


        private void AddToCart()
        {
           
        }

        private readonly ObservableCollection<PizzaDetailsViewModel> _pizzaCollection ;

        public RelayCommand AddToCartCommand { get; private set; }

        public IEnumerable<PizzaDetailsViewModel> PizzaCollection
        {
            get { return _pizzaCollection; }
        }

    }
}