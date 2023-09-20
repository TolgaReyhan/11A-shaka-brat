namespace Desk
{
    internal class Desk
    {
        static void Main(string[] args)
        {
            Desk1 d1 = new Desk1();
            d1.Weight = 10;
            d1.Price = 200.00;
            d1.Color = "Brown";
            d1.Material = "Wood";
            d1.Name = "Chin za dvama";
            d1.Manufacturer = "Balkan OOD";
            //Console.WriteLine($"Tozi chin teji: {d1.Weight}kg, cenata e: {d1.Price}lv, cvetut e: {d1.Color}, materialut e: {d1.Material}, broykata e: {d1.Availability}");
            d1.Present();
        }
    }
    public class Desk1
    {
        int weight;
        public int Weight { get => weight; set => weight = value; }
        double price;
        public double Price { get => price; set => price = value; }
        string color;
        public string Color { get => color; set => color = value; }
        string material;
        public string Material { get => material; set => material = value; }
        string name;
        public string Name { get => name; set => name = value; }
        string manufacturer;
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }

        public int Availability()
        {
            Random rnd = new Random();
            int result = rnd.Next(1, 500);
            return result;
        }
        
        public void Present()
        {
            Console.WriteLine($"Tozi chin teji: {Weight}kg, cenata e: {Price}lv, cvetut e: {Color}, materialut e: {Material}, imeto e: {Name}, proizvoditelqt e: {Manufacturer}, broykata e: {Availability()}");
        }
    }
}