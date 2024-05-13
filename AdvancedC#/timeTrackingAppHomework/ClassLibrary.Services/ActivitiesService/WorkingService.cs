using ClassLibrary.Domain.Activitys;
using ClassLibrary.Domain.DomainModels;
using ClassLibrary.Helpers;
using ClassLibrary.Services.ActivitiesInterfaces;
using ClassLibrary.Services.Enums;
using ClassLibrary.Services.Models;
using System.Diagnostics;

namespace ClassLibrary.Services.ActivitiesService
{
    public class WorkingService : ServiceBase<User>, IWorking
    {
        public void TimeWorking(User user)
        {

            Console.Clear();
            ExtendedConsole.PrintInColor("Track Exercising", ConsoleColor.Magenta);
            ExtendedConsole.PrintInColor($"Select Type of Exercising: \\n1.{WorkingE.Office}\\n2.{WorkingE.Home}", ConsoleColor.Blue);
            WorkingE workingE = new WorkingE();
            string input = Console.ReadLine();
            MyTimer.Start(1000);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (input =="1")
            {
                workingE = WorkingE.Office;
            }
            else if (input =="2")
            {
                workingE = WorkingE.Home;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            Console.ReadKey();
            stopwatch.Stop();
            MyTimer.Stop();
            TimeSpan test = stopwatch.Elapsed;
            Working working = new Working(workingE);
            working.Type = workingE;
            working.TimeSpentOnActivity = test;
            user.Working.Add(working);
            Update(user);

        }
    }
}
