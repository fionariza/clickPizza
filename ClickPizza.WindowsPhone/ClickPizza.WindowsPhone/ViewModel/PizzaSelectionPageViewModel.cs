using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ClickPizza.WindowsPhone.Data;
using GalaSoft.MvvmLight;

namespace ClickPizza.WindowsPhone.ViewModel
{
    public class PizzaSelectionPageViewModel : ViewModelBase
    {
        private int _selectedPizzaDetailsIndex;
        public int SelectedPizzaDetailsIndex
        {
            get { return _selectedPizzaDetailsIndex; }
            set
            {
                _selectedPizzaDetailsIndex = value;
                RaisePropertyChanged("SelectedPizzaDetailsIndex");
            }
        }

        private readonly ObservableCollection<PizzaDetailsViewModel> _pizzaCollection = new ObservableCollection<PizzaDetailsViewModel>();
        public IList<PizzaDetailsViewModel> PizzaCollection
        {
            get { return _pizzaCollection; }
        }

        public PizzaSelectionPageViewModel()
        {
                _pizzaCollection = new ObservableCollection<PizzaDetailsViewModel>(
                    App.Repository.PizzaCollection.Select(
                        pizzaDetailsModel => new PizzaDetailsViewModel(pizzaDetailsModel)));
        }

    }
}