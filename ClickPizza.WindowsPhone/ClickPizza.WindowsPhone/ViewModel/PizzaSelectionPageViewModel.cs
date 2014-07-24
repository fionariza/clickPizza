using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ClickPizza.WindowsPhone.Data;
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

        public PizzaDetailsViewModel SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                if (_selectedItem == value) return;
                _selectedItem = value;
                RaisePropertyChanged("SelectedItem");
            }
        }

        private void AddToCart()
        {
            Cart.Instance.Update(SelectedItem.GetModel,1);
        }

        private readonly ObservableCollection<PizzaDetailsViewModel> _pizzaCollection ;
        private PizzaDetailsViewModel _selectedItem;

        public RelayCommand AddToCartCommand { get; private set; }

        public IEnumerable<PizzaDetailsViewModel> PizzaCollection
        {
            get { return _pizzaCollection; }
        }

    }
}