
namespace task01.myClasses
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public Car(string model, int speed, Driver driver)
        {
            Model = model;
            Speed = speed;
            Driver = driver;

        }
        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
            
        }


        public int CalculateSpeed()
        {
            if (Driver == null)
            {
                Console.WriteLine("Driver is not assigned to the car");
                return 0;
            }
            int driverSkill = Driver.Skill;
            int result = driverSkill * Speed;
            return result;

        }
        public int FasterInRace(Car model,Driver driver)
        {
            int speedCar1 = CalculateSpeed();

            return speedCar1;
        }
    }
}
