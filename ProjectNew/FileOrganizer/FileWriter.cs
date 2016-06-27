
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNew.Models
{
   public static class FileWriter
    {
        private static string filePath = Path.GetFullPath("DataBase.txt");

        public static void Write(User user)
        {
            string finalExpense = user.FinalExpense.ToString();
            string userExpenses = String.Join("|", user.Expenses);
            string text = finalExpense + "/" + userExpenses;
            File.AppendAllText(filePath,text + Environment.NewLine);
           
        }
    }
}
