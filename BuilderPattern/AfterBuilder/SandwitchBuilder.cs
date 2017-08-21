using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.AfterBuilder
{
    public abstract class SandwitchBuilder
    {
        protected Sandawitch _sandwich;
        public Sandawitch CreateSandwitch()
        {
            _sandwich = new Sandawitch();
            CreateBread();
            CreateMeat();
            CreateVegitables();
            return _sandwich;
        }
        public abstract void CreateVegitables();


        public abstract void CreateMeat();

        public abstract void CreateBread();
        
    }
}
