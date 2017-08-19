using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.AfterStrategy
{
    public interface IChargeMethod
    {
        double Calculate(Order order);
    }
}
