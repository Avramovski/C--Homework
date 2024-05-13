

using ClassLibrary.Domain.Activitys;
using ClassLibrary.Domain.DomainModels;
using ClassLibrary.Helpers;
using ClassLibrary.Services.ActivitiesInterfaces;
using ClassLibrary.Services.Enums;
using ClassLibrary.Services.Models;
using System.Diagnostics;

namespace ClassLibrary.Services.ActivitiesService
{
    public class ReadingService : ServiceBase<User>, IReading
    {
        public void TimeReading(User user)
        {
            
            Console.Clear();
            ExtendedConsole.PrintInColor("Track Exercising", ConsoleColor.Magenta);
            ExtendedConsole.PrintInColor($"Select Type of Exercising: \n1.{ReadingE.BellesLettres}\n2.{ReadingE.ProfessionalLiterature}\n3.{ReadingE.Fiction}", ConsoleColor.Blue);
            ReadingE readingE = new ReadingE();
            string input = Console.ReadLine();
            Console.WriteLine("Input the number of pages:");
            string pagesInput = Console.ReadLine();
            bool pages = int.TryParse(pagesInput, out int page); 
            MyTimer.Start(1000);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (input =="1")
            {
                readingE = ReadingE.BellesLettres;
            }
            else if (input =="2")
            {
                readingE = ReadingE.ProfessionalLiterature;
            }
            else if (input =="3")
            {
                readingE = ReadingE.Fiction;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            Console.ReadKey();
            stopwatch.Stop();
            MyTimer.Stop();
            TimeSpan test = stopwatch.Elapsed;
            Reading reading = new (readingE,page);
            reading.Type = readingE;
            reading.TimeSpentOnActivity = test;
            user.Reading.Add(reading);
            Update(user);
        }
    }
}