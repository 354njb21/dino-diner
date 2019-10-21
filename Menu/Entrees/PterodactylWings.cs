/*PterodactylWings
 * Nathan Brown
 * Milestone 5
 */
using System.Collections.Generic;


namespace DinoDiner.Menu
{
    /// <summary>
    /// This class contains the details for the wings menu item
    /// </summary>
    public class PterodactylWings: Entree
    {

       

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
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken" };
                ingredients.Add("Wing Sauce");
                return ingredients;
            }
        }

        /// <summary>
        /// Overrides the ToString method based on the specific menu item
        /// </summary>
        /// <returns>The name of the menu item</returns>
        public override string ToString()
        {
            return $"Pterodactyl Wings";
        }

        /// <summary>
        /// Description for the menu order
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Special instructions for the menu order
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }


    }
}



