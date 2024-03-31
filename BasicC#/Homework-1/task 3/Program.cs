// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter first number:");
string firstNum =  Console.ReadLine();  
bool valFirstNum = int.TryParse(firstNum, out int validNum1);

Console.WriteLine("Enter secound number:");
string  secondNum = Console.ReadLine();
bool valSecondNum =  int.TryParse(secondNum, out int validNum2);

if (valFirstNum && valSecondNum)
{
    int firstToSecundNUm = validNum2;
    int secondToSecundNUm = validNum1;

    Console.WriteLine("Now first:" + firstToSecundNUm);
    Console.WriteLine("Now second:" +  secondToSecundNUm);
}