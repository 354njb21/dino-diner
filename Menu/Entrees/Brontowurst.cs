/*Brontowurst
 * Nathan Brown
 * Milestone 1
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class for the menu item Brontowurst
    /// </summary>
    public class Brontowurst
    {
        private bool onions = true;
        private bool bun = true;
        private bool peppers = true;

        /// <summary>
        /// Public property for the price of the Brontowurst
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Public property for the calories of the Brontowurst
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Constructor sets the price and calories properties
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// List of all the ingredients in the Brontowurst
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (onions) ingredients.Add("Onion");
                if (peppers) ingredients.Add("Peppers");
                if (bun) ingredients.Add("Whole Wheat Bun");
                return ingredients;
            }
        }

        /// <summary>
        /// Sets the value of the bool peppers to false
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }

        /// <summary>
        /// Sets the value of the bool bun to false
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Sets the value of the bool onions to false
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
        }
    }
}

