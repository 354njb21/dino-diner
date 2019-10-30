/*Drink.cs
 * Nathan Brown
 * Milestone 5
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract class that all drinks inherit from
    /// </summary>
    public abstract class Drink: IMenuItem, IOrderItem, INotifyPropertyChanged
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
        /// Description of the menu item
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Special instructions for the menu item
        /// </summary>
        public abstract string[] Special { get; }



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
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// The PropertyChanged event handler; notifies of changes to the Price, Description, and Special properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        //Helper function for noifying of property changes
        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual SodasaurusFlavor Flavor { get; set; }

    }
}
