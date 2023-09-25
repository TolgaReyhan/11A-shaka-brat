namespace StudentWithBackpack
{
    internal class StudentWithBackpack
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            while (true)
            {
                Console.Write("Student name: ");
                string studentName = Console.ReadLine();
                Console.Write("Family name: ");
                string studentFamilyName = Console.ReadLine();
                Console.Write("Age: ");
                int studentAge = int.Parse(Console.ReadLine());
                Student student = new Student() { Name = studentName, FamilyName = studentFamilyName, Age = studentAge };
                //student.Backpack = new Backpack() { Color = "Oranjeva", Price = 19.99m, Volume = 15.6 };
                //student.Backpack.Color = "Oranjeva";
                students.Add(student);
                Console.WriteLine("Input another student? Y/N");
                string answer = Console.ReadLine().ToUpper();
                if (answer.StartsWith("N"))
                {
                    break;
                }
                Console.WriteLine(new string('=', 20));
            }
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("Grades Phase: ");
            Console.WriteLine(new string('=', 20));
            Console.WriteLine("Choose Student from List: ");
            for (int i = 0; i < students.Count; i++)
            {
                var current = students[i];
                Console.WriteLine($"[{i+1}]{current.Name} {current.FamilyName} {current.Age} years old");
            }
            Console.WriteLine(new string('=', 20));
            while (true)
            {
                Console.Write("Choose Student Number Or stop: ");
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                int chosenIndex = int.Parse(input) - 1;
                Student selectedStudent = students[chosenIndex];
                Console.WriteLine("Input Grades separated with space: ");
                var grades = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
                selectedStudent.Grades.AddRange(grades);
            }
            foreach (var s in students)
            {
                Console.WriteLine($"{s.Name} {s.FamilyName}. Age - {s.Age}");
                Console.WriteLine($"Has Backpack: {s.Backpack.Color} - color");
                Console.WriteLine($"Avarega score: {s.GetAvarageGrade():F2}");
                Console.WriteLine(new string( '~', 20));
            }

            //Student st1 = new Student() {Name = "Gancho", FamilyName="Petrov", Age = 15 };
            //Backpack bp1 = new Backpack() {Volume=15.6, Color="Camouflage", Price=69.75m };
            //st1.Backpack = bp1;
            ////st1.Grades = new List<int>();
            //st1.Grades.Add(5);
            //st1.Grades.Add(4);
            //st1.Grades.Add(6);
            //st1.Grades.Add(5);
            //st1.Grades.Add(6);
            //Console.WriteLine("Sreden uspeh e: " + st1.GetAvarageGrade()); 
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

        public Backpack Backpack { get; set; } = new Backpack() { Color = "Cherven", Price = 19.99m, Volume = 15.6 };

        public List<int> Grades { get; set; } = new List<int>();

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