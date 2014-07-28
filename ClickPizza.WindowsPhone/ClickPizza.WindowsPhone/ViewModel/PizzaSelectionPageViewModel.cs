using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ClickPizza.WindowsPhone.Data;
using GalaSoft.MvvmLight;

namespace ClickPizza.WindowsPhone.ViewModel
{
    public class PizzaSelectionPageViewModel : ViewModelBase
    {
        private PizzaDetailsViewModel _selectedPizzaDetailsViewModel;
        public PizzaDetailsViewModel SelectedPizzaDetailsViewModel
        {
            get { return _selectedPizzaDetailsViewModel; }
            set
            {
                if (_selectedPizzaDetailsViewModel==value)
                _selectedPizzaDetailsViewModel = value;
                RaisePropertyChanged("SelectedPizzaDetailsViewModel");
            }
        }

        private ObservableCollection<PizzaDetailsViewModel> _pizzaCollection ;
        public IList<PizzaDetailsViewModel> PizzaCollection
        {
            get { return _pizzaCollection; }
        }

        public PizzaSelectionPageViewModel()
        {
            if (Cart.Instance.Count==0)
                _pizzaCollection = new ObservableCollection<PizzaDetailsViewModel>(
                    App.Repository.PizzaCollection.Select(
                        pizzaDetailsModel => new PizzaDetailsViewModel(pizzaDetailsModel)));
            else
            {
                _pizzaCollection = new ObservableCollection<PizzaDetailsViewModel>();
                foreach (var detailsModel in App.Repository.PizzaCollection)
                {
                    var count = 0;
                    Cart.Instance.СartDictionary.TryGetValue(detailsModel.Id, out count);
                    _pizzaCollection.Add(new PizzaDetailsViewModel(detailsModel, count));
                }
        }
    }

        public void Refresh()
        {
            _pizzaCollection = new ObservableCollection<PizzaDetailsViewModel>();
            foreach (var detailsModel in App.Repository.PizzaCollection)
            {
                var count = 0;
                Cart.Instance.СartDictionary.TryGetValue(detailsModel.Id, out count);
                _pizzaCollection.Add(new PizzaDetailsViewModel(detailsModel,count));
            }
        }

    }
}