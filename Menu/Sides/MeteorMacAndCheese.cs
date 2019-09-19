using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MeteorMacAndCheese : Side
    {

        public MeteorMacAndCheese()
        {
            this.Price = .99;
            this.Calories = 420;
        }


        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
            }
        }

        public override Size Size
        {
            
            set
            {
                Size = value;

                switch (Size)
                {
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Small:
                        Price = .99;
                        Calories = 420;
                        break;
                }
            }

            get
            {
                return Size;
            }
        }

    }
}
