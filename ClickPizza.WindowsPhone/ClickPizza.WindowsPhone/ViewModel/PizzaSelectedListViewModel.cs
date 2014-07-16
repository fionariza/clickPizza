using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;

namespace ClickPizza.WindowsPhone.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class PizzaSelectedListViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the PizzaSelectedListViewModel class.
        /// </summary>
        public PizzaSelectedListViewModel()
        {

        }

        private readonly ObservableCollection<PizzaDetailsViewModel> _pizzaCollection = new ObservableCollection<PizzaDetailsViewModel>();

        public IEnumerable<PizzaDetailsViewModel> PizzaCollection
        {
            get { return _pizzaCollection; }
        }

    }
}