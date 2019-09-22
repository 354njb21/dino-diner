/*Fryceritops
 * Nathan Brown
 * Milestone 2
 */
using DinoDiner.Menu.Sides;
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// The Fryceritops class inherits the Side class properties, lists the ingredients, and handles the size of the side with a switch statement
    /// </summary>
    public class Fryceritops : Side
    {
        protected Size size;

        /// <summary>
        /// Override method for setting the ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Potato", "Vegetable Oil", "Salt" };
            }
        }

        /// <summary>
        /// Override method to deal with the different sizes for the sides
        /// </summary>
        public override Size Size
        {

            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Small:
                        Price = .99;
                        Calories = 222;
                        break;
                }
            }

            get
            {
                return size;
            }

            
        }

        /// <summary>
        /// Setting the default price and calories
        /// </summary>
        public Fryceritops()
        {
            this.Price = 0.99;
            this.Calories = 222;
        }
    }
}
