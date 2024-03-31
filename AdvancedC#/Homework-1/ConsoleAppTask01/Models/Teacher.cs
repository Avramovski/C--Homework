

using ConsoleAppTask01.Models.Interfaces;

namespace ConsoleAppTask01.Models
{
    public class Teacher : User,ITeacher
    {
        public List<string> Subjects {  get; set; }
        public override void PrintUser()
        {
            Console.WriteLine($"User:{Name}\nUsername:{Username}\nId:{Id} ");

          int  count = 0;
            foreach ( string s in Subjects )
            {
                count++;
            }
                Console.WriteLine($"Teacher is teaching: {count} subjects");
        }
        public void PrintSubjects()
        {
            Console.WriteLine("Subjects:");
           foreach (string subject in Subjects) 
            {
            Console.WriteLine(subject);
            }
        }
    }
}
