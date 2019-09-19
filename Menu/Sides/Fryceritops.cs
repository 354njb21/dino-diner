﻿using DinoDiner.Menu.Sides;
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
    {
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Potato", "Vegetable Oil", "Salt" };
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
                        Calories = 480;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Small:
                        Price = .99;
                        Calories = 222;
                        break;
                }
            }

            get
            {
                return Size;
            }

            
        }

        public Fryceritops()
        {
            this.Price = 0.99;
            this.Calories = 222;
        }
    }
}
