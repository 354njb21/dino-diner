/*TRexKingBurger
 * Nathan Brown
 * Milestone 2
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class for the TRex Burger
    /// </summary>
    public class TRexKingBurger: Entree
    {
        

        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;

        /// <summary>
        /// Constructor that sets the calories and price for the TRex burger
        /// </summary>
        public TRexKingBurger()
        {
            this.Calories = 728;
            this.Price = 8.45;
        }

        /// <summary>
        /// Ingredient list for the TRex burger
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Steakburger Pattie" };
                ingredients.Add("Steakburger Pattie");
                ingredients.Add("Steakburger Pattie");
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
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
        /// Sets the value of lettuce to false
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Sets the value of tomato to false
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }

        /// <summary>
        /// Sets the value of onion to false
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }

        /// <summary>
        /// Sets the value of pickle to false
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// Sets the value of ketchup to false
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Sets the value of mustard to false
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }

        /// <summary>
        /// Sets the value of mayo to false
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
        }
    }
}

