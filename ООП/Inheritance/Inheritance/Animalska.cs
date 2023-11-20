using Inheritance.Enum;
using Inheritance.NoInheritance.Inheritance.Inheritance.NoInheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.NoInheritance.Inheritance
{
    internal class Animalska
    {

    }
    public class Animal
    {
        protected double SpeedMetersPerSeconds = 2;

        public Animal(string name)
        {
            Name = name;
        }

        public Animal(string name, int age, double weight) : this(name)
        {
            Age = age;
            Weight = weight;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public int RunForTimeSeconds(double distanceMeters)
        {
            int timeRequired = (int)Math.Ceiling(distanceMeters / SpeedMetersPerSeconds);
            return timeRequired;
        }
    }
}
