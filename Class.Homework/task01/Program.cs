// See https://aka.ms/new-console-template for more information
using task01.myClasses;

Console.WriteLine("Hello, World!");


Driver driver1 = new Driver("Danilo", 5);
Driver driver2 = new Driver("Nikola", 4);
Driver driver3 = new Driver("Verstappen", 2);
Driver driver4 = new Driver("Hamilton", 2);


Car car1FirstTask = new Car("BMW", 200,driver1);
Car car2FirstTask = new Car("Nissan", 200,driver2);
Car car1 = new Car("Ford", 120);
Car car2 = new Car("Audi", 160);
Car car3 = new Car("Formula Red Bull", 312);    
Car car4 = new Car("Formula Mercedes",310);


static void RaceCars(Car car1FirstTask,Car car2FirstTask)
{
    int raccingCarSpeed1 = car1FirstTask.CalculateSpeed();
    int raccingCarSpeed2 = car2FirstTask.CalculateSpeed();

    if (raccingCarSpeed1 > raccingCarSpeed2)
    {
        Console.WriteLine("Car number1 was fasster");
    }
    else if (raccingCarSpeed2 > raccingCarSpeed1)
    {
        Console.WriteLine("Car number2 was fasster");
    }
    else
    {

        Console.WriteLine("No winner");
    }
}

RaceCars(car1FirstTask, car2FirstTask);

Console.WriteLine("Enter first car:");
string firstCarInput  = Console.ReadLine();

Console.WriteLine("Enter driver for the firdt car:");
string driverForFirstCarInput = Console.ReadLine();

Console.WriteLine("Enter second car:");
string secondCarInput = Console.ReadLine();


Console.WriteLine("Enter driver for the second car:");
string driverForSecondCarInput = Console.ReadLine();




