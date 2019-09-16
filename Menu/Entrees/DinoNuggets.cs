/*DinoNuggets
 * Nathan Brown
 * Milestone 1
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class for the Nuggets
    /// </summary>
    public class DinoNuggets
    {

        /// <summary>
        /// Public property for the price of nuggets
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Public property for the calrories of nuggets
        /// </summary>
        public uint Calories { get; set; }

        
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
        public List<string> Ingredients
        {
            
        get
            {
                List<string> ingredients = new List<string> ();

                for (int i = 0; i < counter; i++)
                {
                    ingredients.Add("Chicken Nugget");
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
        }



        
    }
}

