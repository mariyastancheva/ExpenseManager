
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectNew.Models
{
   public class User
    { 
        
        public User()
        {     
            this.Expenses = new List<Expense>();
        }

      
        public List<Expense> Expenses { get; set; }
       

        public decimal FinalExpense
        {
            get
            {
                return this.Expenses
                    .Select(exp => exp.Price)
                    .Sum();
            }
        }

        public void AddExpense(Expense expense)
        {
            bool doesExist = false;


            foreach (var exp in this.Expenses)
            {
                if (exp.ExpenseType == expense.ExpenseType)
                {
                    doesExist = true;
                    exp.Price += expense.Price;
                }
            }

            if (!doesExist)
            {
                this.Expenses.Add(expense);
            }



        }
    }

   
}
