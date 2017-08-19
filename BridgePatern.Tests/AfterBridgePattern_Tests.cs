using BridgePattern.AfterBridgePattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatern.Tests
{
    [TestClass]
    public class AfterBridgePattern_Tests
    {
        [TestMethod]
        public void TestBridgePattern()
        {

            ReverseFormatter rf = new ReverseFormatter();

            StandardFormatter sf = new StandardFormatter();

            List<ManuScript> documents = new List<ManuScript>();

            documents.Add(new Book(rf)
            {
                Author = "Waleed",
                Descriptiom = "Implement Bridge Design Pattern",
                Title = "Bridge Pattern"
            });

            documents.Add(new Paper(sf)
            {
                Title = "Bridge Pattern Paper",
                Author = "Waleed Hammad"
            });

            foreach (var doc in documents)
            {
                doc.Print();
            }
        }
    }
}
