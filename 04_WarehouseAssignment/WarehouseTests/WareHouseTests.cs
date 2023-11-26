using Microsoft.VisualStudio.TestTools.UnitTesting;
using WareHouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse;

namespace WareHouse.Tests
{
    [TestClass()]
    public class WareHouseTests
    {
        private List<Stock> _stockOfItems;
        
        [TestMethod()]
        public void AddToStock_IfItemInStockAlready_ThrowException()
        {
            WareHouse wareHouse = new();
            try
            {
                
                wareHouse.AddToStocks("hat", 2);
                wareHouse.AddToStocks("hat2", 2);
            }
            catch (ArgumentException ex)
            {
                StringAssert.Contains(ex.Message, "stock is already in list");
                return;
            }
            Assert.Fail();
        }
        [TestMethod()]
        public void TakeFromStock_IfItemNotInStock_ThrowException()
        {
            WareHouse wareHouse = new();
            _stockOfItems = new();
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
        public void StockCount_IfItemNameIsNull_ThrowException()
        {
            WareHouse wareHouse = new();
            _stockOfItems = new();
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