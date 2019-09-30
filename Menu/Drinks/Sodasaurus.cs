/*Sodasaurus.cs
 * Nathan Brown
 * Milestone 3
 */
using MenuTest.Drinks;
using System;
using System.Collections.Generic;
using System.Text;
using static DinoDiner.Menu.Size;

namespace DinoDiner.Menu.Drinks 

{
    /// <summary>
    /// Contains the elements for a Sodasaurus
    /// </summary>
    public class Sodasaurus : Drink
    {

        /// <summary>
        /// Sets the flavor of the soda
        /// </summary>
        public SodasaurusFlavor Flavor { get; set; }

        /// <summary>
        /// Ingredients of the soda
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
            }
        }

        /// <summary>
        /// Sets the default values of Sodasaurus
        /// </summary>
        public Sodasaurus()
        {
            this.Calories = 112;
            this.Price = 1.50;
            this.size = Size.Small;
        }

        /// <summary>
        /// Instance of Size from the Drink class
        /// </summary>
        protected Size size;


        /// <summary>
        /// Setting the calories and price for each size of soda using a switch statement
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Large:
                        Price = 2.50;
                        Calories = 208;
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
