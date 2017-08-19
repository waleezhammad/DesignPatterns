using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.AfterStrategy
{
    public class Fedex : IChargeMethod
    {
        public double Calculate(Order order)
        {
            return 4.000d;
        }
    }
}
