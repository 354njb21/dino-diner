/*JurassicJavaTest.cs
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
    /// Tests for the JurassicJava
    /// </summary>
    public class JurassicJavaTest
    {
        /// <summary>
        /// Checking for correct default price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<double>(.59, java.Price);
        }

        /// <summary>
        /// Checking for correct default calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<double>(2, java.Calories);
        }

        /// <summary>
        /// Checking for the default size of the drink
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal(Size.Small, java.Size);
        }

        /// <summary>
        /// Checking for the default value of Ice
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.Ice);
        }

        /// <summary>
        /// Checking for the default value of RoomForCream
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.RoomForCream);
        }

        /// <summary>
        /// Checking the default list of ingredients
        /// </summary>
        [Fact]
        public void ShouldListDefaultIngredients()
        {
            JurassicJava java = new JurassicJava();
            List<string> ingredients = java.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Coffee", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }


        /// <summary>
        /// Checking if the small size price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Small;
            Assert.Equal<double>(.59, java.Price);
        }

        /// <summary>
        /// Checking if the medium size price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(.99, java.Price);
        }

        /// <summary>
        /// Checking if the large size price is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(1.49, java.Price);
        }

        /// <summary>
        /// Checking if the small size calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Small;
            Assert.Equal<double>(2, java.Calories);
        }

        /// <summary>
        /// Checking if the medium size calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(4, java.Calories);
        }

        /// <summary>
        /// Checking if the large size calories are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(8, java.Calories);
        }

        /// <summary>
        /// Checks to see if AddIce sets Ice to true
        /// </summary>
        [Fact]
        public void AddIce()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }

        /// <summary>
        /// Checks if the LeaveSpaceForCreamer method sets RoomForCream to true
        /// </summary>
        [Fact]
        public void LeaveSpaceForCreamer()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCreamer();
            Assert.True(java.RoomForCream);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void DescriptionShouldBeCorrect(Size size)
        {
            JurassicJava java = new JurassicJava();
            java.Size = size;
            Assert.Equal($"{size} Jurassic Java", java.Description);
        }

        [Fact]
        public void SpecialShouldAddIce()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.Collection<string>(java.Special,
                item =>
                {
                    Assert.Equal("Add Ice", item);
                }
                );
        }

        [Fact]
        public void SpecialShouldLeaveRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCreamer();
            Assert.Collection<string>(java.Special,
                item =>
                {
                    Assert.Equal("Leave Room For Cream", item);
                }
                );
        }

        [Fact]
        public void SpecialShouldAddIceAndLeaveRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            java.LeaveRoomForCreamer();
            Assert.Collection<string>(java.Special,
                item =>
                {
                    Assert.Equal("Add Ice", item);
                },
                item =>
                {
                    Assert.Equal("Leave Room For Cream", item);
                }
                );
        }

        [Fact]
        public void AddIceShouldNotifyOfSpecialPropertyChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Special", () =>
            {
                java.AddIce();
            });
        }

        [Fact]
        public void LeaveRoomForCreamShouldNotifyOfSpecialPropertyChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Special", () =>
            {
                java.LeaveRoomForCreamer();
            });
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {
            JurassicJava java = new JurassicJava();
            Assert.Empty(java.Special);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifyOfPricePropertyChange(Size size)
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Price", () =>
            {
                java.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifyOfCaloriesPropertyChange(Size size)
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Calories", () =>
            {
                java.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifyOfDescriptionPropertyChange(Size size)
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Description", () =>
            {
                java.Size = size;
            });
        }

        [Fact]
        public void DecafCoffeeShouldNotifyOfDescriptionPropertyChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Description", () =>
            {
                java.DecafCoffee();
            });
        }
    }
}
