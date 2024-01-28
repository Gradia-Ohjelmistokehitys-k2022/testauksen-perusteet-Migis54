using Microsoft.VisualStudio.TestTools.UnitTesting;
using t1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace t1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void Testaa_Miinustus_funktion_sopivat_arvot()
        {
            Program rogrammi = new Program();
            long num1 = 10;
            long num2 = 0;
            try 
            {
                rogrammi.Miinustus(Convert.ToInt32(num1), Convert.ToInt32(num2));
            }
            catch(ArgumentOutOfRangeException e) 
            {
                StringAssert.Contains(e.Message, "arvot eiät ole sopivat");
            }
            
        }
        [TestMethod()]
        public void Testaa_Että_Vastaus_on_Numerollinen() 
        {
            Program rogrammi = new Program();
            rogrammi.vastaus = "2";
            Assert.IsTrue(rogrammi.Vastaus_on_numerollinen(rogrammi.vastaus, 0));
        }

    }
}