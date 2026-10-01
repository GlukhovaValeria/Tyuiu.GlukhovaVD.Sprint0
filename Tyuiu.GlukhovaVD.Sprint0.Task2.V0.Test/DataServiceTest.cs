using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GlukhovaVD.Sprint0.Task2.V0.Lib;

namespace Tyuiu.GlukhovaVD.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChekGetMessageValid()
        {
            var name = "Валерия";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("привет..., Валерия", res);
        }
    }
}
