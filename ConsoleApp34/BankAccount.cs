using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    internal class BankAccount
    {
        private int _balance;

        public void SetInitialBalance (int balance)
        {
            _balance = balance;
        }
        public void Deposit (int deposit)
        {
            _balance += deposit;
        }

        public void Withdraw (int withdraw)
        {
            _balance -= withdraw;
        }

        public int GetBalance ()
        {
            return _balance;
        }
        
    }   
}
