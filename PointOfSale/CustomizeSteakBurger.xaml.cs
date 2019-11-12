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
    /// Interaction logic for CustomizeSteakBurger.xaml
    /// </summary>
    public partial class CustomizeSteakBurger : Page
    {
        private SteakosaurusBurger steak;
        public CustomizeSteakBurger(SteakosaurusBurger steak)
        {
            InitializeComponent();
            this.steak = steak;
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

        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            steak.HoldBun();
        }

        private void OnHoldMustard(object sender, RoutedEventArgs e)
        {
            steak.HoldMustard();
        }

        private void OnHoldKetchup(object sender, RoutedEventArgs e)
        {
            steak.HoldKetchup();
        }

        private void OnHoldPickle(object sender, RoutedEventArgs e)
        {
            steak.HoldPickle();
        }

        private void OnHoldTomato(object sender, RoutedEventArgs e)
        {
            steak.HoldTomato();
        }

        private void OnHoldOnion(object sender, RoutedEventArgs e)
        {
            steak.HoldOnion();
        }

        private void OnHoldLettuce(object sender, RoutedEventArgs e)
        {
            steak.HoldLettuce();
        }
    }
}
