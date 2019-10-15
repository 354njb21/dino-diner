/*Menu
 * Nathan Brown
 * Milestone 4
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class controls public properties related to the Dino Diner menu and overrides the ToString method to list all ingredients
    /// </summary>
    public class Menu
    {

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
    }
}
