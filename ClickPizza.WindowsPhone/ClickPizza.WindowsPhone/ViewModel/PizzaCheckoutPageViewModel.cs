using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using ClickPizza.WindowsPhone.Data;
using ClickPizza.WindowsPhone.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;

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
            stub();
        }

        private bool CanSubmit()
        {
            return true;
        }

        private void OnSubmit()
        {
            var smscomposeTask = new SmsComposeTask {To = "389-57-54", Body = Serialize()};
            smscomposeTask.Show();
            var phoneApplicationFrame = Application.Current.RootVisual as PhoneApplicationFrame;
            //При нажатии на кнопку - делаем навигацию на страницу выбора пиццы и передаем id
            if (phoneApplicationFrame != null)
                phoneApplicationFrame.Navigate(new Uri("/View/PizzaThankYouPageView.xaml", UriKind.RelativeOrAbsolute));
        }

        private string Serialize()
        {
            string message = Cart.Instance.CartCollection.Aggregate(String.Empty, (current, cartitemModel) => current + (cartitemModel.PizzaId + "," + cartitemModel.Count + "+"));
            message.Remove(message.Length - 1);
            return message+"|" + (ClientName + "+" + Cellphone + "+" + Address);
         }

        public void Refresh()
        {
            RaisePropertyChanged("TotalPizzaSum");
            RaisePropertyChanged("TotalPizzaCount");
        }

        private void stub()
        {
            Cart.Instance.Update(1,1);
            Cart.Instance.Update(3, 1);
            ClientName = "Olia";  
            Cellphone = 096453;
            Address = "sdfjwefi";
        }
    }
}