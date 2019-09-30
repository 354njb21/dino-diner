/*Water.cs
 * Nathan Brown
 * Milestone 3
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Class for water elements
    /// </summary>
    public class Water: Drink
    {

        /// <summary>
        /// Sets the default values for water
        /// </summary>
        public Water()
        {
            this.Calories = 0;
            this.Price = .10;
            this.Lemon = false;
            this.Ice = true;
        }

        /// <summary>
        /// Public bool for adding a lemon
        /// </summary>
        public bool Lemon;

        /// <summary>
        /// Instance of Size from the Drink class
        /// </summary>
        protected Size size;

        /// <summary>
        /// The customer want a lemon in their water: Lemon is set to true
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }

        /// <summary>
        /// Ingredients in water with or wihtout lemon
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water"};
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// The calories and price for water never change
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                Price = .10;
                Calories = 0;
            }
            get
            {
                return size;
            }
        }

    }
}
