using ConsoleAppTask01.Models;

Student student1 = new Student()
{
    Name = "Nikola",
    Username = "Avram",
    Id = 1,
    Grades = new List<int> { 4, 5, 4, 5 }
};
student1.PrintUser();

Console.WriteLine("--------------------------------------------------------------------");
Student student2 = new Student()
{
    Name = "Fico",
    Username = "Zlatan",
    Id = 2,
    Grades = new List<int> { 3, 3, 4, 5 }
};
student2.PrintUser();

Console.WriteLine("--------------------------------------------------------------------");
Teacher teacher1 = new Teacher()
{
    Name = "Bobo",
    Username = "Bobi",
    Id = 1,
    Subjects = new List<string> {"Java Script","C++","C#","PhP" }

};

teacher1.PrintUser();

Console.WriteLine("--------------------------------------------------------------------");
Teacher teacher2 = new Teacher()
{
    Name = "Jon",
    Username = "Doe",
    Id = 1,
    Subjects = new List<string> { "Java Script", "C++", "C", "Python",".NET" }

};

teacher2.PrintUser();
