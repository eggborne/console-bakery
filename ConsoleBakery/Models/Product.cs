namespace ConsoleBakery.Models
{
  public class Product
  {
    public float _pricePerUnit;
    public int _bogoAmount;
    public virtual int _quantity { get; set; }

    public Product(int quantity) {
      _quantity = quantity;
    }

    public int CalculateFreeUnits() {
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