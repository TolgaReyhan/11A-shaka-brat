namespace Zadacha_11._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Furniture> mebeli = new List<Furniture>();
            FurnitureStore furnitureStore = new FurnitureStore();
            mebeli.Add(new Chair("ofisen stol", 43.23m, Material.Steel, "IKEA", 50, true, true, true, 120));
            mebeli.Add(new Bed("mekoleko", 133.43m, Material.Wood,"AIKO", 125, 200, BedSpecs.Nails));
            if (mebeli[1].GetType() == typeof(Bed))
            {
                Bed bed = (Bed)mebeli[1];
                Console.WriteLine($"This is a Bed with name: {bed.Name}, " +
                    $"Price: {bed.Price:C}, Height: {bed.Height}, Width: {bed.Width}, BedSpecs: {bed.BedSpecs}");
            }
            else if (mebeli[1].GetType() == typeof(Chair))
            {
                Chair chair = (Chair)mebeli[1];
                Console.WriteLine($"This is a Bed with name: {chair.Name}, " +
                    $"Price: {chair.Price:C}, Material: {chair.Material}, Manufacturer: {chair.Manufacturer}, Height: {chair.Height}, CanRotate: {chair.CanRotate}" +
                    $"HasHandRester {chair.HasHandResters}, HasSpring: {chair.HasSpring}");
            }
            Console.WriteLine("Welcome to Our Furniture Store");
            while (true)
            {
                string command = Console.ReadLine();

                if (command.ToUpper() == "END")
                {
                    break;
                }

                try
                {
                    if (command.StartsWith("FindProduct-"))
                    {
                        string productName = command.Substring("FindProduct-".Length);
                        Furniture furniture = furnitureStore.GetFurnitureByName(productName);
                        Console.WriteLine($"Product Details: {furniture.Name}, {furniture.Price:C}, {furniture.Material}, {furniture.Manufacturer}");
                    }
                    else if (command == "CountOfChairs")
                    {
                        Console.WriteLine($"Count of Chairs: {furnitureStore.CountOfChairs()}");
                    }
                    else if (command == "CountOfBeds")
                    {
                        Console.WriteLine($"Count of Beds: {furnitureStore.CountOfBeds()}");
                    }
                    else if (command == "AllChairs")
                    {
                        furnitureStore.PrintChairsNames();
                    }
                    else if (command == "AllBeds")
                    {
                        furnitureStore.PrintBedNames();
                    }
                }
                catch (NotFoundProductException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
    public enum Material
    {
        Wood,
        Steel,
        Plastic
    }

    public abstract class Furniture
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Material Material { get; set; }
        public string Manufacturer { get; set; }

        public Furniture(string name, decimal price, Material material, string manufacturer)
        {
            Name = name;
            Price = price;
            Material = material;
            Manufacturer = manufacturer;
        }
    }
    public class FurnitureStore
    {
        private List<Furniture> furnitureList = new List<Furniture>();

        public void RegisterProduct(string name, decimal price, Material mat, string manufacturer, double height, double width, string bedSpecs)
        {
            if (furnitureList.Exists(f => f.Name == name))
            {
                throw new DuplicatingProductException($"Product {name} already exists in database!");
            }

            furnitureList.Add(new Bed(name, price, mat, manufacturer, height, width, BedSpecs.Nails));
        }

        public void RegisterProduct(string name, decimal price, Material mat, string manufacturer, double height, bool canRotate, bool hasSpring, bool hasHandResters, double weightSupport)
        {
            if (furnitureList.Exists(f => f.Name == name))
            {
                throw new DuplicatingProductException($"Product {name} already exists in database!");
            }

            furnitureList.Add(new Chair(name, price, mat, manufacturer, height, canRotate, hasSpring, hasHandResters, weightSupport));
        }

        public Furniture GetFurnitureByName(string name)
        {
            Furniture furniture = furnitureList.Find(f => f.Name == name);

            if (furniture == null)
            {
                throw new NotFoundProductException($"Product {name} is not found in our database!");
            }

            return furniture;
        }

        public int CountOfChairs()
        {
            return furnitureList.Count(f => f is Chair);
        }

        public int CountOfBeds()
        {
            return furnitureList.Count(f => f is Bed);
        }

        public void PrintChairsNames()
        {
            var chairNames = furnitureList
                .Where(f => f is Chair)
                .Select(f => f.Name);

            Console.WriteLine(string.Join(", ", chairNames));
        }

        public void PrintBedNames()
        {
            var bedNames = furnitureList
                .Where(f => f is Bed)
                .Select(f => f.Name);

            foreach (var name in bedNames)
            {
                Console.WriteLine(name);
            }
        }
    }

    public class DuplicatingProductException : ApplicationException
    {
        public DuplicatingProductException(string message) : base(message) { }
    }

    public class NotFoundProductException : ApplicationException
    {
        public NotFoundProductException(string message) : base(message) { }

    }
}