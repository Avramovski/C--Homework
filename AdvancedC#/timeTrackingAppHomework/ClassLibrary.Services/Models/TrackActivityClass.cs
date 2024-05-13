using ClassLibrary.Domain;
using ClassLibrary.Domain.Activitys;
using ClassLibrary.Domain.DomainModels;
using ClassLibrary.Services.ActivitiesService;
using ClassLibrary.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Services.Models
{
    public class TrackActivityClass : ServiceBase<User>
    {
        public void TrackActivity(User user)
        {
            User userDb = GetAll().SingleOrDefault(u => u.Username.Equals(user.Username, StringComparison.InvariantCultureIgnoreCase) && u.Password == user.Password);

            Console.WriteLine("Activities Available for Tracking:");
            Console.WriteLine("1. Reading");
            Console.WriteLine("2. Exercising");
            Console.WriteLine("3. Working");
            Console.WriteLine("4. Other Hobbies");

            Console.Write("Enter the number corresponding to the activity you want to track: ");
            string activityChoice = Console.ReadLine();

            switch (activityChoice)
            {
                case "1":
                    TrackReading(userDb);
                    break;
                case "2":
                    TrackExercising(userDb);
                    break;
                case "3":
                    TrackWorking(userDb);
                    break;
                case "4":
                    TrackOtherHobbies(userDb);
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }

        private void TrackReading(User user)
        {
           ReadingService readingService = new ReadingService();
            readingService.TimeReading(user);

        }

        private void TrackExercising( User user)
        {
            ExercisingService exercisingService = new ExercisingService();
            exercisingService.TimeExercising(user);
        }

        private void TrackWorking(User user)
        {
            WorkingService workingService = new WorkingService();
            workingService.TimeWorking(user);   
        }

        private void TrackOtherHobbies(User user)
        {
            HobbiesService hobbiesService = new HobbiesService();
            hobbiesService.TimerHobbies(user);
            
        }
    }
}
