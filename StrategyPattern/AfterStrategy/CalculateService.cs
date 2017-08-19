using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.AfterStrategy
{
    public class CalculateService
    {
        private IChargeMethod _charge;

        public CalculateService(IChargeMethod charge)
        {
            _charge = charge;
        }

        public double Clculate(Order order)
        {
            return _charge.Calculate(order);
        }
    }
}
