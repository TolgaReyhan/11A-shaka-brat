﻿namespace StaticAndNonStaticDemo
{
    internal class StaticAndNonStaticDemo
    {
        static void Main(string[] args)
        {
            User.TownName = "Plovdiv";
            User user1 = new User()
            {
                Name = "Ivan",
                Age = 15,
            };
            User user2 = new User()
            {
                Name = "Miroslav",
                Age = 14,
            };
            User user3 = new User()
            {
                Name = "Velislava",
                Age = 17,
            };
            int ageOfUser2 = user2.GetInfo(3);
            Console.WriteLine($"Mejdu drugoto user2 e na {ageOfUser2} godini");
            User.TownName = "Kozlodui";
            Console.WriteLine($"Mejdu drugoto user2 e na {user2.GetInfo(2)} godini");
            User.TownName = "Vurbica";
            Console.WriteLine($"Mejdu drugoto user3 e na {user3.GetInfo(1)} godini");
            int sumOfNumbers = 5 + User.ConvertStringToInt("7"); //12
            SwissKnife.WriteSchoolName();
            string magicWord = SwissKnife.SintesyWisdom("Obicham shopskata salata");
            Console.WriteLine(magicWord);
        }
    }

    public class User
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public static string TownName { get; set; } = "Shumen";
        public int GetInfo(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine($"({i + 1}) I am {Name}");
            }
            Console.WriteLine("I am from " + TownName);
            return Age;
        }
        public static int ConvertStringToInt(string str)
        {
            Console.WriteLine(TownName);
            return int.Parse(str);
        }
        public static string ConvertStingToInt(int num)
        {
            return num.ToString();
        }
    }
    public static class SwissKnife
    {
        public static string TownName { get; set; } = "Shumen";
        public static void WriteSchoolName()
        {
            Console.WriteLine("PGMETT!");
        }
        public static double SumNumbers(double a, double b)
        {
            return a + b;
        }
        public static double SubtractNumbers(double a, double b)
        {
            return a - b;
        }
        public static string SintesyWisdom(string word, int numberOfLetter = 2)
        {
            string result = "";
            for (int i = 0; i <= word.Length; i++)
            {
                if (i % numberOfLetter == numberOfLetter - 1)
                {
                    result += word[i];
                }
            }
            return result;  
        }
    }
}