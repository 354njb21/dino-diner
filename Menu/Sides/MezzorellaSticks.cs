using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MezzorellaSticks: Side
    {
        public MezzorellaSticks()
        {
            this.Price = .99;
            this.Calories = 540;
        }

        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };
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
                        Calories = 720;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Small:
                        Price = .99;
                        Calories = 540;
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
