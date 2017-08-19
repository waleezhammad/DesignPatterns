using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.AfterStrategy
{
    public class USPSCharge : IChargeMethod
    {
        public double Calculate(Order order)
        {
            return 3.000d;
        }
    }
}
