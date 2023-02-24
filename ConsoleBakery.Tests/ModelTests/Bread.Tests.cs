using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleBakery.Models;

namespace ConsoleBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void PriceForQuantity_ReturnsPriceWithDiscounts_Float() {
      Bread tooFew = new Bread(2);
      Bread earnedOne = new Bread(3);
      Bread earnedOneButNotTwo = new Bread(5);
      Bread earnedTwo = new Bread(6);

      Assert.AreEqual(tooFew.PriceForQuantity(), 10.00f);
      Assert.AreEqual(earnedOne.PriceForQuantity(), 10.00f);
      Assert.AreEqual(earnedOneButNotTwo.PriceForQuantity(), 20.00f);
      Assert.AreEqual(earnedTwo.PriceForQuantity(), 20.00f);
    }
    public void CalculateFreeUnits_ReturnsCorrectFreeUnits_Int() {
      Bread tooFew = new Bread(1);
      Bread earnedOne = new Bread(3);
      Bread earnedOneButNotTwo = new Bread(4);
      Bread earnedTwo = new Bread(6);

      Assert.AreEqual(tooFew.CalculateFreeUnits(), 0);
      Assert.AreEqual(earnedOne.CalculateFreeUnits(), 1);
      Assert.AreEqual(earnedOneButNotTwo.CalculateFreeUnits(), 1);
      Assert.AreEqual(earnedTwo.CalculateFreeUnits(), 2);
    }
  }
}