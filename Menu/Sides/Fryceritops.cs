using DinoDiner.Menu.Sides;
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    class Fryceritops : Side
    {
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Potato", "Vegetable Oil", "Salt" };
            }
        }

        public Fryceritops()
        {
            this.Price = 0.99;
            this.Calories = 222;
        }
    }
}
