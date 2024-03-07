// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
#region exercise 6

int counter = 0;

string[] stringArrayOfNames = new string[100];

while (true)
{
Console.WriteLine("Enter name:");
string input  = Console.ReadLine();

    Console.WriteLine("Do you want to enter another name ");
    stringArrayOfNames[counter++] = input;

    string yesNoInput = Console.ReadLine();

        if(yesNoInput == "y") continue;  
       
     else if (yesNoInput == "n")
    {
        for (int i = 0; i < counter; i++)
        {
            Console.WriteLine("Name: " +  stringArrayOfNames[i]);
        }
        break;
    }
    else
    {
        Console.WriteLine("Invalid input ");
    }
}
#endregion