/*WaterTest.cs
 * Nathan Brown
 * Milestone 3
 */
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MenuTest.Drinks
{
    /// <summary>
    /// Tests for the Water
    /// </summary>
    public class WaterTest
    {
        /// <summary>
        /// Checking for correct default price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water water = new Water();
            Assert.Equal<double>(.10, water.Price);
        }

        /// <summary>
        /// Checking for correct default calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water water = new Water();
            Assert.Equal<double>(0, water.Calories);
        }

        /// <summary>
        /// Checking for the default value of Ice
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Water water = new Water();
            Assert.True(water.Ice);
        }

        /// <summary>
        /// Checking for the default size of the drink
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water water = new Water();
            Assert.Equal(Size.Small, water.Size);
        }

        /// <summary>
        /// Checking for the default value of Lemon
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Water water = new Water();
            Assert.False(water.Lemon);
        }

        /// <summary>
        /// Checking the default list of ingredients
        /// </summary>
        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Water water = new Water();
            List<string> ingredients = water.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Single(ingredients);
        }

        /// <summary>
        /// Checks to see if HoldIce sets Ice to false
        /// </summary>
        [Fact]
        public void HoldIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }

        /// <summary>
        /// Checking if the small size price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Water water = new Water();
            water.Size = Size.Small;
            Assert.Equal<double>(.10, water.Price);
        }

        /// <summary>
        /// Checking if the medium size price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<double>(.10, water.Price);
        }

        /// <summary>
        /// Checking if the large size price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<double>(.10, water.Price);
        }

        /// <summary>
        /// Checking if the small size calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Water water = new Water();
            water.Size = Size.Small;
            Assert.Equal<double>(0, water.Calories);
        }

        /// <summary>
        /// Checking if the medium size calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<double>(0, water.Calories);
        }

        /// <summary>
        /// Checking if the large size calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<double>(0, water.Calories);
        }

        /// <summary>
        /// Sets the lemon bool to true and adds lemon to the ingredient list
        /// </summary>
        [Fact]
        public void AddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.Lemon);
            Assert.Contains<string>("Lemon", water.Ingredients);
        }

    }
}
