using System.Collections.Generic;
using System;

namespace ConsoleBakery.Models
{
  public class Pastry
  {
    private float _pricePerUnit = 2.0f;
    private int _bogoAmount = 3;
    private int _quantity { get; set; }

    public Pastry(int quantity) {
      _quantity = quantity;
    }

    private int CalculateFreeUnits() {
      int freeUnits = (_quantity / (_bogoAmount + 1));
      return freeUnits;
    }

    public float PriceForQuantity() {
      float totalPrice = _quantity * _pricePerUnit;
      int freeUnits = CalculateFreeUnits();
      Console.WriteLine($"Would be ${totalPrice}, but you get {freeUnits} free!");
      totalPrice -= freeUnits * _pricePerUnit;
      return totalPrice;
    }
  }
}