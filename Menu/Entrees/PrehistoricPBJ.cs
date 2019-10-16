/*PrehistoricPBJ
 * Nathan Brown
 * Milestone 4
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that contains the menu item PrehistoricPBJ and all of its details
    /// </summary>
    public class PrehistoricPBJ: Entree, INotifyPropertyChanged
    {
        private bool peanutButter = true;
        private bool jelly = true;

        /// <summary>
        /// The PropertyChanged event handler; notifies of changes to the Price, Description, and Special properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        //Helper function for noifying of property changes
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        /// <summary>
        /// Gets and sets the description
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Gets any special preparation instructions
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!peanutButter) special.Add("Hold Peanut Butter");
                if (!jelly) special.Add("Hold Jelly");
                return special.ToArray(); 
            }
        }
       

        /// <summary>
        /// List containing all of the ingredients in the PBJ
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Sets the price and calories for the PBJ
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Sets the value of peanut butter to false
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Sets the value of jelly to false
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Overrides the ToString method based on the specific menu item
        /// </summary>
        /// <returns>The name of the menu item</returns>
        public override string ToString()
        {
            return $"Prehistoric PB&J";
        }
    }
}
