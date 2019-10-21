using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IOrderItem
    {
        /// <summary>
        /// Price for the menu item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Description of the menu item
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Special instructions for the order
        /// </summary>
        string[] Special { get; }
    }
}
