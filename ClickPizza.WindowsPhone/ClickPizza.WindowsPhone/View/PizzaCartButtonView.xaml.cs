using System.Windows;
using System.Windows.Controls;
using ClickPizza.WindowsPhone.ViewModel;

namespace ClickPizza.WindowsPhone.View
{
    public partial class PizzaCartButtonView : UserControl
    {
        public PizzaCartButtonView()
        {
            InitializeComponent();
            DataContext = new PizzaCartButtonViewModel();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
