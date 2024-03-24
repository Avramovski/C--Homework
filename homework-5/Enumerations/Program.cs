using Enumerations.Enum;



#region metods

static void IsWeekend(Days day)
{
    if(day == Days.Saturday ||day ==  Days.Sunday)
    {
        Console.WriteLine("Yessss");
    }else
    {
        Console.WriteLine($"noooo it is {day}");
    }
}
#endregion


#region using enums 

Days monday = Days.Monday;

IsWeekend(monday);
IsWeekend(Days.Sunday);
#endregion

#region converting enums
int num = 2;
Days dayTwo = (Days)num; ;
Console.WriteLine(dayTwo);

Days dayThree = Days.Wednesday;
int numThree = (int)dayThree;

Console.WriteLine("Enter enum");
string input = Console.ReadLine();
if (Enum.TryParse(input , out Days inputDay) ) 
{
    Console.WriteLine($"You enter enum: {inputDay}");
}
else
{
    Console.WriteLine("erorr");
}
#endregion