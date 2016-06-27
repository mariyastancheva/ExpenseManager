using ProjectNew.Enums;
using ProjectNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNew.GraphicsOrganizer
{
    public class Graphic
    {
        public static Dictionary<ExpenseType, decimal> ExpensesData { get; private set; } = new Dictionary<ExpenseType, decimal>()
        {
            { ExpenseType.Clothes, 0 },
            { ExpenseType.Cosmetic, 0 },
            {ExpenseType.Entertaiment, 0 },
            {ExpenseType.Food, 0 },
            {ExpenseType.Groceries, 0 },
            {ExpenseType.Medicine, 0 },
            {ExpenseType.Taxes, 0 },
            {ExpenseType.Transport, 0 }
        };
        public Graphic()
        {
            DeclareData();
        }

        public void DeclareData()
        {
            List<String> expenses = FileReader.GetUserExpenses();
           

            for (int i = 0; i < expenses.Count; i++)
            {
                if (expenses[i] != String.Empty)
                {
                    string type = expenses[i].Split(' ')[0];
                    ExpenseType expenseType = (ExpenseType)Enum.Parse(typeof(ExpenseType), type, true);
                    decimal amount = Convert.ToDecimal(expenses[i].Split(' ')[1]);
                    ExpensesData[expenseType] += amount;
                }

            }
          
        }

        public static decimal GetAmount(ExpenseType expensetype)
        {
            decimal amount = ExpensesData[expensetype];
            return amount;
        }

    }
}
