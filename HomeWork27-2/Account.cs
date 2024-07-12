using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork27_2
{
    public class Account
    {
        private decimal expense;
        private int pin=1111;

        public Account(decimal expense, int pIn)
        {
            this.expense = expense;
            this.pin = pIn;
        }
        public Account()
        {
        }
        public decimal GetExpense() => this.expense;
        public int GetpIn() => this.pin;
        public decimal AddExpense(decimal sum) => this.expense += sum;
        public decimal SubExpense(decimal sum)
        {
            if (this.expense >= sum)
                return this.expense -= sum;
            else return -1;

        }
    }
}
