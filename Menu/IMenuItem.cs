/*IMenuItem
 * Nathan Brown
 * Milestone 4
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface for the whole Dino Diner Project
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// Price property for the menu items
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Calories property for the menu items
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Ingredient list for the menu items
        /// </summary>
        List<string> Ingredients { get; }
    }
}
