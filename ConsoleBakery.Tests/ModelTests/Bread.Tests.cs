using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleBakery.Models;

namespace ConsoleBakery.Tests
{
  [TestClass]
  public class ConsoleBakeryTests
  {
    [TestMethod]
    public void PriceForQuantity_ReturnsPriceWithNoDiscounts_Float()
    {
      Assert.AreEqual(Bread.PriceForQuantity(4), 12.00f);
    }
  }
}