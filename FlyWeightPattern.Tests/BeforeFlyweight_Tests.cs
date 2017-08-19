using FlyWeightPattern.Before;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern.Tests
{
    [TestClass]
    public class BeforeFlyweight_Tests
    {
        [TestMethod]
        public void BeforeFlyWeighTest()
        {
            for (int i = 0; i < 20; i++)
            {
                Book book = new Book();
                book.Print();
            }

            for (int i = 0; i < 20; i++)
            {
                Paper paper = new Paper();
                paper.Print();
            }
        }
    }
}
