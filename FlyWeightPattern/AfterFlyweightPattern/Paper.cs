using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern.After
{
    public class Paper: IDocument
    {
        private string Title = "FlyWeightPatternPaper";

        public void Print()
        {
            Console.WriteLine("Title:{0}", Title);
        }
    }
}
