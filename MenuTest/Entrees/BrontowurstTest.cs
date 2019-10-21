using DinoDiner.Menu;
using System.Collections.Generic;
using Xunit;

namespace MenuTest.Entrees
{
    public class BrontowurstUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal(5.36, bw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal<uint>(498, bw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Brontowurst bw = new Brontowurst();
            List<string> ingredients = bw.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Brautwurst", ingredients);
            Assert.Contains<string>("Peppers", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", bw.Ingredients);
        }

        [Fact]
        public void HoldPeppersShouldRemovePeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.DoesNotContain<string>("Peppers", bw.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.DoesNotContain<string>("Onion", bw.Ingredients);
        }

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            Brontowurst bronto = new Brontowurst();
            Assert.Equal("Brontowurst", bronto.Description);
        }

        [Fact]
        public void SpecialShouldHoldPeppers()
        {
            Brontowurst bronto = new Brontowurst();
            bronto.HoldPeppers();
            Assert.Collection<string>(bronto.Special,
                item =>
                {
                    Assert.Equal("Hold Peppers", item);
                }
                );
        }

        [Fact]
        public void SpecialShouldHoldBun()
        {
            Brontowurst bronto = new Brontowurst();
            bronto.HoldBun();
            Assert.Collection<string>(bronto.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                }
                );
        }

        [Fact]
        public void SpecialShouldHoldOnion()
        {
            Brontowurst bronto = new Brontowurst();
            bronto.HoldOnion();
            Assert.Collection<string>(bronto.Special,
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                }
                );
        }

        [Fact]
        public void SpecialShouldHoldOnionAndBunAndPeppers()
        {
            Brontowurst bronto = new Brontowurst();
            bronto.HoldOnion();
            bronto.HoldBun();
            bronto.HoldPeppers();
            Assert.Collection<string>(bronto.Special,
                item =>
                {
                    Assert.Equal("Hold Peppers", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                },
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                }
                );
        }

        [Fact]
        public void HoldOnionShouldNotifyOfSpecialPropertyChange()
        {
            Brontowurst bronto = new Brontowurst();
            Assert.PropertyChanged(bronto, "Special", () =>
            {
                bronto.HoldOnion();
            });
        }

        [Fact]
        public void HoldPepperShouldNotifyOfSpecialPropertyChange()
        {
            Brontowurst bronto = new Brontowurst();
            Assert.PropertyChanged(bronto, "Special", () =>
            {
                bronto.HoldPeppers();
            });
        }

        [Fact]
        public void HoldBunShouldNotifyOfSpecialPropertyChange()
        {
            Brontowurst bronto = new Brontowurst();
            Assert.PropertyChanged(bronto, "Special", () =>
            {
                bronto.HoldBun();
            });
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {
            Brontowurst bronto = new Brontowurst();
            Assert.Empty(bronto.Special);
        }
    }

}
