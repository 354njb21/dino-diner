/*PterodactylWings
 * Nathan Brown
 * Milestone 1
 */
using System.Collections.Generic;


namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// This class contains the details for the wings menu item
    /// </summary>
    public class PterodactylWings
    {

        /// <summary>
        /// Public property for the price of the wings
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Public property for the calories of the wings
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Constructor setting the values of the price and calories for the wings
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        /// <summary>
        /// List of the ingredients for the wings
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken" };
                ingredients.Add("Wing Sauce");
                return ingredients;
            }
        }

    }
}



