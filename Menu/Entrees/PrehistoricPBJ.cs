/*PrehistoricPBJ
 * Nathan Brown
 * Milestone 1
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class that contains the menu item PrehistoricPBJ and all of its details
    /// </summary>
    public class PrehistoricPBJ
    {
        private bool peanutButter = true;
        private bool jelly = true;

        /// <summary>
        /// Public property for the price of the PBJ 
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Public property for the calories of the PBJ
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// List containing all of the ingredients in the PBJ
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Sets the price and calories for the PBJ
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Sets the value of peanut butter to false
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        /// <summary>
        /// Sets the value of jelly to false
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
