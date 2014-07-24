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
            RaisePropertyChanged("Count");
            RaisePropertyChanged("HasItem");
        }
        
        public bool HasItem
        {
            get { return Count!=0; }
        }

        public int Count
        {
            get { return Cart.Instance.Count; }
        }
    }
}