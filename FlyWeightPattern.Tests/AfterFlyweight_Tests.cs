using FlyWeightPattern.After;
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
    public class AfterFlyweight_Tests
    {
        [TestMethod]
        public void AfterFlyWeighTest()
        {
            FlyWeightFactory factory = new FlyWeightFactory();

            for (int i = 0; i < 20; i++)
            {
                var book = factory.GetDocument(DocumentType.Book);
                book.Print();
            }

            for (int i = 0; i < 20; i++)
            {
                var paper = factory.GetDocument(DocumentType.Paper);
                paper.Print();
            }
        }
    }
}
