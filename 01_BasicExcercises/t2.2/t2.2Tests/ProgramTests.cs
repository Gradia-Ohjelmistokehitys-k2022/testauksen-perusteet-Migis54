using Microsoft.VisualStudio.TestTools.UnitTesting;
using t2._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2._2.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void Check_If_InListHighestValue_IsHighest()
        {
            int Highest = 100;
            int OletettuHighest = 100;
            List<int> list = new List<int>();
            list.Add(Highest);
            Highest = Program.List_Highest_Int(list);
            Assert.AreEqual(Highest, OletettuHighest);
        }
        [TestMethod()]
        public void Check_if_listIsEmpty() 
        {
            int arvo = 5;
            List<int> list = new List<int>();
            list.Add(arvo);
            Assert.AreNotEqual(0, list.Count);
        }
    }
}