using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrategyPattern.BeforeStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratgeyPattern.Tests.BeforeStrategy
{
    [TestClass]
    public class CalculateShippingChargeTests
    {
        [TestMethod]
        public void Charge_Will_Be_5_When_UPS()
        {
            Order order = new Order()
            {
                Item = "Ay 7aga",
                Method = OrderMethod.UPS,
                Price = 555
            };

            CalculateShippingCharge cal = new CalculateShippingCharge();
            var charge = cal.Calculate(order);

            Assert.AreEqual(5.000d, charge);

        }
    }
}
