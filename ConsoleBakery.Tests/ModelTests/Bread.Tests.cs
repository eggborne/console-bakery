using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleBakery.Models;

namespace ConsoleBakery.Tests
{
  [TestClass]
  public class ConsoleBakeryTests
  {
    [TestMethod]
    public void ProduceWordScore_RejectsNonLetters_Int()
    {
      Assert.AreEqual(0, 0);
    }
    [TestMethod]
    public void ProduceWordScore_GetsCorrectScore_Int()
    {
      Assert.AreEqual(0, 22);
    }
  }
}