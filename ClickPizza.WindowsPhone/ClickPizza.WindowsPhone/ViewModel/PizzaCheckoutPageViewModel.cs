using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ClickPizza.WindowsPhone.Data;
using ClickPizza.WindowsPhone.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace ClickPizza.WindowsPhone.ViewModel
{
    public class PizzaCheckoutPageViewModel : ViewModelBase
    {
        public int TotalPizzaCount
        {
            get { return Cart.Instance.Count; }
        }

        public float TotalPizzaSum
        {
            get { return Cart.Instance.СartDictionary.Sum(x => App.Repository.GetPizzaById(x.Key).Price*x.Value); }
        }

        public string ClientName { get; set; }

        public int Cellphone { get; set; }

        private DateTime? _time;
        public DateTime? Time
        {
            get { return _time; }
            set
            {
                _time = value;
                RaisePropertyChanged("Time");
            }
        }

        
        private readonly ObservableCollection<CityModel> _city = new ObservableCollection<CityModel>();
        private float _totalPizzaSum;

        public IEnumerable<CityModel> City
        {
            get { return _city; }
        }

        public CityModel SelectedCity { get; set; }

        public string Address { get; set; }

        public RelayCommand SubmitCommand { get; private set; }

        public PizzaCheckoutPageViewModel()
        {
            SubmitCommand = new RelayCommand(OnSubmit, CanSubmit);
            _city.Add(new CityModel("Lvov", "lv"));
            _city.Add(new CityModel("Kiev", "kv"));
            _city.Add(new CityModel("Kharkov", "kh"));
            Time = DateTime.Now;
        }

        private bool CanSubmit()
        {
            return true;
        }

        private void OnSubmit()
        { }

        public void Refresh()
        {
            RaisePropertyChanged("TotalPizzaSum");
            RaisePropertyChanged("TotalPizzaCount");
        }
    }
}