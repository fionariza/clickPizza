using ClickPizza.WindowsPhone.Model;
using GalaSoft.MvvmLight;

namespace ClickPizza.WindowsPhone.ViewModel
{
    public class PizzaCartItemViewModel : ViewModelBase
    {
        private PizzaCartItemModel _pizzacartItemModel;

        public  PizzaCartItemViewModel()
        { }

        public PizzaCartItemViewModel(PizzaCartItemModel model)
        {
            _pizzacartItemModel = model;
        }
        public int PizzaId
        {
            get { return _pizzacartItemModel.PizzaId; }
            set
            {
                if (_pizzacartItemModel.PizzaId == value)
                _pizzacartItemModel.PizzaId = value;
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