using System;

namespace Dealership.Models
{
  public class Car
  {
    public string _makeModel;
    public int _price;
    public int _miles;

    public Car(string makeModel, int price, int miles)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public int GetPrice()
    {
      return _price;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (_price <= maxPrice);
    }
  }
}