using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        private Brontowurst brontowurst;

        public CustomizeBrontowurst(Brontowurst bronto)
        {
            InitializeComponent();
            this.brontowurst = bronto;
        }

        private void OnHoldOnion(object sender, RoutedEventArgs e)
        {
            brontowurst.HoldOnion();
        }

        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            brontowurst.HoldBun();
        }

        private void OnHoldPeppers(object sender, RoutedEventArgs e)
        {
            brontowurst.HoldPeppers();
        }

        private void OnDone(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
