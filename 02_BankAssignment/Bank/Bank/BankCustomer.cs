using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{

    public class BankCustomer
    {
        private string CustomerName;
        public static List<BankAccount> CustomerAccounts = new List<BankAccount>();
       

        public BankCustomer(string CustomerName, List<BankAccount> CustomerAccount)
        {
            CustomerName = CustomerName;
            CustomerAccount = CustomerAccount;
        }
        public static void Main()
        {
            BankCustomer Customer = new BankCustomer("Walter White", CustomerAccounts);
        }
        public  void RemoveAccount(BankAccount account) 
        {
            if (!CustomerAccounts.Contains(account))
            {
                throw new Exception("Bank account does not exist");
            }
            CustomerAccounts.Remove(account);
        }
        public void AddAccount(BankAccount account)
        {
            CustomerAccounts.Add(account);
            if(!CustomerAccounts.Contains(account)) 
            {
                throw new Exception("Account Was not added for some reason");
            }
        }
        public void TransferMoney(List<BankAccount> CustomerAccounts, BankAccount acc1, BankAccount acc2, double amount)
        {
            if(!CustomerAccounts.Contains(acc1))
            {
                throw new Exception("not your account");
            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount is less than zero");
            }
            if(acc1.Balance < amount)
            {
                throw new ArgumentOutOfRangeException("Balance is less than zero");
            }
            acc1.m_balance -= amount;
            acc2.m_balance += amount;
        }
    }
}
