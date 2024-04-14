
using ConsoleApp.Models;
Console.WriteLine("================ Task 1 ==================");

PrintInConsole<int> ints = new PrintInConsole<int>();
PrintInConsole<string> strings = new PrintInConsole<string>();

List<int> integers = new List<int>() { 1, 2, 3, 4, 5 };
List<string> strings1 = new List<string>() {"\neden","dva","tri"};


ints.Print(integers);
strings.PrintCollection(strings1);


Console.WriteLine("\n\n================ Task 2 ==================\n\n");

Vehicle car = new Car();
Vehicle motorBike = new MotorBike();
Vehicle boat = new Boat();
Vehicle plane = new Airplane();

car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
plane.DisplayInfo();


Car carObj = (Car)car;
MotorBike bike = (MotorBike)motorBike;
Boat boatObj = (Boat)boat;
Airplane planeObj = (Airplane)plane;
Console.WriteLine("\n\n");
carObj.Drive();
bike.Wheelie();
boatObj.Sail();
planeObj.Fly();
