using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.BeforeBridgePattern
{
    public class Paper:IManuScript
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public void Print()
        {
            Console.WriteLine("Title:{0}", Title);
            Console.WriteLine("Author:{0}", Author);
        }
    }
}
