﻿using DinoDiner.Menu;
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        public Entree Entree { get; set; }

        public EntreeSelection()
        {
            InitializeComponent();
        }

        void OnAddPrehistoricPBJ(object sender, NavigationEventArgs args)
        {
            if(DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj));
            }
        }

        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            Entree = entree;
        }

        private void SelectEntree(Entree entree)
        {
            if(DataContext is Order order)
            {
                order.Add(entree);
                this.Entree = entree;
            }
        }

       public void AddVelociWrap(object sender, RoutedEventArgs args)
        {
            SelectEntree(new VelociWrap());
        }

        public void AddPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            SelectEntree(new PrehistoricPBJ());
        }

        public void AddSteakBurger(object sender, RoutedEventArgs args)
        {
            SelectEntree(new SteakosaurusBurger());
        }

        public void AddBrontowurst(object sender, RoutedEventArgs args)
        {
            SelectEntree(new Brontowurst());
        }

        public void AddDinoNuggets(object sender, RoutedEventArgs args)
        {
            SelectEntree(new DinoNuggets());
        }

        public void AddWings(object sender, RoutedEventArgs args)
        {
            SelectEntree(new PterodactylWings());
        }

        public void AddTrexBurger(object sender, RoutedEventArgs args)
        {
            SelectEntree(new TRexKingBurger());
        }
    }
}
