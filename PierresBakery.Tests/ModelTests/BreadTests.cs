using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void
BreadConstructor_ShouldCreateAnInstanceOfBread_Bread()
    {
      Bread newBreadOrder = new Bread(4);
      Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    }
    [TestMethod]
    public void
  GetBreadCount_ReturnBreadCount_Int()
  {
    int breadCount = 4;
    Bread breadOrder = new Bread(4);
    int result = breadOrder.BreadCount;
    Assert.AreEqual(breadCount, result);
  }
  }
}