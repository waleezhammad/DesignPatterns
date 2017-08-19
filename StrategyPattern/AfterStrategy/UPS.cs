using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.AfterStrategy
{
    public class UPS : IChargeMethod
    {
        public double Calculate(Order order)
        {
            return 5.000d;
        }
    }
}
