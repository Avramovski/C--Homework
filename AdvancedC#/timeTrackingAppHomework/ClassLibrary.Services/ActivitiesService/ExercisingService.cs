

using ClassLibrary.Domain.Activitys;
using ClassLibrary.Domain.DomainModels;
using ClassLibrary.Helpers;
using ClassLibrary.Services.ActivitiesInterfaces;
using ClassLibrary.Services.Enums;
using ClassLibrary.Services.Models;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ClassLibrary.Services.ActivitiesService
{
    public class ExercisingService : ServiceBase<User>, IExercising
    {
        public void TimeExercising(User user)
        {
             
            Console.Clear();
            ExtendedConsole.PrintInColor("Track Exercising", ConsoleColor.Magenta);
            ExtendedConsole.PrintInColor($"Select Type of Exercising: \n1.{ExercisingE.General}\n2.{ExercisingE.Running}\n3.{ExercisingE.Sport}", ConsoleColor.Blue);
            ExercisingE exercisingE = new ExercisingE();
            string input = Console.ReadLine();
            MyTimer.Start(1000);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if(input =="1")
            {
                exercisingE = ExercisingE.General;
            }
            else if (input =="2") 
            {
                exercisingE = ExercisingE.Running;
            }
            else if (input =="3")
            {
                exercisingE = ExercisingE.Sport;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            Console.ReadKey();
            stopwatch.Stop();
            MyTimer.Stop();
            TimeSpan test = stopwatch.Elapsed;   
            Exercising exercising = new(exercisingE);
            exercising.Type = exercisingE;
            exercising.TimeSpentOnActivity = test;
            user.Exercising.Add(exercising);
            Update(user);
        }
    }
}
