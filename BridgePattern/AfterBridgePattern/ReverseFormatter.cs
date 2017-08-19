﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.AfterBridgePattern
{
    public class ReverseFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return string.Format("{0}:{1}",key,new string(value.Reverse().ToArray()));
        }
    }
}
