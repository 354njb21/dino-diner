using DinoDiner.Menu;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void SubTotalCostIsNeverNegative()
        {
            Order order = new Order();
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.Price = -30;
            order.Items.Add(pbj);
            Assert.Equal(0, order.SubtotalCost);
        }

        [Fact]
        public void MockItems()
        {

        }
    }
}
