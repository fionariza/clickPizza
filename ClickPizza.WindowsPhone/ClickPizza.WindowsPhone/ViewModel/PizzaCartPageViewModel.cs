using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using ClickPizza.WindowsPhone.Data;
using ClickPizza.WindowsPhone.Tools;
using GalaSoft.MvvmLight;
using Microsoft.Phone.Controls;

namespace ClickPizza.WindowsPhone.ViewModel
{
    public class PizzaCartPageViewModel : ViewModelBase
    {
        public PizzaCartPageViewModel()
        {
            Cart.Instance.NewCollection(new DataSource(StubRepository.Instance).PizzaCollection);
            var phoneApplicationFrame = Application.Current.RootVisual as PhoneApplicationFrame;
            if (phoneApplicationFrame != null)
                phoneApplicationFrame.Navigated += phoneApplicationFrame_Navigated;
        }

        void phoneApplicationFrame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            _pizzaCartCollection = new ObservableCollection<PizzaDetailsViewModel>(Cart.Instance.CartCollection);
            RaisePropertyChanged("PizzaCartCollection");
        }

        private ObservableCollection<PizzaDetailsViewModel> _pizzaCartCollection;

        public IEnumerable<PizzaDetailsViewModel> PizzaCartCollection
        {
            get { return _pizzaCartCollection; }
        }
    }
}