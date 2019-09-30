/*Tyrannotea.cs
 * Nathan Brown
 * Milestone 3
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Contains the elements for the tyrannotea drink
    /// </summary>
    public class Tyrannotea: Drink
    {
        private bool sweet;

        /// <summary>
        /// Public bool property for sweet tea
        /// </summary>
        public bool Sweet
        {
            get
            {
                return sweet;
            }
            set
            {
                sweet = value;
                this.Size = this.Size;
            }
        }

        /// <summary>
        /// Public bool property for adding a lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Instance of Size from the Drink class
        /// </summary>
        protected Size size;

        /// <summary>
        /// Sets the default values for the tea
        /// </summary>
        public Tyrannotea()
        {
            this.Price = .99;
            this.Calories = 8;
            this.Sweet = false;
            this.size = Size.Small;

        }

        /// <summary>
        /// The list of ingredients for the tyrannotea
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Tea"};
                if (Lemon) ingredients.Add("Lemon");
                if (Sweet) ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        /// <summary>
        /// Setting the calories and price for each size of tea using a switch statement
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = .99;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        break;
                }

                if (Sweet)
                {
                    Calories *= 2;
                    Ingredients.Add("Cane Suagar");
                }
            }
            get
            {
                return size;
            }
        }


        

        /// <summary>
        /// Adds a lemon to the tea
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }
    }
}
