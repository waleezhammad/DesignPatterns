using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern.Before
{
    public class Book
    {
        private string Title = "FlyWeightPatternBook";

        public void Print()
        {
            Console.WriteLine("Title:{0}", Title);
        }
    }
}
