/*Menu
 * Nathan Brown
 * Milestone 4
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class controls public properties related to the Dino Diner menu and overrides the ToString method to list all ingredients
    /// </summary>
    public class Menu
    {

        public HashSet<string> PossibleIngredients
        {
            get
            {
                HashSet<string> Ingredients = new HashSet<string>();
                foreach (Entree entree in AvailableEntrees)
                {
                    foreach (string ingredient in entree.Ingredients)
                        if (Ingredients.Contains(ingredient) == false)
                        {
                            Ingredients.Add(ingredient);
                        }


                }

                foreach (Side side in AvailableSides)
                {
                    foreach (string ingredient in side.Ingredients)
                        if (Ingredients.Contains(ingredient) == false)
                        {
                            Ingredients.Add(ingredient);
                        }


                }

                foreach (Drink drink in AvailableDrinks)
                {
                    foreach (string ingredient in drink.Ingredients)
                        if (Ingredients.Contains(ingredient) == false)
                        {
                            Ingredients.Add(ingredient);
                        }
                }

                return Ingredients;
            }
        }
        
        

        /// <summary>
        /// List of all the available menu items
        /// </summary> 
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> menuItems = new List<IMenuItem>();

                JurassicJava java = new JurassicJava();
                Sodasaurus soda = new Sodasaurus();
                Tyrannotea tea = new Tyrannotea();
                Water water = new Water();

                menuItems.Add(java);
                menuItems.Add(soda);
                menuItems.Add(tea);
                menuItems.Add(water);

                Brontowurst brat = new Brontowurst();
                DinoNuggets nuggets = new DinoNuggets();
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                PterodactylWings wings = new PterodactylWings();
                SteakosaurusBurger steak = new SteakosaurusBurger();
                TRexKingBurger trex = new TRexKingBurger();
                VelociWrap wrap = new VelociWrap();

                menuItems.Add(brat);
                menuItems.Add(nuggets);
                menuItems.Add(pbj);
                menuItems.Add(wings);
                menuItems.Add(steak);
                menuItems.Add(trex);
                menuItems.Add(wrap);


                Fryceritops fries = new Fryceritops();
                MeteorMacAndCheese mac = new MeteorMacAndCheese();
                MezzorellaSticks sticks = new MezzorellaSticks();
                Triceritots tots = new Triceritots();

                menuItems.Add(fries);
                menuItems.Add(mac);
                menuItems.Add(sticks);
                menuItems.Add(tots);

                CretaceousCombo bratCombo = new CretaceousCombo(brat);
                CretaceousCombo dinoNugs = new CretaceousCombo(nuggets);
                CretaceousCombo pbjCombo = new CretaceousCombo(pbj);
                CretaceousCombo wingsCombo = new CretaceousCombo(wings);
                CretaceousCombo steakBurgerCombo = new CretaceousCombo(steak);
                CretaceousCombo trexBurgerCombo = new CretaceousCombo(trex);
                CretaceousCombo wrapCombo = new CretaceousCombo(wrap);

                menuItems.Add(bratCombo);
                menuItems.Add(dinoNugs);
                menuItems.Add(pbjCombo);
                menuItems.Add(wingsCombo);
                menuItems.Add(steakBurgerCombo);
                menuItems.Add(trexBurgerCombo);
                menuItems.Add(wrapCombo);

                return menuItems;
            }
        } 

        /// <summary>
        /// List of all the available entrees
        /// </summary>
        public List<Entree> AvailableEntrees
        {
            get
            {
                List<Entree> entrees = new List<Entree>();

                Brontowurst brat = new Brontowurst();
                DinoNuggets nuggets = new DinoNuggets();
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                PterodactylWings wings = new PterodactylWings();
                SteakosaurusBurger steak = new SteakosaurusBurger();
                TRexKingBurger trex = new TRexKingBurger();
                VelociWrap wrap = new VelociWrap();

                entrees.Add(brat);
                entrees.Add(nuggets);
                entrees.Add(pbj);
                entrees.Add(wings);
                entrees.Add(steak);
                entrees.Add(trex);
                entrees.Add(wrap);

                return entrees;
            }
        }

        /// <summary>
        /// List of all the available sides
        /// </summary>
        public List<Side> AvailableSides
        {
            get
            {
                List<Side> sides = new List<Side>();

                Fryceritops fries = new Fryceritops();
                MeteorMacAndCheese mac = new MeteorMacAndCheese();
                MezzorellaSticks sticks = new MezzorellaSticks();
                Triceritots tots = new Triceritots();

                sides.Add(fries);
                sides.Add(mac);
                sides.Add(sticks);
                sides.Add(tots);

                return sides;
            }
        }

        /// <summary>
        /// List of all the available drinks
        /// </summary>
        public List<Drink> AvailableDrinks
        {
            get
            {
                List<Drink> drinks = new List<Drink>();

                JurassicJava java = new JurassicJava();
                Sodasaurus soda = new Sodasaurus();
                Tyrannotea tea = new Tyrannotea();
                Water water = new Water();

                drinks.Add(java);
                drinks.Add(soda);
                drinks.Add(tea);
                drinks.Add(water);

                return drinks;
            }
        }

        /// <summary>
        /// List of all the available combos
        /// </summary>
        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                List<CretaceousCombo> combos = new List<CretaceousCombo>();

                Brontowurst brat = new Brontowurst();
                DinoNuggets nuggets = new DinoNuggets();
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                PterodactylWings wings = new PterodactylWings();
                SteakosaurusBurger steak = new SteakosaurusBurger();
                TRexKingBurger trex = new TRexKingBurger();
                VelociWrap wrap = new VelociWrap();

                CretaceousCombo bratCombo = new CretaceousCombo(brat);
                CretaceousCombo dinoNugs = new CretaceousCombo(nuggets);
                CretaceousCombo pbjCombo = new CretaceousCombo(pbj);
                CretaceousCombo wingsCombo = new CretaceousCombo(wings);
                CretaceousCombo steakBurgerCombo = new CretaceousCombo(steak);
                CretaceousCombo trexBurgerCombo = new CretaceousCombo(trex);
                CretaceousCombo wrapCombo = new CretaceousCombo(wrap);

                combos.Add(bratCombo);
                combos.Add(dinoNugs);
                combos.Add(pbjCombo);
                combos.Add(wingsCombo);
                combos.Add(steakBurgerCombo);
                combos.Add(trexBurgerCombo);
                combos.Add(wrapCombo);

                return combos;
            }
        }

        /// <summary>
        /// Overrides the ToString method and lists all menu items on their own line
        /// </summary>
        /// <returns>List of all the menu items on a separate line</returns>
        public override string ToString()
        {
            return "Brontowurst\n Dino-Nuggets\n Prehistoric PB&J\n Pterodactyl Wings\n SteakosaurusBurger\n T-Rex King Burger\n Veloci-Wrap\n  Fryceritops\n Meteor Mac and Cheese\n Mezzorella Sticks\n Triceritots\n Decaf Jurassic Java\n Jurassic Java\n Cherry Sodasaurus\n Chocolate Sodasaurus\n Cola Sodasaurus\n Vanilla Sodasaurus\n Lime Sodasaurus\n RootBeer Sodasaurus\n Orange Sodasaurus\n Sweet Tyrannotea\n Tyrannotea\n Water";
        }

        public List<Entree> SearchEntrees(List<Entree> entrees, string keyword)
        {
            List<Entree> results = new List<Entree>();

            foreach(Entree entree in entrees )
            {
                if (entree.Description.Contains(keyword))
                {
                    results.Add(entree);
                }
            }
            return results;
        }

        public List<Drink> SearchDrinks(List<Drink> drinks, string keyword)
        {
            List<Drink> results = new List<Drink>();

            foreach (Drink drink in drinks)
            {
                if (drink.Description.Contains(keyword))
                {
                    results.Add(drink);
                }
            }
            return results;
        }

        public List<Side> SearchSides(List<Side> sides, string keyword)
        {
            List<Side> results = new List<Side>();

            foreach (Side side in sides)
            {
                if (side.Description.Contains(keyword))
                {
                    results.Add(side);
                }
            }
            return results;
        }

        public List<CretaceousCombo> SearchCombos(List<CretaceousCombo> combos, string keyword)
        {
            List<CretaceousCombo> results = new List<CretaceousCombo>();

            foreach (CretaceousCombo combo in combos)
            {
                if (combo.Description.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    results.Add(combo);
                }
            }
            return results;
        }

        public List<Entree> FilterByMenuCategoryEntree(List<string> category)
        {
            List<Entree> results = new List<Entree>();

            foreach(string item in category)
            {
                if (item == "Entree")
                {
                    results = AvailableEntrees;
                }
            }
            
            return results;
        }

        public List<Drink> FilterByMenuCategoryDrink(List<string> category)
        {
            List<Drink> results = new List<Drink>();

            foreach (string item in category)
            {
                if (item == "Drink")
                {
                    results = AvailableDrinks;
                }
            }

            return results;
        }

        public List<Side> FilterByMenuCategorySide(List<string> category)
        {
            List<Side> results = new List<Side>();

            foreach (string item in category)
            {
                if (item == "Side")
                {
                    results = AvailableSides;
                }
            }

            return results;
        }

        public List<CretaceousCombo> FilterByMenuCategoryCombos(List<string> category)
        {
            List<CretaceousCombo> results = new List<CretaceousCombo>();

            foreach (string item in category)
            {
                if (item == "Combo")
                {
                    results = AvailableCombos;
                }
            }

            return results;
        }

        public List<Entree> FilterByMinPriceEntree(List<Entree> entrees, double minPrice)
        {
            List<Entree> results = new List<Entree>();

            foreach(Entree entree in entrees)
            {
                if (minPrice <= entree.Price)
                {
                    results.Add(entree);
                }
                
            }
            return results;
        }

        public List<Side> FilterByMinPriceSide(List<Side> sides, double minPrice)
        {
            List<Side> results = new List<Side>();

            foreach (Side side in sides)
            {
                if (minPrice <= side.Price)
                {
                    results.Add(side);
                }

            }
            return results;
        }

        public List<Drink> FilterByMinPriceDrink(List<Drink> drinks, double minPrice)
        {
            List<Drink> results = new List<Drink>();

            foreach (Drink drink in drinks)
            {
                if (minPrice <= drink.Price)
                {
                    results.Add(drink);
                }

            }
            return results;
        }

        public List<CretaceousCombo> FilterByMinPriceCombo(List<CretaceousCombo> combos, double minPrice)
        {
            List<CretaceousCombo> results = new List<CretaceousCombo>();

            foreach (CretaceousCombo combo in combos)
            {
                if (minPrice <= combo.Price)
                {
                    results.Add(combo);
                }

            }
            return results;
        }

        public List<Entree> FilterByMaxPriceEntree(List<Entree> entrees, double minPrice)
        {
            List<Entree> results = new List<Entree>();

            foreach (Entree entree in entrees)
            {
                if (minPrice >= entree.Price)
                {
                    results.Add(entree);
                }

            }
            return results;
        }

        public List<Side> FilterByMaxPriceSide(List<Side> sides, double minPrice)
        {
            List<Side> results = new List<Side>();

            foreach (Side side in sides)
            {
                if (minPrice >= side.Price)
                {
                    results.Add(side);
                }

            }
            return results;
        }

        public List<Drink> FilterByMaxPriceDrink(List<Drink> drinks, double minPrice)
        {
            List<Drink> results = new List<Drink>();

            foreach (Drink drink in drinks)
            {
                if (minPrice >= drink.Price)
                {
                    results.Add(drink);
                }

            }
            return results;
        }

        public List<CretaceousCombo> FilterByMaxPriceCombo(List<CretaceousCombo> combos, double minPrice)
        {
            List<CretaceousCombo> results = new List<CretaceousCombo>();

            foreach (CretaceousCombo combo in combos)
            {
                if (minPrice >= combo.Price)
                {
                    results.Add(combo);
                }

            }
            return results;
        }

        
    }
}
