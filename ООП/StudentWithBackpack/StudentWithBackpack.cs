namespace StudentWithBackpack
{
    internal class StudentWithBackpack
    {
        static void Main(string[] args)
        {
            Student st1 = new Student() {Name = "Gancho", FamilyName="Petrov", Age = 15 };
            Backpack bp1 = new Backpack() {Volume=15.6, Color="Camouflage", Price=69.75m };
            st1.Backpack = bp1;
            //st1.Grades = new List<int>();
            st1.Grades.Add(5);
            st1.Grades.Add(4);
            st1.Grades.Add(6);
            Console.WriteLine("Sreden uspeh e: " + st1.GetAvarageGrade());
        }
    }
    public class Backpack
    {
        public double Volume { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
    }

    public class Student
    {
        public string Name { get; set; }
        private string familyName;
        public string FamilyName { get { return familyName.ToUpper().Substring(0,1)+"."; } set => familyName = value; }
        public int Age { get; set; }

        public Backpack Backpack { get; set; }

        public List<int> Grades { get; set; }

        public void PresentYourself()
        {
            //Console.WriteLine($"I am {name} and I am {Age} years old");
            //IncreaseAge();
        }
        private void IncreaseAge()
        { 
            Age++;
        }

        public double GetAvarageGrade()
        {
            double result = Grades.Average();
            return result;
        }
    }
}