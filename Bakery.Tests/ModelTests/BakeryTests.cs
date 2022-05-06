using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Bakery.Models;


namespace Bakery.Tests
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
    public void ItemConstructor_CorrectlyParsesString_int()
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
  }
  [TestClass]
  public class PastryTests
  {
     [TestMethod]
    public void ItemConstructor_CreatesInstanceOfBreadObject_CustomerPastry()
    {
      Pastry newCust = new Pastry("4");
      Assert.AreEqual(typeof(Pastry), newCust.GetType());
    }
    [TestMethod]
    public void ItemConstructor_CorrectlyParsesString_int()
    {
      Pastry newCust = new Pastry("4");
      Assert.AreEqual(4, newCust.PastryCount);
    }
  }
}