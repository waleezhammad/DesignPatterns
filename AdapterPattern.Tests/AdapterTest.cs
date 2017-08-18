using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq;
using AdapterPattern.Tests.Adaptee;
using System.Collections.Generic;

namespace AdapterPattern.Tests
{
    [TestClass]
    public class AdapterTest
    {
        [TestMethod]
        public void TestRender()
        {
            StubAdapter stb = new StubAdapter();

            DataRender dataRender = new DataRender(stb);

            var stringWriter = new StringWriter();

            dataRender.Render(stringWriter);

            var result = stringWriter.ToString();
            Console.WriteLine(result);

            int lineCount = result.Count(c => c == '\n');
            Assert.AreEqual(3, lineCount);

        }

        [TestMethod]
        public void PatternRenderTest()
        {
            PattenRendrer rendrer = new PattenRendrer();

            var result = rendrer.ListPatterns(new List<PatternModel>() {
                new PatternModel(){ Id = 1,Name ="Adapter",Description="Adapter Pattern to convert interface of class to an interface that another class expect"},

            });

            Console.WriteLine(result);

            int lineCount = result.Count(c => c == '\n');
            Assert.AreEqual(3, lineCount);
        }
    }
    
}
