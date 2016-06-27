
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNew.Models
{
    static class FileReader 
    {
        private static string filePath = Path.GetFullPath("DataBase.txt");


        public static List<string> GetUserExpenses()
        {
            string[] fileContent = File.ReadAllLines(filePath);
            List<string> expenses = new List<string>();
            for (int i = 0; i < fileContent.Length; i++)
            {
                string lineExpenses = fileContent[i].Split('/')[1];
                string[] expenseTypeAndPrice = lineExpenses.Split('|');
                for (int e = 0; e < expenseTypeAndPrice.Length; e++)
                {
                    expenses.Add(expenseTypeAndPrice[e]);
                }
            }
            return expenses;
        }
        public static decimal GetUserTotalExpensesPrice()
        {
            string[] fileLines = File.ReadAllLines(filePath);
            decimal totalAmount = 0;
            for (int i = 0; i < fileLines.Length; i++)
            {
                string amount = (string)fileLines[i].Split('/')[0];
                totalAmount += Convert.ToDecimal(amount);
            }
            return totalAmount;
        }


    }
}
