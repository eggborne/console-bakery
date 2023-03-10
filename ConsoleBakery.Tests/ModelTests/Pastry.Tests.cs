using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleBakery.Models;

namespace ConsoleBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PriceForQuantity_ReturnsPriceWithDiscounts_Float() {
      Pastry tooFew = new Pastry(2);
      Pastry earnedOne = new Pastry(4);
      Pastry earnedOneButNotTwo = new Pastry(7);
      Pastry earnedTwo = new Pastry(8);

      Assert.AreEqual(tooFew.PriceForQuantity(), 4.00f);
      Assert.AreEqual(earnedOne.PriceForQuantity(), 6.00f);
      Assert.AreEqual(earnedOneButNotTwo.PriceForQuantity(), 12.00f);
      Assert.AreEqual(earnedTwo.PriceForQuantity(), 12.00f);
      
    }
  }
}