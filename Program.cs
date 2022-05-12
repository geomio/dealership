using System;
using System.Collections.Generic;
using Models;

namespace Dealership
{
  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
      Car yugo = new Car("1980 Yugo Koral", 700, 56000);
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
      Car amc = new Car("1976 AMC Pacer", 400, 198000);

      List<Car> cars = new List<Car>() { volkswagen, yugo, ford, amc };

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      List<Car> carsMatchingSearch = new List<Car>();

      foreach (Car automobile in cars)
      {
        if (automobile.WorthBuying(maxPrice))
        {
          carsMatchingSearch.Add(automobile);
        }
      }

      foreach (Car automobile in carsMatchingSearch)
      {
        Console.WriteLine(automobile.MakeModel);
      }
    }
  }
}