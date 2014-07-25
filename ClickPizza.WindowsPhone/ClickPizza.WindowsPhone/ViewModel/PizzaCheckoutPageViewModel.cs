using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ClickPizza.WindowsPhone.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace ClickPizza.WindowsPhone.ViewModel
{
    public class PizzaCheckoutPageViewModel : ViewModelBase
    {
        public PizzaCheckoutPageViewModel()
        {
            SubmitCommand = new RelayCommand(OnSubmit,CanSubmit);
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
        {
        }

        public int TotalPizzaCount { get; set; }
        public int TotalPizzaSum { get; set; }

        public string ClientName { get; set; }

        public int Cellphone { get; set; }

        public DateTime? Time
        {
            get { return _time; }
            set
            {
                _time = _time <= DateTime.Now ? DateTime.Now.AddHours(1) : value;
                RaisePropertyChanged("Time");
            }
        }

        private readonly ObservableCollection<CityModel> _city = new ObservableCollection<CityModel>();
        private DateTime? _time;

        public IEnumerable<CityModel> City
        {
            get { return _city; }
        }

        public CityModel SelectedCity { get; set; }

        public string Address { get; set; }

        public RelayCommand SubmitCommand { get; private set; }

    }
}