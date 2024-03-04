// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
#region task 2
Console.WriteLine("Enter first number:");
string firstNum = Console.ReadLine();
bool validFirstNum = int.TryParse(firstNum, out int isValidFirstNum);
Console.WriteLine("Enter second number:");
string secondNum = Console.ReadLine();
bool validSecondNum = int.TryParse(secondNum, out int isValidSecondNum);
Console.WriteLine("Enter third number:");
string thirdNum = Console.ReadLine();
bool validThirdNum = int.TryParse(thirdNum, out int isValidThirdNum);
Console.WriteLine("Enter fourth number:");
string fourthNum = Console.ReadLine();
bool validFourthNUmber = int.TryParse(fourthNum, out int isValidFourthNUmber);

if (validFirstNum && validSecondNum && validThirdNum && validFourthNUmber)
{
    int result = (isValidFirstNum + isValidSecondNum + isValidThirdNum + isValidFourthNUmber);
    double finalResolt = result / 4.0;
Console.WriteLine("the average number of " + isValidFirstNum + " ," + isValidSecondNum + " ," + isValidThirdNum + " ," + isValidFourthNUmber + " is:");
Console.WriteLine(finalResolt);
}
else
{
    Console.WriteLine("Invalid input please enter 4 valid numbers");
}
#endregion