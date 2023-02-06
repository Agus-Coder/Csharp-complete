using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_bank
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name; // as my current understand, 'this' keyword is not strictly necessary
            this.Balance = initialBalance;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {

        }
    }
}
