using Inheritance.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.NoInheritance.Inheritance
{
    public class Dog : Animal
    {
        public Dog(string name, int age, double weight): base(name,age,weight) 
        {
            
        }
        public Dog(string name, int age, DogBreed breed, double weight) : this(name, age, weight)
        {
            Breed = breed;
        }
        public DogBreed Breed { get; set; }
        public string Owner { get; set; }
        public void Bark()
        {
            Console.WriteLine("Woof Woof");
        }
    }
    public class Puppy : Dog
    {
        public Puppy(string name, int age, DogBreed breed, double weight) : base(name, age, breed, weight)
        {

        }
    }
}
