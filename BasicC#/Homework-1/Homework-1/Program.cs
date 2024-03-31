// See https://aka.ms/new-console-template for more information
using System.Buffers;
Console.WriteLine("Hello, World!");
#region task 1
Console.WriteLine("Enter the first number:");
string numberOne = Console.ReadLine();
bool isNum1 = int.TryParse(numberOne,out int firstNum);

Console.WriteLine("Enter Operation:");
string  operationStatus = Console.ReadLine();
bool operation = int.TryParse(operationStatus,out int operationToDo);

Console.WriteLine("Enter the second number:");
string numberTwo = Console.ReadLine(); 
bool isNum2 = int.TryParse(numberTwo,out int secoundNumber);

if (isNum1 && isNum2)
{
    if (operationStatus == "-")
    {
        int result = firstNum - secoundNumber;
        Console.WriteLine("Result:" + result);
    }
    if (operationStatus == "+")
    {
        int result2 = firstNum + secoundNumber;
        Console.WriteLine(result2);
    }
    if (operationStatus == "/")
    {
        double result3 = (double)firstNum / secoundNumber;
        Console.WriteLine(result3);
    }
    if (operationStatus =="*")
    {
        int result4 = firstNum * secoundNumber;
        Console.WriteLine(result4);
    }
}
else
{
    Console.WriteLine(" Invalid. Enter 2 valid numbers");
}
#endregion