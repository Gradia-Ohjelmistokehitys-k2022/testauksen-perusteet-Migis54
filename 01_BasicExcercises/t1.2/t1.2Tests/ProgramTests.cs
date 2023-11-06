using Microsoft.VisualStudio.TestTools.UnitTesting;
using t1._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1._2.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void Tarkista_Että_Vastaus_On_Alle_satayks_Jos_Ei_Niin_Heitä_Poikkeus()
        {
            Program rogrammi = new Program();
            rogrammi.vastaus = "100";
            try 
            {
                rogrammi.Maksimi_Numero(100);
            }
            catch(System.ArgumentOutOfRangeException e) 
            {
                StringAssert.Contains(e.Message, " numero on yli 100");
            }
            
        }
        [TestMethod()]
        public void Testaa_Että_Vastaus_on_Numerollinen()
        {
            Program rogrammi = new Program();
            rogrammi.vastaus= "9";
            Assert.IsTrue(rogrammi.Vastaus_on_numerollinen(rogrammi.vastaus, 0));
        }
    }
}