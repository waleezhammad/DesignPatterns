using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.AfterBridgePattern
{
    public abstract class ManuScript
    {
        protected IFormatter _formatter;

        public ManuScript(IFormatter format)
        {
            _formatter = format;
        }
        public abstract void Print();
    }
}
