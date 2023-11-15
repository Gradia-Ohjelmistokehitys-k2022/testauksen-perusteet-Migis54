using Microsoft.VisualStudio.TestTools.UnitTesting;
using t1._3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace t1._3.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void Testaa_Että_syöttö_on_Numerollinen()
        {
            Program rogrammi = new Program();
            rogrammi.syöttö = "2";
            Assert.IsTrue(rogrammi.Syöttö_on_numerollinen(rogrammi.syöttö, 0));
        }
        [TestMethod()]
        public void Kattoo_Että_syöttö_Ei_Ole_negatiivinen_Jos_Ei_Niin_Anna_False() 
        {
            Program rogrammi = new Program();
            rogrammi.syöttö = "2";
            Assert.IsTrue(rogrammi.Syöttö_Ei_Ole_miinus_luku(rogrammi.syöttö, 0));
        }
    }
}