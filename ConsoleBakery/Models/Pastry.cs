namespace ConsoleBakery.Models
{
  public class Pastry : Product
  {
    public Pastry(int quantity) : base(quantity) {
      _quantity = quantity;
      _pricePerUnit = 2.0f;
      _bogoAmount = 3;
    }
  }
}