using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GuschinIS.Sprint1.Task0.V12.Lib;

namespace Tyuiu.GuschinIS.Sprint1.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(6, res);
        }
    }
}