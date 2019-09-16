﻿/*SteakosaurusBurger
 * Nathan Brown
 * Milestone 1
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class for the Steak Burger
    /// </summary>
    public class SteakosaurusBurger
    {
        private bool bun = true;
        private bool mustard = true;
        private bool ketchup = true;
        private bool pickle = true;
        private bool tomato = true;
        private bool onion = true;
        private bool lettuce = true;

        /// <summary>
        /// Public property for the price of the steak burger
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Public property for the calories of the steak burger
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Constructor sets the values of the price and calories for the steak burger
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Calories = 621;
            this.Price = 5.15;
        }

        /// <summary>
        /// List of ingredients on the steak burger
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Steakburger Pattie" };
                if (pickle) ingredients.Add("Pickle");
                if (mustard) ingredients.Add("Mustard");
                if (ketchup) ingredients.Add("Ketchup");
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (lettuce) ingredients.Add("Lettuce");
                return ingredients;
            }

        }

        /// <summary>
        /// Sets the value of bun to false
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;

        }

        /// <summary>
        /// Sets the value of mustard to false
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }

        /// <summary>
        /// Sets the value of ketchup to false
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Sets the value of pickle to false
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// Sets the value of tomato to false
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }

        /// <summary>
        /// Sets the value of lettuce to false
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Sets the value of onion to false
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }
    }
}
