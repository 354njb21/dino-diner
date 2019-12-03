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
        public float? minPrice { get; set; }

        [BindProperty]
        public float? maxPrice { get; set; }

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

            if(minPrice != null)
            {
                Entrees = Menu.FilterByMinPriceEntree(Entrees, (float)minPrice);
                Drinks = Menu.FilterByMinPriceDrink(Drinks, (float)minPrice);
                Sides = Menu.FilterByMinPriceSide(Sides, (float)minPrice);
                Combos = Menu.FilterByMinPriceCombo(Combos, (float)minPrice);
            }
        }
    }
}