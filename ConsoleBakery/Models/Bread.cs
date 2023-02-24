using System.Collections.Generic;
using System;

namespace ConsoleBakery.Models
{
  public class Bread
  {
    private float _pricePerUnit = 5.0f;
    private int _bogoAmount = 2;
    private int _quantity { get; set; }

    public Bread(int quantity) {
      _quantity = quantity;
    }

    private int CalculateFreeUnits() {
      int freeUnits = (_quantity / (_bogoAmount + 1));
      return freeUnits;
    }

    public float PriceForQuantity() {
      float totalPrice = _quantity * _pricePerUnit;
      int freeUnits = CalculateFreeUnits();
      totalPrice -= freeUnits * _pricePerUnit;
      return totalPrice;
    }
  }
}