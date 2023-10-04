namespace CandyShop
{
    internal class CandyShop
    {
        static void Main(string[] args)
        {
            var candy = new Candy("Cake", 800);
            string nameOfCandy = candy.Name;
            candy.Calories = 120;
            Console.WriteLine(candy.Weight);
            candy.Weight = 300;
            candy.Ammount = 223;
        }
    }

    public class Candy
    {
        private int totalSold;
        private decimal price;
        private int calories;
        public string Name { get; private set; }
        public int Calories 
        {
            get { return calories; }
            set 
            {
                if (value < 100)
                {
                    calories = 100;
                }
                else
                {
                    calories = value;
                }
            } 
        }
        public double Weight { get; set; }
        public decimal PriceUSD 
        {
            get { return 1.2m * PriceUSD; } 
            set
            {
                if (value < 0)
                {
                    PriceUSD = 5.00m;
                    Console.WriteLine("Invalid Price for Candy! 0.50$ is not happy!");
                }
                else
                {
                    PriceUSD = value;
                }
            }
        }
        public Family Family { get; set; }
        public int Ammount { get; set; }
        public bool IsVeganAcceptable { get; }

        public Candy(string name, int calories)
        {
            Name = name;
            Calories = calories;
        }
        public Candy(string name, int calories, double weight)
        {
            Name = name;
            Calories = calories;
            Weight = weight;
        }
        public Candy(string name, int calories, double weight, decimal price)
        {
            Name = name;
            Calories = calories;
            Weight = weight;
            PriceUSD = price;
        }
        public Candy(string name, int calories, double weight, decimal price, Family family)
        {
            Name = name;
            Calories = calories;
            Weight = weight;
            PriceUSD = price;
            Family = family;
        }
        public void IncreaseAmmount(int ammount)
        {
            Ammount += ammount;
            Console.WriteLine($"{Name} Candy was increased to {Ammount}.");
        }

        public void SellAmmount(int ammount)
        {
            if (ammount <= Ammount)
            {
                Ammount -= ammount;
                totalSold += ammount;
            }
            else
            {
                Console.WriteLine($"Not enough {Name} Candy in stock to sell.");
            }
        }

        public decimal CalculateProfit()
        {
            return totalSold * PriceUSD;
        }
    }
    public enum Family
    {
        Bonbon, Cake, Licorice, Pretzels, SugarMagic, FruitPower
    }
}