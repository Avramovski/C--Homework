using ClassLibrary.Domain.Activitys;
using ClassLibrary.Domain.DomainModels;
using ClassLibrary.Helpers;
using ClassLibrary.Services.ActivitiesInterfaces;
using ClassLibrary.Services.Enums;
using ClassLibrary.Services.Models;
using System.Diagnostics;

namespace ClassLibrary.Services.ActivitiesService
{
    public class HobbiesService : ServiceBase<User>, IHobbies
    {
        public void TimerHobbies(User user)
        {

            Console.Clear();
            ExtendedConsole.PrintInColor("Track Exercising", ConsoleColor.Magenta);
            ExtendedConsole.PrintInColor($"Select Type of Exercising: \n1.{HobbiesE.Ski}\n2.{HobbiesE.Swimming}", ConsoleColor.Blue);
            HobbiesE hobbiesE = new HobbiesE();
            string input = Console.ReadLine();
            MyTimer.Start(1000);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (input =="1")
            {
                hobbiesE = HobbiesE.Ski;
            }
            else if (input =="2")
            {
                hobbiesE = HobbiesE.Swimming;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            Console.ReadKey();
            stopwatch.Stop();
            MyTimer.Stop();
            TimeSpan test = stopwatch.Elapsed;
            OtherHobbies hobbies = new(hobbiesE);
            hobbies.Type = hobbiesE;
            hobbies.TimeSpentOnActivity = test;
            user.Hobbies.Add(hobbies);
            Update(user);
        }
    }
}
