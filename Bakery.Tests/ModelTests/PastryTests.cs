using Microsoft.VisualStudio.TestTools.UnitTesting;
using PastryBakery.Models;

namespace PastryBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfPastryObject_CustomerPastry()
    {
      Pastry newCust = new Pastry("4");
      Assert.AreEqual(typeof(Pastry), newCust.GetType());
    }
    [TestMethod]
    public void ItemConstructor_CorrectlyParsesPastryString_int()
    {
      Pastry newCust = new Pastry("4");
      Assert.AreEqual(4, newCust.PastryCount);
    }
    [TestMethod]
    public void AddPastry_CorrectlyAddPastryPrices_Int()
    {
      Pastry newCust = new Pastry("4");
      newCust.PastryCalc();
      Assert.AreEqual(8, newCust.PastrySubTotal);
    }
    [TestMethod]
    public void AddPastry_CorrectlyCalculatesSalePrices_Int()
    {
      Pastry newCust = new Pastry("4");
      newCust.PastryCalc();
      newCust.PastrySaleCalc();
      Assert.AreEqual(7, newCust.PastrySubTotal);
    }
    [TestMethod]
    public void AddPastry_DoubleCheckCalculatesSalePrices_Int()
    {
      Pastry newCust = new Pastry("12");
      newCust.PastryCalc();
      newCust.PastrySaleCalc();
      Assert.AreEqual(20, newCust.PastrySubTotal);
    }
    [TestMethod]
    public void AddPastry_CheckForZeroEntry_Int()
    {
      Pastry newCust = new Pastry("0");
      newCust.PastryCalc();
      newCust.PastrySaleCalc();
      Assert.AreEqual(0, newCust.PastrySubTotal);
    }
  }
}