// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
#region task 1

int[] intArray = new int[6];

   for (int i = 0; i <6; i++)
  {
        Console.WriteLine("Enter number: ");
        string num1 = Console.ReadLine();
        bool isNum1 = int.TryParse(num1, out int value);

    if(isNum1) 
    {
        intArray[i] = value;    
    }

    else 
    {
        Console.WriteLine("Invalid input. Please enter a valid number ");
        break;
    }

  }
    int sum  = 0;   
foreach(int  num in intArray)
{
    if (num%2==0)
    {
        sum += num;
    }
}

Console.WriteLine("the result is: " + sum);

#endregion