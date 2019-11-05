﻿using System;
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
    /// Interaction logic for CusotmizeVelociWrap.xaml
    /// </summary>
    public partial class CustomizeVelociWrap : Page
    {
        private VelociWrap wrap;

        public CustomizeVelociWrap(VelociWrap wrap)
        {
            InitializeComponent();
            this.wrap = wrap;
        }

        private void OnHoldDressing(object sender, RoutedEventArgs e)
        {
            wrap.HoldDressing();
        }

        private void OnHoldLettuce(object sender, RoutedEventArgs e)
        {
            wrap.HoldLettuce();
        }

        private void OnHoldCheese(object sender, RoutedEventArgs e)
        {
            wrap.HoldCheese();
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
    }
}