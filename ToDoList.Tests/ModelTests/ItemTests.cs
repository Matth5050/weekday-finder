using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bd.Models;

namespace Bd.Tests
{
  [TestClass]
  public class BdTests
  {

    [TestMethod]
    public void BirthdayConstructor_CreatesInstanceOfBirthday_Birthday()
    {
      Birthday newBday = new Birthday(13);
      Assert.AreEqual(typeof(Birthday), newBday.GetType());
    }

    [TestMethod]
    public void age_ReturningFinalAge_2022()
    {
      // string test = "hello";
      Birthday newBday = new Birthday(0);
      Assert.AreEqual(2022, newBday.age());
    }
    


}
}