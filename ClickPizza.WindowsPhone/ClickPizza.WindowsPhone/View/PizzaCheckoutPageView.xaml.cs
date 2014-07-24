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
            DataContext = new PizzaSelectionPageViewModel();
        }
    }
}