using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;
using System.Linq;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        /// <summary>
        /// Public instance of the Menu class
        /// </summary>
        public Menu Menu { get; } = new Menu();

        public IEnumerable<Entree> Entrees;

        public IEnumerable<Side> Sides;

        public IEnumerable<Drink> Drinks;

        public IEnumerable<CretaceousCombo> Combos;

        public HashSet<string> PossibleIngredients = new HashSet<string>();

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        [BindProperty]
        public double minimumPrice { get; set; }

        [BindProperty]
        public double maximumPrice { get; set; }

        [BindProperty]
        public HashSet<string> SelectedIngredients { get; set; } = new HashSet<string>();

       

        public void OnGet()
        {
            Entrees = Menu.AvailableEntrees;
            Sides = Menu.AvailableSides;
            Drinks = Menu.AvailableDrinks;
            Combos = Menu.AvailableCombos;
            PossibleIngredients = Menu.PossibleIngredients;
        }

        public void OnPost()
        {
            Entrees = Menu.AvailableEntrees;
            Sides = Menu.AvailableSides;
            Drinks = Menu.AvailableDrinks;
            Combos = Menu.AvailableCombos;
            PossibleIngredients = Menu.PossibleIngredients;

            if (search != null)
            {
                Entrees = Entrees.Where(entree => entree.Description.Contains(search, StringComparison.OrdinalIgnoreCase));
                Drinks = Drinks.Where(drinks => drinks.Description.Contains(search, StringComparison.OrdinalIgnoreCase));
                Sides = Sides.Where(sides => sides.Description.Contains(search, StringComparison.OrdinalIgnoreCase));
                Combos = Combos.Where(combos => combos.Description.Contains(search, StringComparison.OrdinalIgnoreCase));
            }

            if (menuCategory.Count != 0)
            {
                Entrees = new List<Entree>();
                Drinks = new List<Drink>();
                Sides = new List<Side>();
                Combos = new List<CretaceousCombo>();
                foreach(string category in menuCategory)
                {
                    if(category == "Entree")
                    {
                        Entrees = Menu.AvailableMenuItems.OfType<Entree>();
                    }
                    else if(category == "Drink")
                    {
                        Drinks = Menu.AvailableMenuItems.OfType<Drink>();
                    }
                    else if(category == "Side")
                    {
                        Sides = Menu.AvailableMenuItems.OfType<Side>();
                    }
                    else
                    {
                        Combos = Menu.AvailableMenuItems.OfType<CretaceousCombo>();
                    }
                    
                }
                  
            }

            if(minimumPrice != 0 && minimumPrice > 0)
            {
                

                Entrees = Entrees.Where(entrees => entrees.Price >= minimumPrice);
                Drinks = Drinks.Where(drinks => drinks.Price >= minimumPrice);
                Sides = Sides.Where(sides => sides.Price >= minimumPrice);
                Combos = Combos.Where(combos => combos.Price >= minimumPrice);
            }

            if (maximumPrice != 0 && maximumPrice > 0)
            {


                Entrees = Entrees.Where(entrees => entrees.Price <= maximumPrice);
                Drinks = Drinks.Where(drinks => drinks.Price <= maximumPrice);
                Sides = Sides.Where(sides => sides.Price <= maximumPrice);
                Combos = Combos.Where(combos => combos.Price <= maximumPrice);
            }

            if(SelectedIngredients.Count != 0)
            {
                foreach(string item in SelectedIngredients)
                {
                    Entrees = Entrees.Where(entrees => !entrees.Ingredients.Contains(item));
                    Drinks = Drinks.Where(drinks => !drinks.Ingredients.Contains(item));
                    Sides = Sides.Where(sides => !sides.Ingredients.Contains(item));
                    Combos = Combos.Where(combos => !combos.Ingredients.Contains(item));
                }
                
            }

            

            
        }

        public double ComboPriceBySize(string size, CretaceousCombo combo)
        {
            CretaceousCombo tempCombo = combo;

            if(size == null)
            {
                return 0;
            }

            if(size == "small")
            {
                tempCombo.Size = Size.Small;
                return tempCombo.Price;
            }
            else if(size == "medium")
            {
                tempCombo.Size = Size.Medium;
                return tempCombo.Price;
            }
            else
            {
                tempCombo.Size = Size.Large;
                return tempCombo.Price;
            }
        }

        public double DrinkPriceBySize(string size, Drink drink)
        {
            Drink tempDrink = drink;

            if (size == null)
            {
                return 0;
            }

            if (size == "small")
            {
                tempDrink.Size = Size.Small;
                return tempDrink.Price;
            }
            else if (size == "medium")
            {
                tempDrink.Size = Size.Medium;
                return tempDrink.Price;
            }
            else
            {
                tempDrink.Size = Size.Large;
                return tempDrink.Price;
            }
        }

        public double SidePriceBySize(string size, Side side)
        {
            Side tempSide = side;

            if (size == null)
            {
                return 0;
            }

            if (size == "small")
            {
                tempSide.Size = Size.Small;
                return tempSide.Price;
            }
            else if (size == "medium")
            {
                tempSide.Size = Size.Medium;
                return tempSide.Price;
            }
            else
            {
                tempSide.Size = Size.Large;
                return tempSide.Price;
            }
        }
    }
}