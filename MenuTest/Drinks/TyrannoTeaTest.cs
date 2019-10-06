/*TyrannoteaTest.cs
 * Nathan Brown
 * Milestone 3
 */
using DinoDiner.Menu;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MenuTest
{
    /// <summary>
    /// Tests for the Tyrannotea
    /// </summary>
    public class TyrannoteaTest
    {
        /// <summary>
        /// Checking for correct default price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(.99, tea.Price);
        }

        /// <summary>
        /// Checking for correct default calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(8, tea.Calories);
        }

        /// <summary>
        /// Checking for the default value of Ice
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }

        /// <summary>
        /// Checking for the default size of the drink
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal(Size.Small, tea.Size);
        }

        /// <summary>
        /// Checking for the default value of Lemon
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Lemon);
        }

        /// <summary>
        /// Sweet should have a default value of false
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Sweet);
        }

        /// <summary>
        /// Sets the Ice bool to false and holds the ice
        /// </summary>
        [Fact]
        public void HoldIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }

        /// <summary>
        /// Lemon bool is true and Lemon is added to the ingredients
        /// </summary>
        [Fact]
        public void AddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
            Assert.Contains<string>("Lemon", tea.Ingredients);
        }

        /// <summary>
        /// Adds sweetener to the tea: Sweet is set to true and Cane sugar is added to the ingredients
        /// </summary>
        [Fact]
        public void SweetTea()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            Assert.Contains<string>("Cane Sugar", tea.Ingredients);
        }

        /// <summary>
        /// Checking the default list of ingredients
        /// </summary>
        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            List<string> ingredients = tea.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Tea", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }

        /// <summary>
        /// Checking if the small size price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            Assert.Equal<double>(.99, tea.Price);
        }

        /// <summary>
        /// Checking if the medium size price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
        }

        /// <summary>
        /// Checking if the large size price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
        }

        /// <summary>
        /// Checking if the small size calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            Assert.Equal<double>(8, tea.Calories);
        }

        /// <summary>
        /// Checking if the medium size calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(16, tea.Calories);
        }

        /// <summary>
        /// Checking if the large size calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(32, tea.Calories);
        }

        /// <summary>
        /// Checks to see if adding sweetener doubles the calories for a small sweet tea
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectSmallSweetTeaCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            tea.Sweet = true;
            Assert.Equal<double>(16, tea.Calories);
        }

        /// <summary>
        /// Checks to see if adding sweetener doubles the calories for a medium sweet tea
        /// </summary
        [Fact]
        public void ShouldHaveCorrectMediumSweetTeaCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Sweet = true;
            Assert.Equal<double>(32, tea.Calories);
        }

        /// <summary>
        /// Checks to see if adding sweetener doubles the calories for a large sweet tea
        /// </summary
        [Fact]
        public void ShouldHaveCorrectLargeSweetTeaCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.Sweet = true;
            Assert.Equal<double>(64, tea.Calories);
        }

        /// <summary>
        /// Sweet is set to true and then back to false. Checks to see if calories are back to original for a small non-sweet tea
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectSmallNonSweetTeaCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<double>(8, tea.Calories);
        }

        /// <summary>
        /// Sweet is set to true and then back to false. Checks to see if calories are back to original for a medium non-sweet tea
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectMediumNonSweetTeaCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<double>(16, tea.Calories);
        }

        /// <summary>
        /// Sweet is set to true and then back to false. Checks to see if calories are back to original for a large non-sweet tea
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectLargeNonSweetTeaCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<double>(32, tea.Calories);
        }
    }
}

    
