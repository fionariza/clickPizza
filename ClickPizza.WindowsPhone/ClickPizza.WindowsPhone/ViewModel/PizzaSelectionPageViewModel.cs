using System.Collections.Generic;
using System.Collections.ObjectModel;
using ClickPizza.WindowsPhone.Data;
using GalaSoft.MvvmLight;

namespace ClickPizza.WindowsPhone.ViewModel
{

    public class PizzaSelectionPageViewModel : ViewModelBase
    {
        private DataSource _dataSource = new DataSource(StubRepository.Instance);

        public PizzaSelectionPageViewModel()
        {
            _pizzaCollection = new ObservableCollection<PizzaDetailsViewModel>(_dataSource.PizzaCollection);
        }

        private readonly ObservableCollection<PizzaDetailsViewModel> _pizzaCollection ;

        public IEnumerable<PizzaDetailsViewModel> PizzaCollection
        {
            get { return _pizzaCollection; }
        }

    }
}