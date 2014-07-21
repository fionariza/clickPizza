using GalaSoft.MvvmLight;

namespace ClickPizza.WindowsPhone.ViewModel
{
    public class PizzaCartButtonViewModel : ViewModelBase
    {
        private bool _hasItem;
        private int _count;

        public bool HasItem
        {
            get { return _hasItem; }
            set
            {
                if (_hasItem == value) return;
                _hasItem = value;
                RaisePropertyChanged("HasItem");
            }
        }

        public int Count
        {
            get { return _count; }
            set
            {
                if (_count == value) return;
                _count = value;
                RaisePropertyChanged("Count");
            }
        }
    }
}