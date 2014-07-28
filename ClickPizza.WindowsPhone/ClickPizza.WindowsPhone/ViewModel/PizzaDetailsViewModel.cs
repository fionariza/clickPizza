using System;
using ClickPizza.WindowsPhone.Data;
using ClickPizza.WindowsPhone.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace ClickPizza.WindowsPhone.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class PizzaDetailsViewModel : ViewModelBase
    {
        private PizzaDetailsModel _model;
        private int _count;
        private bool _isAddedToCart;

        /// <summary>
        /// Initializes a new instance of the PizzaDetailsViewModel class.
        /// </summary>
        public PizzaDetailsViewModel()
        {
        }
        
        public PizzaDetailsViewModel(PizzaDetailsModel model):this(model,0)
        {}
        public PizzaDetailsViewModel(PizzaDetailsModel model,int count)
        {
            _model = model;
            Count = count; 
            AddToCartCommand = new RelayCommand(AddToCart);
            CountMinusCommand = new RelayCommand(CountMinusCommandExecute);
            CountPlusCommand = new RelayCommand(CountPlusCommandExecute);
        }

        private void CountPlusCommandExecute()
        {
            Count++;
        }

        private void CountMinusCommandExecute()
        {
            Count--;
        }


        public PizzaDetailsModel GetModel
        {
            get { return _model; }
        }

        public Uri ImageUri { get { return new Uri(_model.ImageStringUri,UriKind.RelativeOrAbsolute); } }

        public string Name { get { return _model.Name; } }

        public string Composition { get { return _model.Composition; } }

        public int Length { get { return _model.Length; } }

        public int Weight {get { return _model.Weight; }}

        public float Price { get { return _model.Price; } }

        public int Count
        {
            get { return _count; }
            set
            {
                if (_count == value) return;
                _count = value;
                RaisePropertyChanged("Count");
                Cart.Instance.Update(_model.Id, _count);
                if (_count == 0) IsAddedToCart = false;
            }
        }

        public bool IsAddedToCart
        {
            get { return _isAddedToCart; }
            set
            {
                if (_isAddedToCart==value) return;
                _isAddedToCart = value;
                RaisePropertyChanged("IsAddedToCart");
            }
        }

        public RelayCommand CountMinusCommand { get; private set; }
        public RelayCommand CountPlusCommand { get; private set; }

        public RelayCommand AddToCartCommand { get; private set; }
        
        private void AddToCart()
        {
            IsAddedToCart = true;
            Count = 1;
            Cart.Instance.Update(_model.Id, Count);
        }

    }
}