using ClickPizza.WindowsPhone.Model;
using GalaSoft.MvvmLight;

namespace ClickPizza.WindowsPhone.ViewModel
{
    public class CartItemViewModel : ViewModelBase
    {
        private PizzaCartItemModel _pizzacartItemModel;

        public  CartItemViewModel()
        { }
        public PizzaDetailsModel PizzaDetails
        {
            get { return _pizzacartItemModel.PizzaDetails; }
            set
            {
                if (_pizzacartItemModel.PizzaDetails == value)
                _pizzacartItemModel.PizzaDetails = value;
                RaisePropertyChanged("PizzaDetails");
            }
        }

        public int Count
        {
            get { return _pizzacartItemModel.Count; }
            set
            {
                if (_pizzacartItemModel.Count == value)
                    _pizzacartItemModel.Count = value;
                 RaisePropertyChanged("Count");
            }
        }
    }
}