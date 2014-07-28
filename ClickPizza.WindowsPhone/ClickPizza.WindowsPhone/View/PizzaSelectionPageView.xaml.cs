using System.Windows.Navigation;
using ClickPizza.WindowsPhone.Data;
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
        }

        private PizzaSelectionPageViewModel ViewModel
        {
            get { return (PizzaSelectionPageViewModel)DataContext; }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            int pizzaid;
            if (NavigationContext.QueryString.ContainsKey("item")
                && (int.TryParse(NavigationContext.QueryString["item"], out pizzaid)))
            {
                ViewModel.SelectedPizzaDetailsIndex = pizzaid-1;
            }    
        }
    }
}