using ProjectNew.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNew.Models
{
   public class Expense
    {
        public Expense(ExpenseType expenseType, decimal price)
        {
            this.ExpenseType = expenseType;
            this.Price = price;
        }

        public ExpenseType ExpenseType { get; private set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            string str = this.ExpenseType + " " + this.Price;
            return str;
        }
    }
}
