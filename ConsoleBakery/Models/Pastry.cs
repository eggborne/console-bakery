namespace ConsoleBakery.Models
{
  public class Pastry : Product
  {
    public Pastry(int quantity) : base(quantity) {
      this.name = "pastry";
      this.quantity = quantity;
      this.pricePerUnit = 2.0f;
      this.bogoAmount = 3;
    }
  }
}