using ClickPizza.WindowsPhone.ViewModel;
using Microsoft.Phone.Controls;

namespace ClickPizza.WindowsPhone.View
{
    public partial class PizzaSelectionPageView : PhoneApplicationPage
    {
        // Constructor
        public PizzaSelectionPageView()
        {
            InitializeComponent();
            DataContext = new PizzaSelectionPageViewModel();
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

    }
}