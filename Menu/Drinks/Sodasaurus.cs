using MenuTest.Drinks;
using System;
using System.Collections.Generic;
using System.Text;
using static DinoDiner.Menu.Size;

namespace DinoDiner.Menu.Drinks 

{
    public class Sodasaurus : Drink
    {
        public SodasaurusFlavor Flavor { get; set; }

        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
            }
        }

        

    }
}
