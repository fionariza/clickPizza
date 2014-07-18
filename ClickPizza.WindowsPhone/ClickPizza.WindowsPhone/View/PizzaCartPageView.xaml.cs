using ClickPizza.WindowsPhone.ViewModel;
using Microsoft.Phone.Controls;

namespace ClickPizza.WindowsPhone.View
{
    public partial class PizzaCartPageView : PhoneApplicationPage
    {
        // Constructor
        public PizzaCartPageView()
        {
            InitializeComponent();
            DataContext = new PizzaCartPageViewModel();
        }
    }
}