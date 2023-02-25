namespace ConsoleBakery.Models
{
  public class Bread : Product
  {
    public Bread(int quantity) : base(quantity) {
      _quantity = quantity;
      _pricePerUnit = 5.0f;
      _bogoAmount = 2;
    }
  }
}