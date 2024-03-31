// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
#region task 2

string[] studentsG1 =  {"nikola","filip","bob","dzoni","hasbula" };
string[] studentsG2 = {"mila","ana","sara","marija","mila" };
string input;
do
{
    input = Console.ReadLine();
    if (input =="1")
    {
        Console.WriteLine("Students from G1");
        foreach (string student in studentsG1)
        {
            Console.WriteLine(student);
        }
        break;
    }
    else if (input =="2")
    {
        Console.WriteLine("Students from G2");
        foreach (string student in studentsG2)
        {
            Console.WriteLine(student);
        }
        break;
    }
    else
    {
        Console.WriteLine("Invalid input enter 1 or 2 ");


    }
}
while (true);
#endregion