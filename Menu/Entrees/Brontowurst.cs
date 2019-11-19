/*Brontowurst
 * Nathan Brown
 * Milestone 5
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the menu item Brontowurst
    /// </summary>
    public class Brontowurst: Entree
    {
        private bool onions = true;
        private bool bun = true;
        private bool peppers = true;

        

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
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (onions) ingredients.Add(", Onion");
                if (peppers) ingredients.Add(", Peppers");
                if (bun) ingredients.Add(", Whole Wheat Bun");
                return ingredients;
            }
        }

        /// <summary>
        /// Sets the value of the bool peppers to false
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Sets the value of the bool bun to false
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Sets the value of the bool onions to false
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Overrides the ToString method based on the specific menu item
        /// </summary>
        /// <returns>The name of the menu item</returns>
        public override string ToString()
        {
            return $"Brontowurst";
        }

        /// <summary>
        /// Description of the menu item
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
            
        }

        /// <summary>
        /// Special instructions for the menu item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!peppers) special.Add("Hold Peppers");
                if (!onions) special.Add("Hold Onion");
                if (!bun) special.Add("Hold Bun");
                return special.ToArray();
            }
        }
    }
}

