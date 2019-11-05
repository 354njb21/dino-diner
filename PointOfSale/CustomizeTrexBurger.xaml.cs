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
    /// Interaction logic for CustomizeTrexBurger.xaml
    /// </summary>
    public partial class CustomizeTrexBurger : Page
    {
        private TRexKingBurger trex;

        public CustomizeTrexBurger(TRexKingBurger trex)
        {
            InitializeComponent();
            this.trex = trex;
        }

        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            trex.HoldBun();
        }

        private void OnHoldMustard(object sender, RoutedEventArgs e)
        {
            trex.HoldMustard();
        }

        private void OnHoldKetchup(object sender, RoutedEventArgs e)
        {
            trex.HoldKetchup();
        }

        private void OnHoldPickle(object sender, RoutedEventArgs e)
        {
            trex.HoldPickle();
        }

        private void OnHoldMayo(object sender, RoutedEventArgs e)
        {
            trex.HoldMayo();
        }

        private void OnHoldTomato(object sender, RoutedEventArgs e)
        {
            trex.HoldTomato();
        }

        private void OnHoldOnion(object sender, RoutedEventArgs e)
        {
            trex.HoldOnion();
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

        private void OnHoldLettuce(object sender, RoutedEventArgs e)
        {
            trex.HoldLettuce();
        }
    }
}
