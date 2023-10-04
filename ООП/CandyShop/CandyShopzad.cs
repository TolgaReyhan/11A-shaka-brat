namespace CandyShop
{
    internal class CandyShopzad
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class CandyShop
    {
        public string Name { get; set; } = "Asen";
        public int Calories { get; set; }
        public double WeightKgs { get; set; }
        public decimal PriceUSD { get; set; }
        public Family Family { get; set; }
        
        public Konstruktor(string name, int calories)
        {
            Name = name;
            Calories = calories;
        }

    }
    public enum Family
    {
        Bonbon, Cake, Licorice, Pretzels, SugarMagic, FruitPower
    }
}