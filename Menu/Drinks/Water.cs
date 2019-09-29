using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water: Drink
    {
        public Water()
        {
            this.Calories = 0;
            this.Price = .10;
            this.lemon = false;
        }

        private bool lemon;

        public void AddLemon()
        {
            lemon = true;
        }

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water"};
                if (lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }
    }
}
