using Microsoft.VisualStudio.TestTools.UnitTesting;
using t2._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2._1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void SmallestNumber_WithProperList_ReturnSmallestValue()
        {
            double pienin = 5;
            double oletettuPieninArvo = 5;
            List<double> list = new List<double>();
            list.Add(pienin);
            pienin = Program.Smallest_Number(list);
            Assert.AreEqual(pienin, oletettuPieninArvo);

        }

        [TestMethod()]
        public void check_That_ListIsNot_empty()
        {
            //Arrange
            double arvo = 5;
            List<double> list = new List<double>();
            list.Add(arvo);
            Assert.AreNotEqual(0, list.Count);
            

        }
    }
        
}