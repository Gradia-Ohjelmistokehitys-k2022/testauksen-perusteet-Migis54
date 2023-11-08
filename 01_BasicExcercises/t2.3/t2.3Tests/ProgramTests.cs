using Microsoft.VisualStudio.TestTools.UnitTesting;
using t2._3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2._3.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CheckThat_AverageMethod_ReturnAverage()
        {
            List<float> list = new List<float>() {1, 2, 3 };
            float AssumedAverage = 2;
            float average = Program.Average_From_FloatList(list);
            Assert.AreEqual(AssumedAverage, average);
        }
        [TestMethod()]
        public void Check_If_ListIsEmpty()
        {
            List<float> list = new List<float> { 1, 2, 3 };
            Assert.AreNotEqual(0, list.Count);
        }
    }
}