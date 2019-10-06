/*Drink.cs
 * Nathan Brown
 * Milestone 3
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract class that all drinks inherit from
    /// </summary>
    public abstract class Drink: IMenuItem
    {
        /// <summary>
        /// Virtual size public property that gets overriden in each drink class
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Inherited Price property for all drinks
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Inherited Calories property for all drinks
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Inherited List that can be overwritten for each drink
        /// </summary>
        public abstract List<string> Ingredients { get; }


       
        /// <summary>
        /// Public bool property for ice that each drink inherits
        /// </summary>
        public bool Ice = true;
        

        /// <summary>
        /// Method that turns the bool Ice to false
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }
        
    }
}
