﻿/*CretaceousCombo
 * Nathan Brown
 * Milestone 4
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class representing a combo meal
    /// </summary>
    public class CretaceousCombo: IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The PropertyChanged event handler; notifies of changes to the Price, Description, and Special properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        //Helper function for noifying of property changes
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Backing Variables
        private Size size;


        /// <summary>
        /// Gets and sets the entree
        /// </summary>
        public Entree Entree { get; set; }

        /// <summary>
        /// Gets and sets the side
        /// </summary>
        public Side Side { get; set; } = new Fryceritops();
            
        /// <summary>
        /// Gets and sets the drink
        /// </summary>
        public Drink Drink { get; set; } = new Sodasaurus();

        /// <summary>
        /// Gets the price of the combo
        /// </summary>
        public double Price
        {
            get
            {
                NotifyOfPropertyChange("Price");
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        /// <summary>
        /// Gets the calories of the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                NotifyOfPropertyChange("Calories");
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// Gets or sets the size of the combo
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
                NotifyOfPropertyChange("Size");
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Special");
            }
        }

        /// <summary>
        /// Gets the list of ingredients for the combo
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        
        /// <summary>
        /// Constructs a new combo with the specified entree
        /// </summary>
        /// <param name="entree">The entree to use</param>
        public CretaceousCombo(Entree entree)
        {
            this.Entree = entree;
            NotifyOfPropertyChange("Entree");
        }

        public override string ToString()
        {
            return $"{Entree} Combo";
        }

        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        public string[] Special
        {
            get
            {
                NotifyOfPropertyChange("Special");
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Special);
                ingredients.Add(Side.Description);
                ingredients.AddRange(Side.Special);
                ingredients.Add(Drink.Description);
                ingredients.AddRange(Drink.Special);
                return ingredients.ToArray();
            }
        }

    }
}
