using System.Windows.Navigation;
using ClickPizza.WindowsPhone.ViewModel;
using Microsoft.Phone.Controls;

namespace ClickPizza.WindowsPhone.View
{
    public partial class PizzaCheckoutPageView : PhoneApplicationPage
    {
        // Constructor
        public PizzaCheckoutPageView()
        {
            InitializeComponent();
            DataContext = new PizzaCheckoutPageViewModel();
        }

        private PizzaCheckoutPageViewModel ViewModel
        {
            get
            {
                return DataContext as PizzaCheckoutPageViewModel;
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            ViewModel.Refresh();
        }
    }
}