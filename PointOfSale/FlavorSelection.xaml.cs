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
        public SodasaurusFlavor Flavor { get; set; }

        Sodasaurus diffSoda = new Sodasaurus();

        public FlavorSelection(Sodasaurus soda)
        {
            InitializeComponent();
            diffSoda = soda;
        }

        

        

        void DrinkSelectionPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection(diffSoda));
     
        }

        private void SelectVanilla(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement element)
            {
                diffSoda.Flavor = (SodasaurusFlavor)Enum.Parse(typeof(SodasaurusFlavor), element.Tag.ToString());
            }
            DrinkSelectionPage(sender, e);
        }

        private void SelectCola(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement element)
            {
                diffSoda.Flavor = (SodasaurusFlavor)Enum.Parse(typeof(SodasaurusFlavor), element.Tag.ToString());
            }
            DrinkSelectionPage(sender, e);
        }

        private void SelectOrange(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement element)
            {
                diffSoda.Flavor = (SodasaurusFlavor)Enum.Parse(typeof(SodasaurusFlavor), element.Tag.ToString());
            }
            DrinkSelectionPage(sender, e);
        }

        private void SelectRootBeer(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement element)
            {
                diffSoda.Flavor = (SodasaurusFlavor)Enum.Parse(typeof(SodasaurusFlavor), element.Tag.ToString());
            }
            DrinkSelectionPage(sender, e);
        }

        private void SelectLime(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement element)
            {
                diffSoda.Flavor = (SodasaurusFlavor)Enum.Parse(typeof(SodasaurusFlavor), element.Tag.ToString());
            }
            DrinkSelectionPage(sender, e);
        }

        private void SelectChocolate(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement element)
            {
                diffSoda.Flavor = (SodasaurusFlavor)Enum.Parse(typeof(SodasaurusFlavor), element.Tag.ToString());
            }
            DrinkSelectionPage(sender, e);
        }

        private void SelectCherry(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement element)
            {
                diffSoda.Flavor = (SodasaurusFlavor)Enum.Parse(typeof(SodasaurusFlavor), element.Tag.ToString());
            }
            DrinkSelectionPage(sender, e);
        }

        private void OnDone(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
