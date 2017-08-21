using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.AfterBuilder
{
    public class HalopinoSandwitch : SandwitchBuilder
    {
       
       

        public override void CreateVegitables()
        {
            _sandwich.Vegitables = new List<string>() { "Tomato", "Onions" };
        }

        public override void CreateMeat()
        {
            _sandwich.Meat = BeforeBuilder.Meat.Beaf;
        }

        public override void CreateBread()
        {
            _sandwich.BreadType = BeforeBuilder.BreadType.White;
        }
        
    }
}
