

using ConsoleAppTask01.Models.Interfaces;

namespace ConsoleAppTask01.Models
{
    public class Student : User,IStudent
    {
        public List<int> Grades { get; set; }
        public override void PrintUser()
        {
            Console.WriteLine($"User:{Name}\nUsername:{Username}\nId:{Id} ");

            Console.WriteLine($"Average grade is: {Grades.Average()}");
        }
        public  void PrintGrades()
        {
            Console.WriteLine("Your grades are:");
            foreach (int grade in Grades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
