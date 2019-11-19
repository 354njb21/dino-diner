/*DinoNuggets
 * Nathan Brown
 * Milestone 5
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the Nuggets
    /// </summary>
    public class DinoNuggets: Entree
    {

        

        private bool addNugget = true;

        private int counter = 6;

        /// <summary>
        /// Constructor for DinoNuggets that sets the price and calories
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
        }

        /// <summary>
        /// List for all of the ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            
        get
            {
                List<string> ingredients = new List<string> ();

                for (int i = 0; i < counter; i++)
                {
                    ingredients.Add("Chicken Nugget, ");
                }
                
                
                return ingredients;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void AddNugget()
        {
            if (addNugget == true)
            {
                Price = Price + .25;
                Calories = Calories + 59;
                counter++;
            }
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Calories");
            NotifyOfPropertyChange("Price");
        }

        /// <summary>
        /// Overrides the ToString method based on the specific menu item
        /// </summary>
        /// <returns>The name of the menu item</returns>
        public override string ToString()
        {
            return $"Dino-Nuggets";
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
                if (counter > 6)
                {
                    int extra = counter - 6;
                    special.Add(extra + " Extra Nuggets");
                    
                }
                return special.ToArray();
            }
        }
    }
}

