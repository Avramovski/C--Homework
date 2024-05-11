using ClassLibrary.Domain;
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
                    TrackReading();
                    break;
                case "2":
                    TrackExercising(userDb);
                    break;
                case "3":
                    TrackWorking();
                    break;
                case "4":
                    TrackOtherHobbies();
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }

        private void TrackReading()
        {
            Console.WriteLine("Reading selected.");
            Console.Write("Enter the number of pages read: ");
            int pagesRead = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select the type of reading material:");
            Console.WriteLine("1. Belles Lettres");
            Console.WriteLine("2. Fiction");
            Console.WriteLine("3. Professional Literature");
            Console.Write("Enter the number corresponding to the type: ");
            int typeChoice = Convert.ToInt32(Console.ReadLine());
           
            string type = "";
            
            MyTimer.Start(1000);
            switch (typeChoice)
            {
                case 1:
                    type = "Belles Lettres";
                    Console.WriteLine("Press any key to stop");
                    break;
                case 2:
                    type = "Fiction";
                    Console.WriteLine("Press any key to stop");
                    break;
                case 3:
                    type = "Professional Literature";
                    Console.WriteLine("Press any key to stop");
                    break;
                default:
                    Console.WriteLine("Invalid input. Type set to default");
                    type = "Unknown";
                    break;
            }
            Console.ReadKey();
            MyTimer.Stop();

            Console.WriteLine($"Tracking reading activity. Pages read: {pagesRead}, Type: {type}");

        }

        private void TrackExercising( User user)
        {
            ExercisingService exercisingService = new ExercisingService();
            exercisingService.TimeExercising(user);
        }

        private void TrackWorking()
        {
            Console.WriteLine("Working selected.");
           
        }

        private void TrackOtherHobbies()
        {
            Console.WriteLine("Other Hobbies selected.");
            
        }
    }
}
