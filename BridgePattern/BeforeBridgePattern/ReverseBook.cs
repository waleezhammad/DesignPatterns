using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.BeforeBridgePattern
{
    public class ReverseBook : Book
    {
        public override void Print()
        {
            Console.WriteLine("Title:{0}",new string(Title.Reverse().ToArray()));
            Console.WriteLine("Author:{0}", new string(Author.Reverse().ToArray()));
            Console.WriteLine("Description:{0}", new string(Descriptiom.Reverse().ToArray()));
        }
    }
}
