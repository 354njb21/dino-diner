using DinoDiner.Menu;
using System.Collections.Generic;
using Xunit;

namespace MenuTest.Entrees
{
    public class SteakosaurusBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal(5.15, sb.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal<uint>(621, sb.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            List<string> ingredients = sb.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Steakburger Pattie", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Contains<string>("Lettuce", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Contains<string>("Tomato", ingredients);
            Assert.Equal<int>(8, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", trex.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", trex.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", trex.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", trex.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", trex.Ingredients);
        }

        [Fact]
        public void HoldTomatoShouldRemoveTomato()
        {
            
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.DoesNotContain<string>("Tomato", trex.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.DoesNotContain<string>("Onion", trex.Ingredients);
        }


        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            Assert.Equal("Steakosaurus Burger", steak.Description);
        }

        [Fact]
        public void SpecialShouldHoldOnions()
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            steak.HoldOnion();
            Assert.Collection<string>(steak.Special,
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                }
                );
        }

        [Fact]
        public void SpecialShouldHoldPickle()
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            steak.HoldPickle();
            Assert.Collection<string>(steak.Special,
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                }
                );
        }

        [Fact]
        public void SpecialShouldHoldMustard()
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            steak.HoldMustard();
            Assert.Collection<string>(steak.Special,
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                }
                );
        }

        [Fact]
        public void SpecialShouldHoldKetchup()
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            steak.HoldKetchup();
            Assert.Collection<string>(steak.Special,
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                }
                );
        }

        [Fact]
        public void SpecialShouldHoldBun()
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            steak.HoldBun();
            Assert.Collection<string>(steak.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                }
                );
        }

        [Fact]
        public void SpecialShouldHoldTomato()
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            steak.HoldTomato();
            Assert.Collection<string>(steak.Special,
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                }
                );
        }

        [Fact]
        public void SpecialShouldHoldLettuce()
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            steak.HoldLettuce();
            Assert.Collection<string>(steak.Special,
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                }
                );
        }

        [Fact]
        public void SpecialShouldHoldLettuceAndTomatoAndKetchupAndPickle()
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            steak.HoldLettuce();
            steak.HoldTomato();
            steak.HoldKetchup();
            steak.HoldPickle();
            Assert.Collection<string>(steak.Special,
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                },
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                },
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                },
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                }
                );
        }

        [Fact]
        public void HoldOnionShouldNotifyOfSpecialPropertyChange()
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            Assert.PropertyChanged(steak, "Special", () =>
            {
                steak.HoldOnion();
            });
        }

        [Fact]
        public void HoldLettuceShouldNotifyOfSpecialPropertyChange()
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            Assert.PropertyChanged(steak, "Special", () =>
            {
                steak.HoldLettuce();
            });
        }

        [Fact]
        public void HoldTomatoShouldNotifyOfSpecialPropertyChange()
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            Assert.PropertyChanged(steak, "Special", () =>
            {
                steak.HoldTomato();
            });
        }

        [Fact]
        public void HoldKetchupShouldNotifyOfSpecialPropertyChange()
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            Assert.PropertyChanged(steak, "Special", () =>
            {
                steak.HoldKetchup();
            });
        }

        [Fact]
        public void HoldPickleShouldNotifyOfSpecialPropertyChange()
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            Assert.PropertyChanged(steak, "Special", () =>
            {
                steak.HoldPickle();
            });
        }

        [Fact]
        public void HoldMustardShouldNotifyOfSpecialPropertyChange()
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            Assert.PropertyChanged(steak, "Special", () =>
            {
                steak.HoldMustard();
            });
        }

        [Fact]
        public void HoldBunShouldNotifyOfSpecialPropertyChange()
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            Assert.PropertyChanged(steak, "Special", () =>
            {
                steak.HoldBun();
            });
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            Assert.Empty(steak.Special);
        }
    }

}
