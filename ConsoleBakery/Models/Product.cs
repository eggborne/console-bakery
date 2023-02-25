namespace ConsoleBakery.Models
{
  public class Product
  {
    public float pricePerUnit;
    public int bogoAmount;
    public string name;
    public virtual int quantity { get; set; }

    public Product(int quantity) {
      this.quantity = quantity;
    }

    public int CalculateFreeUnits() {
      int freeUnits = (quantity / (bogoAmount + 1));
      return freeUnits;
    }

    public float PriceForQuantity() {
      float totalPrice = quantity * pricePerUnit;
      int freeUnits = CalculateFreeUnits();
      totalPrice -= freeUnits * pricePerUnit;
      return totalPrice;
    }
  }
}