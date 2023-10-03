namespace Enumerations
{
    internal class Enumerations
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            var myCar = new Car()
            {
                YearOfMake = 1998, Milesage = 80085, Manufacturer = CarManufacturer.Mercedes, Model = "E320",
                DayOfMake = DaysOfWeek.Monday,
            };
            var myCar2 = new Car()
            {
                YearOfMake = 2003,
                Milesage = 60084,
                Manufacturer = Enum.Parse<CarManufacturer>("Toyota"),
                DayOfMake = DaysOfWeek.Wednesday,
                Model = "Celica"
            };
            cars.Add(myCar);
            cars.Add(myCar2);
            cars.Add(new Car()
            {
                YearOfMake = 2007,
                Milesage = 50084,
                Manufacturer = (CarManufacturer)13,
                DayOfMake = DaysOfWeek.Friday,
                Model = "Corrola"
            });
            cars.Add(new Car()
            {
                YearOfMake = 2023,
                Milesage = 0,
                Manufacturer = CarManufacturer.Ford,
                DayOfMake = DaysOfWeek.Saturday,
                Model = "Mac-E"
            });
            foreach (Car car in cars)
            {
                if (car.Manufacturer == CarManufacturer.Toyota)
                {
                    Console.WriteLine("Imame toyota!!!");
                }
                switch (car.Manufacturer)
                {
                    case CarManufacturer.Ford:
                        {
                            Console.WriteLine("Imame Ford!");
                            break;
                        }   
                    case CarManufacturer.Opel:
                        {
                            Console.WriteLine("Imame Opel!");
                            break;
                        }
                    case CarManufacturer.Mercedes:
                        {
                            Console.WriteLine("Imame Mercedes!");
                            break;
                        }
                    case CarManufacturer.Toyota:
                        {
                            Console.WriteLine("Imame Toyota!");
                            break;
                        }
                    case CarManufacturer.BMW:
                        {
                            Console.WriteLine("Imame BMW!");
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
    public class Car
    {
        private int yearOfMake;
        public int Milesage { get; set; }
        public string Model { get; set; }
        public DaysOfWeek DayOfMake { get; set; }
        public int YearOfMake
        {
            get { return yearOfMake; }
            set { yearOfMake = value; }
        }
        public CarManufacturer Manufacturer { get; set; }
    }
    public enum CarManufacturer
    {
        Ford=10,
        Opel=11,
        Mercedes=12,
        Toyota=13,
        BMW=9
    }
    public enum DaysOfWeek
    {
        Monday=1,
        Tuesday=2,
        Wednesday=3,
        Thursday=4,
        Friday=5,
        Saturday=6,
        Sunday=7
    }
}