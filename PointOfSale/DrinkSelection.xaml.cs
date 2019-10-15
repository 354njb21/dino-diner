/*DrinkSelection
 * Nathan Brown
 * Milestone 5
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Mehtod for adding the lemon button
        /// </summary>
        /// <param name="sender">References the controller</param>
        /// <param name="args">Represents the base class for classes that contain event data</param>
        private void SelectWater(object sender, RoutedEventArgs args)
        {
            Button lemon = new Button();
            lemon.Height = 80;
            lemon.Width = 150;
            lemon.Content = "Lemon";
            Drinks.Children.Add(lemon);

        }

        /// <summary>
        /// Method for adding a decaf button to the interface
        /// </summary>
        /// <param name="sender">References the controller</param>
        /// <param name="args">Represents the base class for classes that contain event data</param>
        private void SelectJava(object sender, RoutedEventArgs args)
        {
            Button java = new Button();
            java.Height = 80;
            java.Width = 150;
            java.Content = "Decaf";
            Drinks.Children.Add(java);

        }

        /// <summary>
        /// Method that adds the flavor button and then navigates to the flavor page
        /// </summary>
        /// <param name="sender">References the controller</param>
        /// <param name="args">Represents the base class for classes that contain event data</param>
        private void SelectSoda(object sender, RoutedEventArgs args)
        {
            Button soda= new Button();
            soda.Height = 80;
            soda.Width = 150;
            soda.Content = "Flavor";
            Drinks.Children.Add(soda);
            soda.Click += new RoutedEventHandler(SelectFlavor);
            
        }

        /// <summary>
        /// Navigates to the flavor page
        /// </summary>
        /// <param name="sender">References the controller</param>
        /// <param name="args">Represents the base class for classes that contain event data</param>
        private void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        /// <summary>
        /// Adds the lemon and sweet buttons to the user interface
        /// </summary>
        /// <param name="sender">References the controller</param>
        /// <param name="args">Represents the base class for classes that contain event data</param>
        private void SelectTea(object sender, RoutedEventArgs args)
        {
            Button tea = new Button();
            tea.Height = 80;
            tea.Width = 150;
            tea.Content = "Sweet";
            Drinks.Children.Add(tea);

            Button lemon = new Button();
            lemon.Height = 80;
            lemon.Width = 150;
            lemon.Content = "Lemon";
            Drinks.Children.Add(lemon);

        }

        
    }
}
