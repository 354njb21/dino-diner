﻿using DinoDiner.Menu;
using System.Collections.Generic;
using Xunit;

namespace MenuTest.Entrees
{
    public class VelociWrapUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal(6.86, vw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal<uint>(356, vw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            VelociWrap vw = new VelociWrap();
            List<string> ingredients = vw.Ingredients;
            Assert.Contains<string>("Flour Tortilla", ingredients);
            Assert.Contains<string>("Chicken Breast", ingredients);
            Assert.Contains<string>("Romaine Lettuce", ingredients);
            Assert.Contains<string>("Ceasar Dressing", ingredients);
            Assert.Contains<string>("Parmesan Cheese", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldDressingShouldRemoveDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.DoesNotContain<string>("Dressing", vw.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", vw.Ingredients);
        }

        [Fact]
        public void HoldCheeseShouldRemoveCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.DoesNotContain<string>("Parmesan Cheese", vw.Ingredients);
        }

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            VelociWrap wrap = new VelociWrap();
            Assert.Equal("Veloci-Wrap", wrap.Description);
        }

        [Fact]
        public void SpecialShouldHoldLettuce()
        {
            VelociWrap wrap = new VelociWrap();
            wrap.HoldLettuce();
            Assert.Collection<string>(wrap.Special,
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                }
                );
        }

        [Fact]
        public void SpecialShouldHoldDressing()
        {
            VelociWrap wrap = new VelociWrap();
            wrap.HoldDressing();
            Assert.Collection<string>(wrap.Special,
                item =>
                {
                    Assert.Equal("Hold Dressing", item);
                }
                );
        }

        [Fact]
        public void SpecialShouldHoldCheese()
        {
            VelociWrap wrap = new VelociWrap();
            wrap.HoldCheese();
            Assert.Collection<string>(wrap.Special,
                item =>
                {
                    Assert.Equal("Hold Cheese", item);
                }
                );
        }

        [Fact]
        public void SpecialShouldHoldCheeseAndLettuceAndDressing()
        {
            VelociWrap wrap = new VelociWrap();
            wrap.HoldCheese();
            wrap.HoldLettuce();
            wrap.HoldDressing();
            Assert.Collection<string>(wrap.Special,
                item =>
                {
                    Assert.Equal("Hold Cheese", item);
                },
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                },
                item =>
                {
                    Assert.Equal("Hold Dressing", item);
                }
                );
        }

        [Fact]
        public void HoldCheeseShouldNotifyOfSpecialPropertyChange()
        {
            VelociWrap wrap = new VelociWrap();
            Assert.PropertyChanged(wrap, "Special", () =>
            {
                wrap.HoldCheese();
            });
        }

        [Fact]
        public void HoldLettuceShouldNotifyOfSpecialPropertyChange()
        {
            VelociWrap wrap = new VelociWrap();
            Assert.PropertyChanged(wrap, "Special", () =>
            {
                wrap.HoldLettuce();
            });
        }

        [Fact]
        public void HoldDressingShouldNotifyOfSpecialPropertyChange()
        {
            VelociWrap wrap = new VelociWrap();
            Assert.PropertyChanged(wrap, "Special", () =>
            {
                wrap.HoldDressing();
            });
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {
            VelociWrap wrap = new VelociWrap();
            Assert.Empty(wrap.Special);
        }
    }
}
