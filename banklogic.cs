using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BankClasses
{
        public class Account
    {
        public int AccountNumber { get; set; }
        public string AccountOwner { get; set; }
        public decimal AccountBalance { get; set; }

        public Account(int accountNumber, string accountOwner, decimal initialBalance)
        {
          AccountNumber = accountNumber;
          AccountOwner = accountOwner;
          AccountBalance = initialBalance;
        }
            public void MakeDeposit(decimal amount, DateTime date, string note)
       {
           AccountBalance += amount;
       }

       public void MakeWithdrawls(decimal amount, DateTime date, string note)
       {
          if (amount > AccountBalance)
          {
             Console.WriteLine("Amount is greater than balance.");
          } 
          else
          {  
            AccountBalance -= amount;
          } 
       }
    }
}