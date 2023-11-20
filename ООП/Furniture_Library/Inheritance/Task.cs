using Task.Enum;

namespace Task.Inheritance
{
    internal class Task
    {
        static void Main(string[] args)
        {
            Furniture furniture = new Furniture(180, 70.00m, "biufet",Material.Wood,"KPD");
            Bed bed1 = new Bed(50, 80.00m, "king-bed", Material.Wood, "IVO EOD", 50, 200, 3, BedSpecs.matrak);
            Chair ch1 = new Chair(2, 20.00m, "lux", Material.Steel, "LUxyrY", 40, true, true, true);

        }
    }
    public class Furniture
    {
        public Furniture(double weight)
        {
            Weight = weight;
        }
        public Furniture(double weight,decimal price,string name,Material material,string manufacturer) : this(weight)
        {
            Price = price; 
            Name = name; 
            Material = material;
            Manufacturer = manufacturer;
        }
        public double Weight { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public Material Material { get; set; }
        public string Manufacturer { get; set; }
    }
    public enum Material
    {
        PVC, Steel, Aluminium, Wood
    }
}