/*Tyrannotea.cs
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
    /// Contains the elements for the tyrannotea drink
    /// </summary>
    public class Tyrannotea : Drink
    {

        
        /// <summary>
        /// Private backing variable for sweet
        /// </summary>
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
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Description");
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
                List<string> ingredients = new List<string>() { "Water", "Tea" };
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
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Calories");
                        NotifyOfPropertyChange("Description");
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Calories");
                        NotifyOfPropertyChange("Description");
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Calories");
                        NotifyOfPropertyChange("Description");
                        break;
                }

                if (Sweet)
                {
                    Calories *= 2;
                    Ingredients.Add("Cane Suagar");
                    NotifyOfPropertyChange("Calories");
                    NotifyOfPropertyChange("Description");
                    NotifyOfPropertyChange("Special");
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
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Overrides the ToString method based on the specific menu item
        /// </summary>
        /// <returns>The name of the menu item</returns>
        public override string ToString()
        {
            if (sweet)
            {
                if (size == Size.Large)
                {
                    return $"Large Sweet Tyrannotea";
                }
                else if (size == Size.Medium)
                {
                    return $"Medium Sweet Tyrannotea";
                }
                else
                {
                    return $"Small Sweet Tyrannotea";
                }
            }
            else
            {
                return "Tyrannotea";
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
                if (Lemon) special.Add("Add Lemon");
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }

    }
}
