using System;
using System.Windows;
using ClickPizza.WindowsPhone.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.Phone.Controls;

namespace ClickPizza.WindowsPhone.ViewModel
{
    public class PizzaCartItemViewModel : ViewModelBase
    {
        private PizzaCartItemModel _cartItemModel;
        private PizzaDetailsModel _pizzadetailsModel;

        public Uri ImageUri
        {
            get
            {
                return new Uri(_pizzadetailsModel.ImageStringUri,UriKind.RelativeOrAbsolute);
            }
        }

        public string Name
        {
            get { return _pizzadetailsModel.Name; }
        }

        public int Length
        {
            get { return _pizzadetailsModel.Length; }
        }

        public int Weight
        {
            get
            {
                return _pizzadetailsModel.Weight;
            }
        }

        public float Price
        {
            get
            {
                return _pizzadetailsModel.Price;
            }
        }

        public int Count
        {
            get { return _cartItemModel.Count; }
            set
            {
                if (_cartItemModel.Count == value)
                    _cartItemModel.Count = value;
                 RaisePropertyChanged("Count");
                 RaisePropertyChanged("TotalPrice");
            }
        }

        public float TotalPrice
        {
            get
            {
                return Count*Price;
            }
        }

        public RelayCommand EditCommand { get; private set; }
        private void EditCommandAction()
        {
            var phoneApplicationFrame = Application.Current.RootVisual as PhoneApplicationFrame;
            //При нажатии на кнопку - делаем навигацию на страницу выбора пиццы и передаем id
            if (phoneApplicationFrame != null)
                phoneApplicationFrame.Navigate(new Uri("/View/PizzaSelectionPageView.xaml?item=" + _cartItemModel.PizzaId,UriKind.RelativeOrAbsolute));
        }

        public  PizzaCartItemViewModel()
        { }

        public PizzaCartItemViewModel(PizzaCartItemModel model)
        {
            _cartItemModel = model;
            _pizzadetailsModel = App.Repository.GetPizzaById(_cartItemModel.PizzaId);
            EditCommand=new RelayCommand(EditCommandAction);
        }


    }
}