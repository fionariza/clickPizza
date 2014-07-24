using System.Linq;
using ClickPizza.WindowsPhone.Data;
using GalaSoft.MvvmLight;

namespace ClickPizza.WindowsPhone.ViewModel
{
    public class PizzaCartButtonViewModel : ViewModelBase
    {
        public PizzaCartButtonViewModel()
        {
            Cart.Instance.CollectionChanged += CartCollectionChanged;
        }

        void CartCollectionChanged(object sender, System.EventArgs e)
        {
            Count = Cart.Instance.PizzaCartCollection.Sum(im=>im.Count);
        }


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
                HasItem = Count != 0;
                RaisePropertyChanged("Count");
            }
        }
    }
}