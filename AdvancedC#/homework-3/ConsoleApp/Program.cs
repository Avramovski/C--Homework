
 List<Car> fromEurope = CarsData.Cars.Where(x => x.Origin == "Europe").ToList();

foreach (Car car in fromEurope)
{
    Console.WriteLine(car.Model);
}
Console.WriteLine("--------------------------------");

List<Car> cylindarList = CarsData.Cars.FindAll(x => x.Cylinders > 6 ).ToList();

foreach (Car car in cylindarList)
{
    Console.WriteLine($"{car.Model} with ---- {car.Cylinders} cylinders");
}
Console.WriteLine("--------------------------------");

List<Car> upperNames = CarsData.Cars.FindAll(x => x.Model == x.Model).ToList();

foreach (Car car in upperNames)
{
    Console.WriteLine(car.Model.ToUpper());
}
Console.WriteLine("--------------------------------");

List<Car> horsepowerGrateterThen300 = CarsData.Cars.Where(x => x.HorsePower > 300).ToList();

foreach (Car car in horsepowerGrateterThen300)
{
    Console.WriteLine($"{car.Model} with ---- {car.HorsePower} Horsepower");
}
Console.WriteLine("--------------------------------");

Car highesHorsepower = CarsData.Cars.OrderByDescending(x => x.HorsePower).FirstOrDefault();

Console.WriteLine(highesHorsepower.Model + "  " + highesHorsepower.HorsePower);
Console.WriteLine("--------------------------------");


List<Car> orderChevrolet = CarsData.Cars.FindAll(x => x.Model.StartsWith("Chevrolet")).OrderByDescending(x => x.Weight).ToList();

foreach (Car car in orderChevrolet)
{
    Console.WriteLine($"{car.Model} with weight of: {car.Weight}");
}
Console.WriteLine("--------------------------------");

Car longestName = CarsData.Cars.OrderByDescending(x => x.Model.Length).FirstOrDefault();

Console.WriteLine(longestName.Model);

Console.WriteLine("--------------------------------");

List<IGrouping<string, Car>> orderGrup = CarsData.Cars.GroupBy(x => x.Origin).OrderBy(x => x.Count()).ToList();

//nemozese normalno da se Cw so foreach
foreach (var group in orderGrup)
{
    foreach (var car in group)
    {
        Console.WriteLine($"Model: {car.Model} from {car.Origin}");
    }
}
Console.WriteLine("--------------------------------");


List<Car> top5HighHorsepowerCars = CarsData.Cars.OrderByDescending(car => car.HorsePower).Take(5).ToList();

foreach (Car car in top5HighHorsepowerCars)
{
    Console.WriteLine($"{car.Model}  with {car.HorsePower} horsepoweer");
}
Console.WriteLine("--------------------------------");

Car fastestAcl = CarsData.Cars.OrderBy(x => x.AccelerationTime).FirstOrDefault();

Console.WriteLine(fastestAcl.Model + "  " + fastestAcl.AccelerationTime);
Console.WriteLine("--------------------------------");


List<Car> graterThen200 =  CarsData.Cars.FindAll(x => x.HorsePower > 200).ToList();

foreach (Car car in graterThen200)
{
    Console.WriteLine($"{car.Model} with {car.HorsePower} horsepower");
}
    Console.WriteLine("--------------------------------");

List<Car> alphabetically = CarsData.Cars.OrderBy(a => a.Origin, StringComparer.OrdinalIgnoreCase).Distinct().ToList();

foreach (Car car in alphabetically)
{
    Console.WriteLine(car.Origin + " " + car.Model);
}
Console.WriteLine("--------------------------------");
//Select all cars with more than 4 cylinders, and order them by origin and then by horsepower.
List<Car> mreThen4Cil = CarsData.Cars.FindAll(x => x.Cylinders > 4).OrderBy(a => a.Origin, StringComparer.OrdinalIgnoreCase)
    .ThenBy(a => a.HorsePower).ToList();

foreach (Car car in mreThen4Cil)
{
    Console.WriteLine($"{car.Model} -- {car.Origin} -- {car.HorsePower}");
}
Console.WriteLine("--------------------------------");


List<Car> filteredCars = CarsData.Cars
    .Where(car => car.Cylinders > 6) 
    .Concat(CarsData.Cars.Where(car => car.Cylinders == 4 && car.HorsePower > 110.0)) 
    .ToList();

foreach (Car car in filteredCars)
{
    Console.WriteLine($"{car.Model} -- ({car.Cylinders}) -- {car.HorsePower}");

}
Console.WriteLine("--------------------------------");

List<Car> highPowerCars = CarsData.Cars.Where(car => car.HorsePower > 200).ToList();

double lowestMPG = highPowerCars.Min(car => car.MilesPerGalon);
double highestMPG = highPowerCars.Max(car => car.MilesPerGalon);
double averageMPG = highPowerCars.Average(car => car.MilesPerGalon);

Console.WriteLine($"Lowest : {lowestMPG}");
Console.WriteLine($"Highest : {highestMPG}");
Console.WriteLine($"Average : {averageMPG}");
Console.WriteLine("--------------------------------");

List<Car> my1 = CarsData.Cars.FindAll(x => x.Cylinders == 6 ).Where(x => x.Origin == "US").Where(x=> x.HorsePower >= 100).Take(6).ToList();

foreach (Car car in my1)
{
    Console.WriteLine($"{car.Model} -- {car.Origin} -- {car.HorsePower}");

}
Console.WriteLine("--------------------------------");

List<Car> my2 = CarsData.Cars.OrderByDescending(car => car.MilesPerGalon).Take(2).Where(x => x.Origin == "Japan").ToList();

foreach(Car car in my2)
{
    Console.WriteLine($"{car.Model} -- {car.Origin} -- {car.MilesPerGalon}");

}


