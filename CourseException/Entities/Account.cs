using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseException.Entities.Exceptions;

namespace CourseException.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DominionException("The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new DominionException("Not enough balance");
            }

            Balance -= amount;
        }
    }
}
