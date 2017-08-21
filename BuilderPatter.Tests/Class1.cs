using BuilderPattern.AfterBuilder;
using BuilderPattern.BeforeBuilder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatter.Tests
{
    [TestClass]
    public class BeforeBuilderPatter
    {
        [TestMethod]
        public void TestBeforeBuilderPattern()
        {
             
            Sandwitch san = new Sandwitch(BreadType.White, Meat.Beaf, new List<string>() { "Tomato", "Onions" },new List<Tasting>() { Tasting.Maioneez}, true);
            san.MakeSandwitch();
        }
    }

    [TestClass]
    public class AfterBuilderPattern
    {
        [TestMethod]
        public void MySandawitchTest()
        {
            new MySandwitch().CreateSandwitch().MakeSandwitch();
        }
        [TestMethod]
        public void HalpinoSandawitchTest()
        {
            new HalopinoSandwitch().CreateSandwitch().MakeSandwitch();
        }
    }

   
}
