/*Triceritots
 * Nathan Brown
 * Milestone 2
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// The Triceritots class inherits the Side class properties, lists the ingredients, and handles the size of the side with a switch statement
    /// </summary>
    public class Triceritots: Side
    {
        protected Size size;

        /// <summary>
        /// Setting the default price and calories
        /// </summary>
        public Triceritots()
        {
            this.Price = .99;
            this.Calories = 352;
        }

        /// <summary>
        /// Override method for setting the ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Potato", "Salt", "Vegetable Oil" };
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
                        Calories = 590;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Small:
                        Price = .99;
                        Calories = 352;
                        break;
                }
            }

            get
            {
                return size;
            }
        }
    }
}

