﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.AfterBridgePattern
{
    public class Paper:ManuScript
    {
        public Paper(IFormatter format) : base(format)
        {
        }

        public string Title { get; set; }
        public string Author { get; set; }

        public override void Print()
        {
            Console.WriteLine(_formatter.Format("Author", Author));
            Console.WriteLine(_formatter.Format("Title", Title));
            
        }
    }
}
