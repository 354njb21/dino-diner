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

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        [BindProperty]
        public double minimumPrice { get; set; }

        [BindProperty]
        public double maximumPrice { get; set; }

        [BindProperty]
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

                Entrees = Menu.AvailableEntrees.OfType(Entree);
                Drinks = Menu.FilterByMenuCategoryDrink(menuCategory);
                Sides = Menu.FilterByMenuCategorySide(menuCategory);
                Combos = Menu.FilterByMenuCategoryCombos(menuCategory);
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

            
        }
    }
}