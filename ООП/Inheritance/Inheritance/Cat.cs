using Inheritance.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.NoInheritance.Inheritance
{
    public class Cat : Animal
    {
        public Cat(string name, int age, double weight) : base(name, age, weight)
        {
           
        }
        public Cat(string name, int age, double weight, int lives, CatBreed breed) : this(name, age, weight)
        {
            Lives = lives;
            Breed = breed;
        }
        public CatBreed Breed { get; set; }
        public int Lives { get; set; }
        public void Meow()
        {
            Console.WriteLine("Meow Meow n***a");
        }
    }
}
