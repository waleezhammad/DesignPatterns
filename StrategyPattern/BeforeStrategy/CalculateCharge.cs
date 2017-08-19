using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.BeforeStrategy
{
    public class CalculateShippingCharge
    {
        public double Calculate(Order order)
        {
            switch (order.Method)
            {
                case OrderMethod.UPS:
                    return GetUPSCharge();
                case OrderMethod.Fedex:
                    return GetFedxCharge();
                case OrderMethod.USPS:
                    return GetFedxCharge();
                default:
                    throw new NotImplementedException("This method not implemented");
            }
        }

        public double GetUPSCharge()
        {
            return 5.000d;
        }
        public double GetFedxCharge()
        {
            return 4.000d;
        }
        public double GetUSPSCharge()
        {
            return 3.000d;
        }
    }
}
