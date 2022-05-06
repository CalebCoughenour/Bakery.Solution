using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreadBakery.Models;


namespace BreadBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfBreadObject_CustomerBread()
    {
      Bread newCust = new Bread("4");
      Assert.AreEqual(typeof(Bread), newCust.GetType());
    }
    [TestMethod]
    public void ItemConstructor_CorrectlyParsesBreadString_int()
    {
      Bread newCust = new Bread("4");
      Assert.AreEqual(4, newCust.BreadCount);
    }
    [TestMethod]
    public void AddBread_CorrectlyAddBreadPrices_Int()
    {
      Bread newCust = new Bread("4");
      newCust.BreadCalc();
      Assert.AreEqual(20, newCust.BreadSubTotal);
    }
    [TestMethod]
    public void AddBread_CorrectlyCalculatesSalePrices_Int()
    {
      Bread newCust = new Bread("4");
      newCust.BreadCalc();
      newCust.BreadSaleCalc();
      Assert.AreEqual(15, newCust.BreadSubTotal);
    }
    [TestMethod]
    public void AddBread_CorrectlyCalculatesSalePricesDoubleCheck_Int()
    {
      Bread newCust = new Bread("12");
      newCust.BreadCalc();
      newCust.BreadSaleCalc();
      Assert.AreEqual(40, newCust.BreadSubTotal);
    }
    [TestMethod]
    public void AddBread_CheckForZeroEntry_Int()
    {
      Bread newCust = new Bread("0");
      newCust.BreadCalc();
      newCust.BreadSaleCalc();
      Assert.AreEqual(0, newCust.BreadSubTotal);
    }
    // [TestMethod]
    // public void DiscountBread_TwentyFivePercentOff_Int()
    // {
    //   Bread newCust = new Bread("5");
    //   newCust.BreadCalc();
    //   newCust.BreadSaleCalc();
    //   newCust.ApplyDiscount();
    //   Assert.AreEqual(15, newCust.BreadSubTotal);
    // }
  }
}