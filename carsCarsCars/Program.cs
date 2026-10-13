string[] cars = {"Ford", "Toyota", "BMW", "Honda"};

foreach (string car in cars)
{
    Console.WriteLine(car);
    
}Console.WriteLine("");

Array.Sort(cars);
foreach (string car in cars)
{
    Console.WriteLine(car);
    
}Console.WriteLine("");

//for(int carIndex = 0; carIndex < cars.Length; carIndex++)
//{
//    Console.WriteLine(cars[carIndex]);
//}