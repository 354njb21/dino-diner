/*DrinkSelection
 * Nathan Brown
 * Point of Sale Milestone 2
 */
using DinoDiner.Menu;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// Public property instance of the Drink class
        /// </summary>
        public Drink Drink { get; set; }

        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the drink that has been selected
        /// </summary>
        /// <param name="drink">The drink being passed into the class</param>
        public DrinkSelection(Drink drink)
        {
            Drink = drink;
        }

        /// <summary>
        /// Sets the size of the drink
        /// </summary>
        /// <param name="size">The size being passed in from the selection</param>
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Drink != null)
            {
                this.Drink.Size = size;
            }
        }

        /// <summary>
        /// Adds the selected drink to the list of order items
        /// </summary>
        /// <param name="drink"></param>
        private void SelectDrink(Drink drink)
        {
            if (DataContext is Order order)
            {
                order.Add(drink);
                this.Drink = drink;
            }
        }

        /// <summary>
        /// Mehtod for adding the lemon button
        /// </summary>
        /// <param name="sender">References the controller</param>
        /// <param name="args">Represents the base class for classes that contain event data</param>
        private void SelectWater(object sender, RoutedEventArgs args)
        {
            Decaf.Visibility = Visibility.Hidden;
            Sweet.Visibility = Visibility.Hidden;
            Flavor.Visibility = Visibility.Hidden;
            Lemon.Visibility = Visibility.Visible;


           
            SelectDrink(new Water());

        }

        /// <summary>
        /// Method for adding a decaf button to the interface
        /// </summary>
        /// <param name="sender">References the controller</param>
        /// <param name="args">Represents the base class for classes that contain event data</param>
        private void SelectJava(object sender, RoutedEventArgs args)
        {
            Lemon.Visibility = Visibility.Hidden;
            Sweet.Visibility = Visibility.Hidden;
            Flavor.Visibility = Visibility.Hidden;
            Decaf.Visibility = Visibility.Visible;
            

            SelectDrink(new JurassicJava());
        }

        /// <summary>
        /// Method that adds the flavor button and then navigates to the flavor page
        /// </summary>
        /// <param name="sender">References the controller</param>
        /// <param name="args">Represents the base class for classes that contain event data</param>
        private void SelectSoda(object sender, RoutedEventArgs args)
        {
            Decaf.Visibility = Visibility.Hidden;
            Lemon.Visibility = Visibility.Hidden;
            Sweet.Visibility = Visibility.Hidden;
            Flavor.Visibility = Visibility.Visible;


            SelectDrink(new Sodasaurus());

        }

        /// <summary>
        /// Navigates to the flavor page
        /// </summary>
        /// <param name="sender">References the controller</param>
        /// <param name="args">Represents the base class for classes that contain event data</param>
        private void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection(Drink));
        }

        /// <summary>
        /// Adds the lemon and sweet buttons to the user interface
        /// </summary>
        /// <param name="sender">References the controller</param>
        /// <param name="args">Represents the base class for classes that contain event data</param>
        private void SelectTea(object sender, RoutedEventArgs args)
        {
            Decaf.Visibility = Visibility.Hidden;
            Flavor.Visibility = Visibility.Hidden;
            Lemon.Visibility = Visibility.Visible;
            Sweet.Visibility = Visibility.Visible;

            

            SelectDrink(new Tyrannotea());
        }

        /// <summary>
        /// Sets the size of the drink to small
        /// </summary>
        /// <param name="sender">References the controller</param>
        /// <param name="args">Represents the base class for classes that contain event data</param>
        protected void OnSelectSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }

        /// <summary>
        /// Sets the size of the drink to medium
        /// </summary>
        /// <param name="sender">References the controller</param>
        /// <param name="args">Represents the base class for classes that contain event data</param>
        protected void OnSelectMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        /// <summary>
        /// Sets the size of the drink to large
        /// </summary>
        /// <param name="sender">References the controller</param>
        /// <param name="args">Represents the base class for classes that contain event data</param>
        protected void OnSelectLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        

        
    }
}
