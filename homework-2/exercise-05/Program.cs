// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region homework
Console.WriteLine("Enter number :");
string num1 = Console.ReadLine();
Console.WriteLine("Enter number :");
string num2 = Console.ReadLine();
Console.WriteLine("Enter number :");
string num3 = Console.ReadLine();
Console.WriteLine("Enter number :");
string num4 = Console.ReadLine();
Console.WriteLine("Enter number :");
string num5 = Console.ReadLine();

bool isNum1 = int.TryParse(num1, out int value1);
bool isNum2 = int.TryParse(num2, out int value2);
bool isNum3 = int.TryParse(num3, out int value3);
bool isNum4 = int.TryParse(num4, out int value4);
bool isNum5 = int.TryParse(num5, out int value5);

int[] integersArray = new int[5];

integersArray[0] = value1;
integersArray[1] = value2;
integersArray[2] = value3;
integersArray[3] = value4;
integersArray[4] = value5;


int result = value1 + value2 + value3 + value4 + value5; 
Console.WriteLine( "The result is : " + result);
#endregion