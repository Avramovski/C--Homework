// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

DateTime dateTime = DateTime.Today;
static string FormatDateTime(DateTime dateTime)
{
   
    string formattedDateTime = dateTime.ToString("MM/dd/yyyy");

    return formattedDateTime;
}
Console.WriteLine(FormatDateTime(dateTime));