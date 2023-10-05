namespace StaticConstructorDestructorStackAndHeap
{
    internal class StaticConstructorDestructorStackAndHeap
    {
        static void Main(string[] args)
        {
            DemoZaStatichniNeshta();
            //................
            Console.ReadLine();
        }

        private static void DemoZaStatichniNeshta()
        {
            Console.WriteLine(Dog.ZooName);
            Dog.ZooName = "Marica";
            var dogs = new List<Dog>()
            {
                new Dog("Snoop Dog"),
                new Dog("Culio"),
                new Dog("G-Dog"),
                new Dog("Dimoff"),
                new Dog("Gocata"),
                new Dog("Kangala"),
            };
            Console.WriteLine(VetClinic.Name);
            for (int i = 0; i < dogs.Count; i++)
            {
                int a = 5;
                dogs[i].PrintData();
            }
            var dogTest = new Dog();
            if (dogTest.Id < 10)
            {
                var d1 = new Dog("Kucheto koeto ne jivee izvun if-a");
            }
            var d2 = new Dog("Kucheto");
            Console.ReadLine();
        }
    }
}