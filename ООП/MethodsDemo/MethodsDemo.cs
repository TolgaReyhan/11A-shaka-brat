namespace MethodsDemo
{
    internal class MethodsDemo
    {
        static void Main(string[] args)
        {
            GetNum(6, "alabala");
            ChangeOil("Ford Focus Gen2");
            ChangeOil("Ford Focus Gen2","superMaslo");
            ChangeOil("Ford Focus Gen2","superMaslo","full");
            ChangeOil("Ford Focus Gen2","superMaslo","full",true);
            ChangeOil(model:"Ford Mustang",refillFuel: true);
            ChangeOil(howMuch: "quarter", model: "C200 Mercedes");

            //Overloading
            Refuel("ford-mustang 87");
            Refuel("ford-mustang 87","benzin");
            Refuel("ford-mustang 87","benzin",0.98);

            double[] nums = { 1, 4, 6, 8, 12 };
            //Console.WriteLine("Sumata na chislata e:" + SumNumbers(nums));
            Console.WriteLine("Sumata na chislata e:" + SumNumbers(10.43,2.7));
        }
        public static double SumNumbers(double favoriteNumber, params double[] numbers)
        {
            double result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result = result + numbers[i];
            }
            result *= favoriteNumber;
            return result;
        }
        //Optional parameters
        public static void ChangeOil(string model, string oil = "superMaslo", string howMuch = "half", bool refillFuel =  false)
        {
            Console.WriteLine("we change oil best");
        }
        public static void Refuel(string model)
        {
            Console.WriteLine($"We refuel cars best, knowing model is {model}");
        }
        public static void Refuel(string model, string fuelType)
        {
            Refuel(model);
            Console.WriteLine($"fuell added was {fuelType}");
        }
        public static void Refuel(string model, string fuelType, double fuelPrice)
        {
            Console.WriteLine($"We filled it to {fuelPrice*100}5 of capacity ");
        }
        public static int GetNum(int num1 = 6, string s1 = "nqma problem" )
        {
            return 5;
        }
    }
}