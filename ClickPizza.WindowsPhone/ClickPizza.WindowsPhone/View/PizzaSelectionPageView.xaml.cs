using System.Windows.Navigation;
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
            ViewModel.Refresh(); 
            int pizzaid;
            int count;
            //if (NavigationContext.QueryString.ContainsKey("item")
            //    &&(int.TryParse(NavigationContext.QueryString["item"],out pizzaid))
            //    &&Cart.Instance.СartDictionary.TryGetValue(pizzaid,out count))
            //{
            //    ViewModel.SelectedPizzaDetailsViewModel = new PizzaDetailsViewModel(App.Repository.GetPizzaById(pizzaid), count);
            //}    
        }
    }
}