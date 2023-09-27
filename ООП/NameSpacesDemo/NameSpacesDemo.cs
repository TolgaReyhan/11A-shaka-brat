using Animals;
using NameSpacesDemo.Animals;
using System.Data.Common;

namespace NameSpacesDemo
{
    internal class NameSpacesDemo
    {
        static void Main(string[] args)
        {
            var dog1 = new Animals.Dog();
            var cat1 = new Cat();
            Mackerel fish1 = new Mackerel();
            Console.WriteLine("Hello, World!");

            #region StaticDemonstration
            var p1 = new Person() { Name = "Berk" };
            var p2 = new Person() { Name = "Valentin" };
            var p3 = new Person() { Name = "Denis" };
            var p4 = new Person() { Name = "Hristian" };
            Person.TownName = "Shumen";

            Console.WriteLine(Person.TownName);
            p1.SayHello();
            p2.SayHello();
            p3.SayHello();
            p4.SayHello();

            Person.TownName = "Burgas";

            Console.WriteLine(Person.TownName);
            p1.SayHello();
            p2.SayHello();
            p3.SayHello();
            p4.SayHello();
            #endregion
        }
        public class Person
        {
            public string Name { get; set; }
            public static string TownName { get; set; }
            
            public void SayHello()
            {
                Console.WriteLine($"I am {Name} from {TownName}");
            }
        }
    }
}