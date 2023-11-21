using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Tests
{
    [TestClass()]
    public class BankCustomerTests
    {
        [TestMethod()]
        public void RemoveAccount_IfDoesntRemovesAccount_ThrowException()
        {
            string CustomerName = "Walter White";
            double balance = 0;
            List<BankAccount> CustomerAccounts = new List<BankAccount>();
            BankCustomer Customer = new BankCustomer(CustomerName,CustomerAccounts);
            BankAccount account = new BankAccount(CustomerName, balance);
            try
            {
                Customer.RemoveAccount(account);
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "Bank account does not exist");
                return;
            }
            Assert.Fail("idk");
        }
        [TestMethod()]
        public void AddAccount_IfDoesntAddAccount_ThrowException()
        {
            string CustomerName = "Walter White";
            double balance = 0;
            List<BankAccount> CustomerAccounts = new List<BankAccount>();
            BankCustomer Customer = new BankCustomer(CustomerName, CustomerAccounts);
            BankAccount account = new BankAccount(CustomerName, balance);
            try
            {
                Customer.AddAccount(account);
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "Account Was not added for some reason");
                return;
            }
            Assert.Fail("Exception was not thrown");
        }
        [TestMethod()]
        public void TranferMoney_IfDoesntTransferMoney_ThrowException()
        {
            string CustomerName = "Walter White";
            double balance = 20;
            string CustomerName2 = "mutsis";
            double balance2 = 0;
            double TransferAmount = 10;
            List<BankAccount> CustomerAccounts = new List<BankAccount>();
            BankCustomer Customer = new BankCustomer(CustomerName, CustomerAccounts);
            BankAccount account2 = new BankAccount(CustomerName2,balance2);
            BankAccount account = new BankAccount(CustomerName, balance);
            //CustomerAccounts.Add(account);
            try
            {
                Customer.TransferMoney(CustomerAccounts,account,account2,TransferAmount);
                
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "not your account");
                return;
            }
            Assert.Fail("Something Went Wrong");
        }
        [TestMethod()]
        public void TransferMoney_IfTransferAmountIsLessThanZero_ThrowException()
        {
            string CustomerName = "Walter White";
            double balance = 20;
            string CustomerName2 = "mutsis";
            double balance2 = 0;
            double TransferAmount = 10;
            List<BankAccount> CustomerAccounts = new List<BankAccount>();
            BankCustomer Customer = new BankCustomer(CustomerName, CustomerAccounts);
            BankAccount account2 = new BankAccount(CustomerName2, balance2);
            BankAccount account = new BankAccount(CustomerName, balance);
            CustomerAccounts.Add(account);
            try
            {
                Customer.TransferMoney(CustomerAccounts,account,account2,TransferAmount);
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "amount is less than zero");
                return;
            }
            Assert.Fail("Something went wrong");
        }
        [TestMethod]
        public void TransferMoney_IfBlanceIsLessThanZero_ThrowException()
        {
            string CustomerName = "Walter White";
            double balance = 20;
            string CustomerName2 = "mutsis";
            double balance2 = 0;
            double TransferAmount = 10;
            List<BankAccount> CustomerAccounts = new List<BankAccount>();
            BankCustomer Customer = new BankCustomer(CustomerName, CustomerAccounts);
            BankAccount account2 = new BankAccount(CustomerName2, balance2);
            BankAccount account = new BankAccount(CustomerName, balance);
            CustomerAccounts.Add(account);
            try
            {
                Customer.TransferMoney(CustomerAccounts, account, account2, TransferAmount);
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "Balance is less than zero");
                return;
            }
            Assert.Fail("Something went wrong");
        }
        [TestMethod]
        public void BankCustomerTest()
        {
            bool Exception = false;
            double TransferAmount = 10;
            List<BankAccount> CustomerAccounts = new List<BankAccount>();
            BankCustomer customer2 = new BankCustomer("mutsis", CustomerAccounts);
            BankAccount account2 = new BankAccount("mutsis", 2);
            BankCustomer customer = new BankCustomer("Walter White", CustomerAccounts);
            BankAccount account = new BankAccount("Walter White", 20);
            try
            {
                customer.AddAccount(account);
                customer2.AddAccount(account2);
                customer.TransferMoney(CustomerAccounts,account, account2, TransferAmount);
                customer.RemoveAccount(account);
                

            }
            catch (Exception e)
            {
                Exception = true;
                Assert.IsTrue(Exception);
                return;
            }
            Assert.Fail("something went wrong");
            
        }
    }
    
}