/*Order.cs
 * Nathan Brown
 * Menu Milestone 5
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class for a customer order
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Collection of IOrderItem's 
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; }

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
    }
}
