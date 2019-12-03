/*SteakosaurusBurger
 * Nathan Brown
 * Milestone 5
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the Steak Burger
    /// </summary>
    public class SteakosaurusBurger: Entree
    {

        

        private bool bun = true;
        private bool mustard = true;
        private bool ketchup = true;
        private bool pickle = true;
        private bool tomato = true;
        private bool onion = true;
        private bool lettuce = true;

        

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
        public override List<string> Ingredients
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
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Sets the value of mustard to false
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Sets the value of ketchup to false
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Sets the value of pickle to false
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Sets the value of tomato to false
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Sets the value of lettuce to false
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Sets the value of onion to false
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Overrides the ToString method based on the specific menu item
        /// </summary>
        /// <returns>The name of the menu item</returns>
        public override string ToString()
        {
            return $"Steakosaurus Burger";
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
                if (!onion) special.Add("Hold Onion");
                if (!lettuce) special.Add("Hold Lettuce");
                if (!bun) special.Add("Hold Bun");
                if (!pickle) special.Add("Hold Pickle");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                if (!tomato) special.Add("Hold Tomato");
                return special.ToArray();
            }
        }
    }
}

