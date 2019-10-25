/*Order.cs
 * Nathan Brown
 * Menu Milestone 5
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class for a customer order
    /// </summary>
    public class Order: INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Collection of IOrderItem's 
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; protected set; }

        /// <summary>
        /// Subtotal cost of the customer order
        /// </summary>
        public double SubtotalCost
        {
            
        get
            {
                double cost = 0;
                foreach (IOrderItem order in Items)
                {
                    cost += order.Price;
                }

                if(cost < 0)
                {
                    return 0;
                }

                return cost;
            }
        }

        /// <summary>
        /// Sales tax rate (used Kansas tax rate)
        /// </summary>
        public double SalesTaxRate { get; protected set; } = 0.065;

        /// <summary>
        /// Sales tax rate of the order
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                double taxCost = SalesTaxRate * SubtotalCost;
                return taxCost;
            }
        }

        /// <summary>
        /// Total cost of the customer's order
        /// </summary>
        public double TotalCost
        {
            get
            {
                double total = SubtotalCost + SalesTaxCost;
                return total;
            }
        }

        public Order()
        {
            Items = new ObservableCollection<IOrderItem>();
            Items.CollectionChanged += OnCollectionChanged;
        }

        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
    }
}
