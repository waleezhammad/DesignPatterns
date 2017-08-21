using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.BeforeBuilder
{
    /// <summary>
    /// this approach is taking many paramters in constructor and if we can make properties to set the client may not set some properties linke not add bread and it is required to make sandawitch
    /// so we will add builder pattern
    /// </summary>

    public class Sandwitch
    {
        private BreadType _breadType;
        private Meat _meat;
        private List<string> _vegitables;
        private bool _isheating;

        public Sandwitch(BreadType breadType,Meat meat,List<string> vegitables,List<Tasting> tastings,bool isHeating)
        {
            this._breadType = breadType;
            this._meat = meat;
            this._vegitables = vegitables;
            this._isheating = isHeating;
        }
        public void MakeSandwitch()
        {
            if (_isheating)
                Console.WriteLine("heating bread");
            Console.WriteLine("Adding Meat");
            Console.WriteLine("Adding Taste");
            Console.WriteLine("Adding Vegitables");
        }

    }

    public enum BreadType
    {
        White,
        NotWhit
    }

    public enum Meat
    {
        Chicken,
        Beaf,
        Swiss
    }
    public enum Tasting
    {
        Masturd,
        Maioneez
    }
}
