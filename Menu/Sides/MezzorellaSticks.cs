﻿/*MezzorellaSticks
 * Nathan Brown
 * Milestone 4
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The MezzorellaSticks class inherits the Side class properties, lists the ingredients, and handles the size of the side with a switch statement
    /// </summary>
    public class MezzorellaSticks: Side
    {
        


        protected Size size;

        
      
        /// <summary>
        /// Setting the default price and calories
        /// </summary>
        public MezzorellaSticks()
        {
            this.Price = .99;
            this.Calories = 540;
        }

        /// <summary>
        /// Override method for setting the ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };
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
                        Calories = 720;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Small:
                        Price = .99;
                        Calories = 540;
                        break;
                }
            }

            get
            {
                return size;
            }
        }

        /// <summary>
        /// Overrides the ToString method based on the specific menu item
        /// </summary>
        /// <returns>The name of the menu item</returns>
        public override string ToString()
        {
            if (size == Size.Small)
            {
                return $"Small Mezzorella Sticks";
            }
            else if (size == Size.Medium)
            {
                return $"Medium Mezzorella Sticks";
            }
            else
            {
                return $"Large Mezzorella Sticks";
            }
        }

    }
}
