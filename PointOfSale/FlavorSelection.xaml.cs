/*FlavorSelection
 * Nathan Brown
 * Point of Sale Milestone 2
 */
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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        public Drink Drink { get; set; }

        

        public FlavorSelection(Drink drink)
        {
            InitializeComponent();
            Drink = drink;
        }

        

        

        private void DrinkFlavor(SodasaurusFlavor flavor)
        {
            if (DataContext is Order order)
            {
                if (Drink != null)
                {
                    this.Drink.Flavor = flavor;
                }
            }
     
        }

        private void SelectVanilla(object sender, RoutedEventArgs e)
        {
            DrinkFlavor(SodasaurusFlavor.Vanilla);
        }

        private void SelectCola(object sender, RoutedEventArgs e)
        {
            DrinkFlavor(SodasaurusFlavor.Cola);
        }

        private void SelectOrange(object sender, RoutedEventArgs e)
        {
            DrinkFlavor(SodasaurusFlavor.Orange);
        }

        private void SelectRootBeer(object sender, RoutedEventArgs e)
        {
            DrinkFlavor(SodasaurusFlavor.RootBeer);
        }

        private void SelectLime(object sender, RoutedEventArgs e)
        {
            DrinkFlavor(SodasaurusFlavor.Lime);
        }

        private void SelectChocolate(object sender, RoutedEventArgs e)
        {
            DrinkFlavor(SodasaurusFlavor.Chocolate);
        }

        private void SelectCherry(object sender, RoutedEventArgs e)
        {
            DrinkFlavor(SodasaurusFlavor.Cherry);
        }

        private void OnDone(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
