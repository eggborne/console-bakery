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
      Bread tooFew = new Bread(1);
      Bread earnedOne = new Bread(3);
      Bread earnedOneButNotTwo = new Bread(4);

      Assert.AreEqual(tooFew.PriceForQuantity(), 5.00f);
      Assert.AreEqual(earnedOne.PriceForQuantity(), 10.00f);
      Assert.AreEqual(earnedOneButNotTwo.PriceForQuantity(), 15.00f);
    }
  }
}