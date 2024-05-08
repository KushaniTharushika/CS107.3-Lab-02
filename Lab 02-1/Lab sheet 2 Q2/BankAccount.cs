using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_sheet_2_Q2
{
    internal class BankAccount
    {
        public int AccountNumber {  get; set; }
        public double Balance { get; set; }

        public void deposit(double amount)
        {
            Balance = Balance + amount;
        }
    }
}
