using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructorDestructorStackAndHeap
{
    internal class Dog
    {
        private static int idCounter = 1;
        public int Id { get; set; }
        public Dog()
        {
            Id = idCounter;
            idCounter++;
        }
        public Dog(string name):this()
        {
            Name = name;
        }
        static Dog()
        {
            ZooName = "Genado";
        }
        ~Dog()
        {
            Console.WriteLine($"Goodbye from {Name}. Kucheto go ubi Garbage kolektora");
        }
        public static string ZooName { get; set; }
        public string Name { get; set; }
        public void PrintData()
        {
            Console.WriteLine($"I am a doggy. I am {Name}. My Id is {Id}");
            Console.WriteLine("Vnimanie: Pusna se statichen konstruktor");
        }
    }
}
