using BuilderPattern.BeforeBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.AfterBuilder
{
    public class Sandawitch
    {
        private BreadType _breadType;
        private Meat _meat;
        private List<string> _vegitables;
        private bool _isheating;

        public BreadType BreadType { get => _breadType; set => _breadType = value; }
        public Meat Meat { get => _meat; set => _meat = value; }
        public List<string> Vegitables { get => _vegitables; set => _vegitables = value; }
        public bool Isheating { get => _isheating; set => _isheating = value; }

        public void MakeSandwitch()
        {
            if (Isheating)
                Console.WriteLine("heating bread");
            Console.WriteLine("Adding Meat");
            Console.WriteLine("Adding Taste");
            Console.WriteLine("Adding Vegitables");
        }
    }
}
