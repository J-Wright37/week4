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

List<string> months = new List<string>();
months.Add(new string("January"));
months.Add(new string("February"));
months.Add(new string("March"));
Console.WriteLine(months.Count);
months.Remove("February");
Console.WriteLine(months.Count);
