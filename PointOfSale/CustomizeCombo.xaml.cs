﻿/*CustomizeCombo
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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        public CustomizeCombo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Navigates to the side page
        /// </summary>
        /// <param name="sender">References the controller</param>
        /// <param name="args">Represents the base class for classes that contain event data</param>
        private void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }

        /// <summary>
        /// Navigates to the drink page
        /// </summary>
        /// <param name="sender">References the controller</param>
        /// <param name="args">Represents the base class for classes that contain event data</param>
        private void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
    }
}
