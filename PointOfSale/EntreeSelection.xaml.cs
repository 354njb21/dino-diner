/*EntreeSelection
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        /// <summary>
        /// Public instance of the Entree base class
        /// </summary>
        public Entree Entree { get; set; }

        public EntreeSelection()
        {
            InitializeComponent();
        }


        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            Entree = entree;
        }

        /// <summary>
        /// Passes the entree that is being added to the order
        /// </summary>
        /// <param name="entree"></param>
        private void SelectEntree(Entree entree)
        {
            if(DataContext is Order order)
            {
                order.Add(entree);
                this.Entree = entree;
                
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Sets the entree to the veloci wrap
        /// </summary>
        /// <param name="sender">References the controller</param>
        /// <param name="args">Represents the base class for classes that contain event data</param>
        public void AddVelociWrap(object sender, RoutedEventArgs args)
        {
            VelociWrap wrap = new VelociWrap();
            SelectEntree(new VelociWrap());
            NavigationService.Navigate(new CustomizeVelociWrap(wrap));
        }

        /// <summary>
        /// Sets the entree being added to the Prehistoric PBJ
        /// </summary>
        /// <param name="sender">References the controller</param>
        /// <param name="args">Represents the base class for classes that contain event data</param>
        public void AddPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            SelectEntree(new PrehistoricPBJ());
            NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj));
        }

        /// <summary>
        /// Sets the entree being added to the Steakosaurus Burger
        /// </summary>
        /// <param name="sender">References the controller</param>
        /// <param name="args">Represents the base class for classes that contain event data</param>
        public void AddSteakBurger(object sender, RoutedEventArgs args)
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            SelectEntree(new SteakosaurusBurger());
            NavigationService.Navigate(new CustomizeSteakBurger(steak));
        }

        /// <summary>
        /// Sets the entree being added to the Brontowurst
        /// </summary>
        /// <param name="sender">References the controller</param>
        /// <param name="args">Represents the base class for classes that contain event data</param>
        public void AddBrontowurst(object sender, RoutedEventArgs args)
        {
            Brontowurst bronto = new Brontowurst(); 
            SelectEntree(new Brontowurst());
            NavigationService.Navigate(new CustomizeBrontowurst(bronto));
        }

        /// <summary>
        /// Sets the entree being added to the DinoNuggets
        /// </summary>
        /// <param name="sender">References the controller</param>
        /// <param name="args">Represents the base class for classes that contain event data</param>
        public void AddDinoNuggets(object sender, RoutedEventArgs args)
        {
            DinoNuggets nugs = new DinoNuggets();
            SelectEntree(new DinoNuggets());
            NavigationService.Navigate(new CustomizeDinoNuggets(nugs));
        }

        /// <summary>
        /// Sets the entree being added to the Pterodactyl Wings
        /// </summary>
        /// <param name="sender">References the controller</param>
        /// <param name="args">Represents the base class for classes that contain event data</param>
        public void AddWings(object sender, RoutedEventArgs args)
        {
            SelectEntree(new PterodactylWings());
        }

        /// <summary>
        /// Sets the entree being added to the Trex King Burger
        /// </summary>
        /// <param name="sender">References the controller</param>
        /// <param name="args">Represents the base class for classes that contain event data</param>
        public void AddTrexBurger(object sender, RoutedEventArgs args)
        {
            TRexKingBurger trex = new TRexKingBurger();
            SelectEntree(new TRexKingBurger());
            NavigationService.Navigate(new CustomizeTrexBurger(trex));
        }
    }
}
