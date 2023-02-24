using System.Collections.Generic;
using System;

namespace ConsoleBakery.Models
{
  public class Bread 
  {
    private static float _pricePerUnit = 5.0f;
    private static int _bogoAmount = 2;

    private static int CalculateFreeUnits(int baseUnits) {
      int freeUnits = (baseUnits / (_bogoAmount + 1));
      return freeUnits;
    }

    public static float PriceForQuantity(int quantity) 
    {
      float totalPrice = quantity * _pricePerUnit;
      int freeUnits = CalculateFreeUnits(quantity);
      Console.WriteLine($"You get {freeUnits} free!");
      totalPrice -= freeUnits * _pricePerUnit;
      return totalPrice;
    }
  }
}