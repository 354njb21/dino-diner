using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        /// <summary>
        /// Public instance of the Menu class
        /// </summary>
        public Menu Menu { get; } = new Menu();

        public List<Entree> Entrees;

        public List<Side> Sides;

        public List<Drink> Drinks;

        public List<CretaceousCombo> Combos;

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        [BindProperty]
        public double minimumPrice { get; set; }

        [BindProperty]
        public double maximumPrice { get; set; }

        public HashSet<string> Ingredients { get; set; } = new HashSet<string>();

        public void OnGet()
        {
            Entrees = Menu.AvailableEntrees;
            Sides = Menu.AvailableSides;
            Drinks = Menu.AvailableDrinks;
            Combos = Menu.AvailableCombos;
        }

        public void OnPost()
        {
            Entrees = Menu.AvailableEntrees;
            Sides = Menu.AvailableSides;
            Drinks = Menu.AvailableDrinks;
            Combos = Menu.AvailableCombos;

            if (search != null)
            {
                Entrees = Menu.SearchEntrees(Entrees, search);
                Drinks = Menu.SearchDrinks(Drinks, search);
                Sides = Menu.SearchSides(Sides, search);
                Combos = Menu.SearchCombos(Combos, search);
            }

            if (menuCategory.Count != 0)
            {
                Entrees = new List<Entree>();
                Drinks = new List<Drink>();
                Sides = new List<Side>();
                Combos = new List<CretaceousCombo>();
                
                Entrees = Menu.FilterByMenuCategoryEntree(menuCategory);
                Drinks = Menu.FilterByMenuCategoryDrink(menuCategory);
                Sides = Menu.FilterByMenuCategorySide(menuCategory);
                Combos = Menu.FilterByMenuCategoryCombos(menuCategory);
            }

            if(minimumPrice != 0 && minimumPrice > 0)
            {
                

                Entrees = Menu.FilterByMinPriceEntree(Entrees, minimumPrice);
                Drinks = Menu.FilterByMinPriceDrink(Drinks, minimumPrice);
                Sides = Menu.FilterByMinPriceSide(Sides, minimumPrice);
                Combos = Menu.FilterByMinPriceCombo(Combos, minimumPrice);
            }

            if (maximumPrice != 0 && maximumPrice > 0)
            {


                Entrees = Menu.FilterByMaxPriceEntree(Entrees, maximumPrice);
                Drinks = Menu.FilterByMaxPriceDrink(Drinks, maximumPrice);
                Sides = Menu.FilterByMaxPriceSide(Sides, maximumPrice);
                Combos = Menu.FilterByMaxPriceCombo(Combos, maximumPrice);
            }

            Ingredients = Menu.PossibleIngredients;
        }
    }
}