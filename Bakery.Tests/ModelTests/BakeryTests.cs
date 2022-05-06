using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfBreadObject_CustomerBread()
    {
      CustomerBread newCust = new CustomerBread("4");
      Assert.AreEqual(typeof(CustomerBread), newCust(GetType()));
    }
  }
}