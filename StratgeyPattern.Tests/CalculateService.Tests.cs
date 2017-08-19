using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrategyPattern.AfterStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratgeyPattern.Tests
{
    [TestClass]
    public class CalculateService_Tests
    {
        [TestMethod]
        public void CalculateService_When_UPS()
        {
            Order order = new Order()
            {
                Item  = "Apples",
                NumberOfItem=5
            };
            UPS ups = new UPS();
            CalculateService cs = new CalculateService(ups);
            var result = cs.Clculate(order);

            Assert.AreEqual(5.000d, result);
        }
    }
}
