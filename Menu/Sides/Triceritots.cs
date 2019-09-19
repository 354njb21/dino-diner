using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu.Sides
{
    public class Triceritots: Side
    {

        public Triceritots()
        {
            this.Price = .99;
            this.Calories = 352;
        }

        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Potatoes", "Salt", "Vegetable Oil" };
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
                        Calories = 590;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Small:
                        Price = .99;
                        Calories = 352;
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

