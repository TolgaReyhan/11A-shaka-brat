using Inheritance.Enum;

namespace Inheritance.NoInheritance
{
    public class Dog
    {
        private double SpeedMetersPerSeconds = 3.0;
        public Dog(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }
        public Dog(string name, int age, DogBreed breed, double weight) : this(name, age, weight)
        {
            Breed = breed;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public DogBreed Breed { get; set; }
        public double Weight { get; set; }
        public int RunForTimeSeconds(double distanceMeters)
        {
            int timeRequired = (int)Math.Ceiling(distanceMeters / SpeedMetersPerSeconds);
            return timeRequired;
        }
        public void Bark()
        {
            Console.WriteLine("Woof Woof");
        }
    }
}