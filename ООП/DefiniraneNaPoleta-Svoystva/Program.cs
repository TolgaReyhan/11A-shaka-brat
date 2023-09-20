namespace DefiniraneNaPoleta_Svoystva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dice d1 = new Dice();
            Dice d2 = new Dice();
            d1.Sides = 7;
            d2.Sides = 5;
            d1.PresentInfo();
            //Console.WriteLine($"Broqt na strani na zar1 e: {d1.Sides}. A cveta na zarcheto e {d1.Color}");
            Console.WriteLine(new string('=', 20));
            d1.Color = "Magenta";
            d1.Sides = 15;
            d1.PresentInfo();
            d2.PresentInfo();
            Console.WriteLine($"Broqt na strani na zar2 e :" + d2.Sides);
            for (int i = 0; i < 10; i++)
            {
                int rolledNumber = d1.RollDice();
                Console.WriteLine($"Hvurlihme zarche1 i poluchihme: {rolledNumber}");
                Thread.Sleep(1000);
            }
            for (int i = 0; i < 10; i++)
            {
                int rolledNumber = d2.RollDice();
                Console.WriteLine($"Hvurlihme zarche2 i poluchihme: {rolledNumber}");
                Thread.Sleep(1000);
            }
            Dice d3 = new Dice { Color = "Oranjevo", Sides = 12 };
            d3.PresentInfo();
        }
    }

    public class Dice
    {
        int sides;
        public int Sides { get => sides; set => sides = value; }
        string color = "white";
        public string Color { get => color; set => color = value; }

        public void PresentInfo()
        {
            Console.WriteLine($"Broqt na strani na zar1 e: {Sides}. A cveta na zarcheto e {Color}");
        }
        public int RollDice()
        {
            Random rnd = new Random();
            int result = rnd.Next(1, Sides+1);
            return result;
        }
    }
}