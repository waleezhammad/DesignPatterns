using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq;

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
    }
}
