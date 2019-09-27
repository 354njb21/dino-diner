using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public abstract class Drink
    {
        public Size Size;

        public double Price { get; set; }

        public uint Calories { get; set; }

        public abstract List<string> Ingredients { get; }


       

        public bool Ice = true;
        


        public void HoldIce()
        {
            Ice = false;
        }
        
    }
}
