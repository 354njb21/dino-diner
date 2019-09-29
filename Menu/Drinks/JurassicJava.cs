using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurassicJava: Drink
    {
        public JurassicJava()
        {
            this.Calories = 2;
            this.Price = .59;
            this.Ice = false;
            this.RoomForCream = false;
            this.Decaf = false;
        }

        public bool RoomForCream;
        public bool Decaf;

        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Coffee" };
            }
        }

        public void LeaveRoomForCreamer()
        {
            RoomForCream = true;
        }

        public void AddIce()
        {
            Ice = true;
        }

        public void DecafCoffee()
        {
            Decaf = true;
        }
    }
}
