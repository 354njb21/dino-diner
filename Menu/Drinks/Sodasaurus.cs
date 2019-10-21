/*Sodasaurus.cs
 * Nathan Brown
 * Milestone 5
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using static DinoDiner.Menu.Size;

namespace DinoDiner.Menu

{
    /// <summary>
    /// Contains the elements for a Sodasaurus
    /// </summary>
    public class Sodasaurus : Drink
    {
        

        /// <summary>
        /// Gets a description for this item
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Gets any special instructions for this order item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Private backing variable for the Flavor property
        /// </summary>
        private SodasaurusFlavor flavor;

        /// <summary>
        /// Sets the flavor of the soda
        /// </summary>
        public SodasaurusFlavor Flavor {
            get
            {
                return flavor;
                
            }
            set
            {
                flavor = value;
                NotifyOfPropertyChange("Flavor");
            }

        }

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
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Calories");
                        break;
                    case Medium:
                        Price = 2.00;
                        Calories = 156;
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Calories");
                        break;
                    case Large:
                        Price = 2.50;
                        Calories = 208;
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Calories");
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
            if (Flavor == SodasaurusFlavor.Cherry)
            {
                
                if (size == Size.Large)
                {
                    return $"Large Cherry Sodasaurus";
                }
                else if (size == Size.Medium)
                {
                    return $"Medium Cherry Sodasaurus";
                }
                else
                {
                    return $"Small Cherry Sodasaurus";
                }
            }
            else if(Flavor == SodasaurusFlavor.Chocolate)
            {
                
                if (size == Size.Large)
                {
                    return $"Large Chocolate Sodasaurus";
                }
                else if (size == Size.Medium)
                {
                    return $"Medium Chocolate Sodasaurus";
                }
                else
                {
                    return $"Small Chocolate Sodasaurus";
                }
            }
            else if(Flavor == SodasaurusFlavor.Cola)
            {
                
                if (size == Size.Large)
                {
                    return $"Large Cola Sodasaurus";
                }
                else if (size == Size.Medium)
                {
                    return $"Medium Cola Sodasaurus";
                }
                else
                {
                    return $"Small Cola Sodasaurus";
                }
            }
            else if(Flavor == SodasaurusFlavor.Lime)
            {
                
                if (size == Size.Large)
                {
                    return $"Large Lime Sodasaurus";
                }
                else if (size == Size.Medium)
                {
                    return $"Medium Lime Sodasaurus";
                }
                else
                {
                    return $"Small Lime Sodasaurus";
                }
            }
            else if(Flavor == SodasaurusFlavor.Orange)
            {
                
                if (size == Size.Large)
                {
                    return $"Large Orange Sodasaurus";
                }
                else if (size == Size.Medium)
                {
                    return $"Medium Orange Sodasaurus";
                }
                else
                {
                    return $"Small Orange Sodasaurus";
                }
            }
            else if(Flavor == SodasaurusFlavor.RootBeer)
            {
                
                if (size == Size.Large)
                {
                    return $"Large RootBeer Sodasaurus";
                }
                else if (size == Size.Medium)
                {
                    return $"Medium RootBeer Sodasaurus";
                }
                else
                {
                    return $"Small RootBeer Sodasaurus";
                }
            }
            else
            {
                if (size == Size.Large)
                {
                    return $"Large Vanilla Sodasaurus";
                }
                else if (size == Size.Medium)
                {
                    return $"Medium Vanilla Sodasaurus";
                }
                else
                {
                    return $"Small Vanilla Sodasaurus";
                }
            }
        }

    }
}
