using System.Collections.Generic;
using System;

namespace ConsoleBakery.Models
{
  public class Bread 
  {
    private static float _pricePerUnit = 3.0f;
    
    public static float PriceForQuantity(int quantity) 
    {
      float totalPrice = quantity * _pricePerUnit;
      return totalPrice;
    }
  }
}