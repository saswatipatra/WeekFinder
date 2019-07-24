using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeekDay.Models;
using System;

namespace WeekDay.Tests
{
    [TestClass]
    public class DayConverterTest
    {
        [TestMethod]
        public void IsLeapYear_YearDivisibleBy100_False()
        {
            Console.WriteLine(1900 % 4);
            Console.WriteLine(1900 % 100);
            Console.WriteLine(1900 % 400);
            Assert.AreEqual(false, DayConvertor.IsLeapYear(1900));
        }
    }
}