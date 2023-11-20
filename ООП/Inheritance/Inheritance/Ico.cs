using Inheritance.NoInheritance.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Inheritance
{
    public class Ico : Animal
    {
        public Ico(string name, int shoeSize) : base(name)
        {
            ShoeSize = shoeSize;
        }
        
        public Ico(string name, int age, double weight, int height, string clothesSize) : base(name, age, weight)
        {
            Height = height;
            ClothesSize = clothesSize;
        }

        public int Height { get; set; }
        public int ShoeSize { get; set; }
        public string ClothesSize { get; set; }
        public void IcoBojinkata()
        {
            Console.WriteLine("DIRIRIDIRIRI");
        }


    }
}
