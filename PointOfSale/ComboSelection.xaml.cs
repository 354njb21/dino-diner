/*ComboSelection
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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Navigates to the customize combo page for all combos
        /// </summary>
        /// <param name="sender">References the controller</param>
        /// <param name="e">Represents the base class for classes that contain event data</param>
        private void Custom(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }
    }
}
