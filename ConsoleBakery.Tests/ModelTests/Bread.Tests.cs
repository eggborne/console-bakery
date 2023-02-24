using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleBakery.Models;

namespace ConsoleBakery.Tests
{
  [TestClass]
  public class ConsoleBakeryTests
  {
    [TestMethod]
    public void PriceForQuantity_ReturnsPriceWithDiscounts_Float()
    {
      Assert.AreEqual(Bread.PriceForQuantity(1), 5.00f);
      Assert.AreEqual(Bread.PriceForQuantity(3), 10.00f);
      Assert.AreEqual(Bread.PriceForQuantity(4), 15.00f);
    }
  }
}