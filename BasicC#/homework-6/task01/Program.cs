string YesNoInput;
Queue<int> numbersQueue = new Queue<int>();
do
{
    Console.WriteLine("Enter a number:");
    string input = Console.ReadLine();
    bool isNum = int.TryParse(input, out int num);

    if (isNum)
    {
        Console.WriteLine($"You entered: {num}");
        numbersQueue.Enqueue(num);
        Console.WriteLine("Do you want to input another number (Y/N):");
        YesNoInput = Console.ReadLine().ToUpper();

        while (YesNoInput != "Y" && YesNoInput != "N")
        {
            Console.WriteLine("Invalid input. Please enter 'Y' or 'N'");
            Console.WriteLine("Do you want to input another number (Y/N):");
            YesNoInput = Console.ReadLine().ToUpper();
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number");
        YesNoInput = "Y";
    }

} while (YesNoInput == "Y");

Console.WriteLine("Numbers stored in the queue:");


foreach (int num in numbersQueue)
{
    Console.WriteLine(num);
}
