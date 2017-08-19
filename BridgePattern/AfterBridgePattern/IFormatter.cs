using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.AfterBridgePattern
{
    public interface IFormatter
    {
        string Format(string key, string value);
    }
}
