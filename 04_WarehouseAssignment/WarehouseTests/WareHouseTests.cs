using Microsoft.VisualStudio.TestTools.UnitTesting;
using WareHouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse;
using System.Data;

namespace WareHouse.Tests
{
    [TestClass()]
    public class WareHouseTests
    {
        
        
        [TestMethod()]
        public void AddToStock_IfItemInStockAlready_ThrowArgumentException()
        {
            WareHouse wareHouse = new();
            wareHouse.WareHouseSimulator();  
            try
            {
                
                
                wareHouse.AddToStocks("", 2);
                
            }
            catch (ArgumentException ex)
            {
                StringAssert.Contains(ex.Message, "itemName empty");
                return;
            }
            Assert.Fail();
        }
        [TestMethod()]
        public void TakeFromStock_IfItemNotInStock_ThrowArgumentException()
        {
            WareHouse wareHouse = new();
            wareHouse.WareHouseSimulator();
            Stock item1 = new("hat", 2);
            //_stockOfItems.Add(item1 );
            try
            {
                wareHouse.TakeFromStock("hat", 2);
            }
            catch (ArgumentException ex)
            {
                StringAssert.Contains(ex.Message, "Oversold");
                return;
            }
            
            Assert.Fail();
        }
        [TestMethod()]
        public void InStock_IFalse_ThrowAsserFailedException()
        {
            WareHouse wareHouse = new();
            wareHouse.WareHouseSimulator();
            
            try
            {
                Assert.IsTrue(wareHouse.InStock("hat"));
            }
            catch(AssertFailedException)
            {
                return;
            }
            Assert.Fail();
        }
        

        [TestMethod()]
        public void StockCount_IfItemNameIsNull_ThrowArgumentNullException()
        {
            WareHouse wareHouse = new();
            //wareHouse.WareHouseSimulator();
            string x = null;
            try
            {
                wareHouse.StockCount(x);
            }
            catch(ArgumentNullException ex)
            {
                StringAssert.Contains(ex.Message, "Item Name Null");
                return;
            }
            Assert.Fail();
        }
    }
}