/*Fryceritops
 * Nathan Brown
 * Milestone 4
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
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
                        size = Size.Large;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        size = Size.Medium;
                        break;
                    case Size.Small:
                        Price = .99;
                        Calories = 222;
                        size = Size.Small;
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


        /// <summary>
        /// Overrides the ToString method based on the specific menu item
        /// </summary>
        /// <returns>The name of the menu item</returns>
        public override string ToString()
        {
            if (size == Size.Small)
            {
                return $"Small Fryceritops";
            }
            else if(size == Size.Medium)
            {
                return $"Medium Fryceritops";
            }
            else
            {
                return $"Large Fryceritops";
            }
        }
    }
}
