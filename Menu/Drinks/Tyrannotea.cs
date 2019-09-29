using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea: Drink
    {
        private bool sweet;

        private bool lemon;

        public Tyrannotea()
        {
            this.Calories = 8;
            this.Price = .99;
            this.sweet = false;
            this.lemon = false;
        }

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Tea" };
                if (lemon) ingredients.Add("Lemon");
                if (sweet) ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }


        public void AddSweetener()
        {
            sweet = true;
            Price *= 2;
            Calories *= 2;
        }

        public void AddLemon()
        {
            lemon = true;
        }
    }
}
