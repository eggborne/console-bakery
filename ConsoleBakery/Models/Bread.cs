namespace ConsoleBakery.Models
{
  public class Bread : Product
  {
    public Bread(int quantity) : base(quantity) {
      this.name = "bread";
      this.quantity = quantity;
      this.pricePerUnit = 5.0f;
      this.bogoAmount = 2;
    }
  }
}