/*JurassicJava.cs
 * Nathan Brown
 * Milestone 4
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the JurassicJava drink
    /// </summary>
    public class JurassicJava: Drink
    {
       

       
        /// <summary>
        /// Sets the default values for the JurassicJava
        /// </summary>
        public JurassicJava()
        {
            this.Calories = 2;
            this.Price = .59;
            this.Ice = false;
            this.RoomForCream = false;
            this.Decaf = false;
            this.size = Size.Small;
        }
        /// <summary>
        /// Bool that handles the creamer
        /// </summary>
        public bool RoomForCream;

        /// <summary>
        /// Bool that handles whether the coffee is decaf or not
        /// </summary>
        public bool Decaf;

        /// <summary>
        /// Instance of Size from the Drink class
        /// </summary>
        protected Size size;

        /// <summary>
        /// Ingredients for the JurassicJava
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Coffee" };
            }
        }


        /// <summary>
        /// Setting the calories and price for each size of coffee using a switch statement
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = .59;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = .99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// The customer wants room for creamer
        /// </summary>
        public void LeaveRoomForCreamer()
        {
            RoomForCream = true;
        }

        /// <summary>
        /// The customer wants ice coffee and ice bool set to true
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }

        /// <summary>
        /// The decaf bool is set to false
        /// </summary>
        public void DecafCoffee()
        {
            Decaf = true;
        }

        /// <summary>
        /// Overrides the ToString method based on the specific menu item
        /// </summary>
        /// <returns>The name of the menu item</returns>
        public override string ToString()
        {
            if (Decaf)
            {
               
                if (size == Size.Large)
                {
                    return $"Large Decaf Jurassic Java";
                }
                else if (size == Size.Medium)
                {
                    return $"Medium Decaf Jurassic Java";
                }
                else
                {
                    return $"Small Decaf Jurassic Java";
                }
        
            }
            else
            {
                if (size == Size.Large)
                {
                    return $"Large Jurassic Java";
                }
                else if (size == Size.Medium)
                {
                    return $"Medium Jurassic Java";
                }
                else
                {
                    return $"Small Jurassic Java";
                }
            }
        }
    }
}
