using BridgePattern.BeforeBridgePattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatern.Tests
{
    [TestClass]
    public class BridgePatern_Tests
    {
        [TestMethod]
        public void BeforeBidgePatternTests()
        {
            List<IManuScript> documents = new List<IManuScript>();

            documents.Add(
            new ReverseBook()
            {
                Author = "Waleed",
                Descriptiom = "Implement Bridge Design Pattern",
                Title = "Bridge Pattern"
            });

            //book.Print();

            documents.Add(new Paper()
            {
                Title = "Bridge Pattern Paper",
                Author ="Waleed Hammad"
            });
            //paper.Print();

            foreach (var doc in documents)
                doc.Print();
        }

        // what if I need to print Reverse
    }
}
