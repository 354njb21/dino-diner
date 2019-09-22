﻿/*VelociWrap
 * Nathan Brown
 * Milestone 2
 */
using System.Collections.Generic;


namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class for the Wrap
    /// </summary>
    public class VelociWrap: Entree
    {
        

        private bool lettuce = true;
        private bool dressing = true;
        private bool cheese = true;

        /// <summary>
        /// Constructor sets the price and calories of the wrap
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;

        }

        /// <summary>
        /// List of ingredients in the wrap
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Chicken Breast" };
                ingredients.Add("Flour Tortilla");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Sets the value of lettuce to false
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Sets the value of dressing to false
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }

        /// <summary>
        /// Sets the value of cheese to false
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }
    }
}

