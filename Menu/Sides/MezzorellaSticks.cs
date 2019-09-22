/*MezzorellaSticks
 * Nathan Brown
 * Milestone 1
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
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
    
    }
}
