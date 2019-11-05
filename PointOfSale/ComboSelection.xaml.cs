/*ComboSelection
 * Nathan Brown
 * Milestone 5
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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public Entree Entree { get; set; }

        public CretaceousCombo combo { get; set; }



        public ComboSelection()
        {
            InitializeComponent();
        }

        public ComboSelection(Entree entree)
        {
            InitializeComponent();
            this.Entree = entree;
        }


        private void EntreeSelection(Entree entree)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(entree);
                order.Add(combo);
            }
        }

        private void CustomBronto(object sender, RoutedEventArgs args)
        {
            Brontowurst bronto = new Brontowurst();
            EntreeSelection(bronto);
            NavigationService.Navigate(new CustomizeBrontowurst(bronto));
        }

        private void CustomNuggets(object sender, RoutedEventArgs args)
        {
            DinoNuggets nugs = new DinoNuggets();
            EntreeSelection(nugs);
            NavigationService.Navigate(new CustomizeDinoNuggets(nugs));
        }

        private void CustomPBJ(object sender, RoutedEventArgs args)
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            EntreeSelection(pbj);
            NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj));
        }

        private void CustomWings(object sender, RoutedEventArgs args)
        {
            PterodactylWings wings = new PterodactylWings();
            EntreeSelection(wings);
            NavigationService.Navigate(new CustomizeWings(wings));
        }

        private void CustomSteakBurger(object sender, RoutedEventArgs args)
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            EntreeSelection(steak);
            NavigationService.Navigate(new CustomizeSteakBurger(steak));
        }

        private void CustomTrex(object sender, RoutedEventArgs args)
        {
            TRexKingBurger trex = new TRexKingBurger();
            EntreeSelection(trex);
            NavigationService.Navigate(new CustomizeTrexBurger(trex));
        }

        private void CustomWrap(object sender, RoutedEventArgs args)
        {
            VelociWrap wrap = new VelociWrap();
            EntreeSelection(wrap);
            NavigationService.Navigate(new CustomizeVelociWrap(wrap));
        }
    }
}
