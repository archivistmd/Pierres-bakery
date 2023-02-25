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
    [TestMethod]
    public void
CalculateTotal_Returns10IfOrdering2Bread_Int()
    {
      Bread breadOrder = new Bread(2);
      int breatTotal = breadOrder.CalculateTotal();
      Assert.AreEqual(10, breadTotal);
    }
    
    [TestMethod]
    public void CalculateTotal_Returns10IfOrdering3Breads_Int()
    {
      Bread breadOrder = new Bread(3);
      int breadTotal = breadOrder.CalculateTotal();
      Assert.AreEqual(10, breadTotal);
    }
    
    [TestMethod]
    public void CalculateTotal_Returns20IfOrdering6Breads_Int()
    {
      Bread breadOrder = new Bread(6);
      int breadTotal = breadOrder.CalculateTotal();
      Assert.AreEqual(20, breadTotal);
    }
  }
}