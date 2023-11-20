using Inheritance.Enum;

namespace Inheritance.NoInheritance
{
    public class Cat
    {
        private double SpeedMetersPerSeconds = 4.0;
        public Cat(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }
        public Cat(string name, int age, int lives, CatBreed breed, double weight) : this(name, age, weight)
        {
            Lives = lives;
            Breed = breed;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public CatBreed Breed { get; set; }
        public int Lives { get; set; }
        public double Weight { get; set; }
        public int RunForTimeSeconds(double distanceMeters)
        {
            int timeRequired = (int)Math.Ceiling(distanceMeters / SpeedMetersPerSeconds);
            return timeRequired;
        }
        public void Meow()
        {
            Console.WriteLine("Meow Meow n***a");
        }
    }
}