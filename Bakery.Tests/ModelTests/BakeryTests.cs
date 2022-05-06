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
  }
}