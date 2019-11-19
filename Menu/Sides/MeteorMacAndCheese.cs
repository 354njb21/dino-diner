/*MeteorMacAndCheese
 * Nathan Brown
 * Milestone 5
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The MeteorMacAndCheese class inherits the Side class properties, lists the ingredients, and handles the size of the side with a switch statement
    /// </summary>
    public class MeteorMacAndCheese : Side, INotifyPropertyChanged
    {
        
        protected Size size;

        /// <summary>
        /// Setting the default price and calories
        /// </summary>
        public MeteorMacAndCheese()
        {
            this.Price = .99;
            this.Calories = 420;
        }

        /// <summary>
        /// Override method for setting the ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Macaroni Noodles, ", "Cheese Product, ", "Pork Sausage" };
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
                        Calories = 520;
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Calories");
                        NotifyOfPropertyChange("Description");
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Calories");
                        NotifyOfPropertyChange("Description");
                        break;
                    case Size.Small:
                        Price = .99;
                        Calories = 420;
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Calories");
                        NotifyOfPropertyChange("Description");
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
                return $"Small Meteor Mac and Cheese";
            }
            else if (size == Size.Medium)
            {
                return $"Medium Meteor Mac and Cheese";
            }
            else
            {
                return $"Large Meteor Mac and Cheese";
            }
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
