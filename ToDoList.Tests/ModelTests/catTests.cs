using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mo.Models;

namespace Mo.Tests
{
  [TestClass]
  public class MoTests
  {

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Month newMonth = new Month(3);
      Assert.AreEqual(typeof(Month),  newMonth.GetType());
    }
}
}