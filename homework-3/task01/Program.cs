// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");


//Make a method called AgeCalculator
//The method will have one input parameter, your birthday date
//The method should return your age
//Show the age of a user after he inputs a date

Console.WriteLine("Your birthday:");
DateTime birthday;
DateTime.TryParse(Console.ReadLine(), out birthday);
 static int CalculateAge(DateTime birthday)
{
    DateTime today = DateTime.Today;
    int age = today.Year - birthday.Year;
    return age;
}

Console.WriteLine(CalculateAge(birthday));
