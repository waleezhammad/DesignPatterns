using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.AfterBuilder
{
    public class MySandwitch
    {
        private Sandawitch _sandwich;
        public Sandawitch CreateSandwitch()
        {
            _sandwich = new Sandawitch();
            CreateBread();
            CreateMeat();
            CreateVegitables();
            return _sandwich;
        }

        private void CreateVegitables()
        {
            _sandwich.Vegitables = new List<string>() { "Tomato", "Onions" };
        }

        private void CreateMeat()
        {
            _sandwich.Meat = BeforeBuilder.Meat.Beaf;
        }

        private void CreateBread()
        {
            _sandwich.BreadType = BeforeBuilder.BreadType.White; 
        }
    }
}
