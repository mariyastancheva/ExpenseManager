using ProjectNew.Enums;
using ProjectNew.Models;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjectNew
{
    /// <summary>
    /// Interaction logic for Example.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        public decimal Amount { get; set; }
        public ExpenseType ExpenseType { get; set; } 
        public List<Expense> Expenses { get; set; }
        public User User { get; set; }

        
        public Calculator()
        {
            InitializeComponent();
            this.User = new User();
            this.ExpenseType = new ExpenseType();            
        }
        private void Drag(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        private void DateT(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            DateB1.Text = date.ToString("dd.MM.yyyy HH:mm");

        }

        private void buttonMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Application.Current.Shutdown();
        }

        private void undo_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Initial i = new Initial();
            i.Show();
        }

        private void Click0(object sender, RoutedEventArgs e)
        {
            this.AmountBox.Text += "0";
        }

        private void Click1(object sender, RoutedEventArgs e)
        {
            this.AmountBox.Text += "1";
        }

        private void Click2(object sender, RoutedEventArgs e)
        {
            this.AmountBox.Text += "2";
        }

        private void Click3(object sender, RoutedEventArgs e)
        {
            this.AmountBox.Text += "3";
        }

        private void Click4(object sender, RoutedEventArgs e)
        {
            this.AmountBox.Text += "4";
        }

        private void Click5(object sender, RoutedEventArgs e)
        {
            this.AmountBox.Text += "5";
        }

        private void Click6(object sender, RoutedEventArgs e)
        {
            this.AmountBox.Text += "6";
        }

        private void Click7(object sender, RoutedEventArgs e)
        {
            this.AmountBox.Text += "7";
        }

        private void Click8(object sender, RoutedEventArgs e)
        {
            this.AmountBox.Text += "8";
        }

        private void Click9(object sender, RoutedEventArgs e)
        {
            this.AmountBox.Text += "9";
        }

        private void ClickComma(object sender, RoutedEventArgs e)
        {
            this.AmountBox.Text += ",";
        }

        private void ClickPlus(object sender, RoutedEventArgs e)
        {
            string text=this.AmountBox.Text;

            this.Amount = Convert.ToDecimal(text);          
            
            if (ExpenseType==0)
            {
                MessageBox.Show("You should pick an expence type.");
            }
            else
            {
                User.AddExpense(new Expense(this.ExpenseType, this.Amount));
            }
    
            this.AmountBox.Text = "";
        }

        private void Entertainment(object sender, MouseButtonEventArgs e)
        {
            this.ExpenseType = ExpenseType.Entertaiment;          
        }

        private void Clothes(object sender, MouseButtonEventArgs e)
        {
            this.ExpenseType = ExpenseType.Clothes;
        }

        private void Cosmetics(object sender, MouseButtonEventArgs e)
        {
            this.ExpenseType = ExpenseType.Cosmetic;
        }

        private void Groceries(object sender, MouseButtonEventArgs e)
        {
            this.ExpenseType = ExpenseType.Groceries;
        }

        private void Medicine(object sender, MouseButtonEventArgs e)
        {
            this.ExpenseType = ExpenseType.Medicine;  
        }

        private void Taxes(object sender, MouseButtonEventArgs e)
        {
            this.ExpenseType = ExpenseType.Taxes;
        }

        private void Food(object sender, MouseButtonEventArgs e)
        {
            this.ExpenseType = ExpenseType.Food;
        }

        private void Transport(object sender, MouseButtonEventArgs e)
        {
            this.ExpenseType = ExpenseType.Transport;
        }
        private void Calculate(object sender, RoutedEventArgs e)
        {
            string text = this.AmountBox.Text;

            if (text == String.Empty)
            {
                FileWriter.Write(User);
                this.Hide();
                Initial initial = new Initial();
                initial.Show();
            }
            else
            {
                this.Amount = Convert.ToDecimal(text);

                if (ExpenseType == 0)
                {
                    MessageBox.Show("You should pick an expence type.");
                }
                if (Initial.Currency == 0)
                {
                    MessageBox.Show("You should pick a currency.");
                }
                else
                {
                    User.AddExpense(new Expense(this.ExpenseType, this.Amount));
                }


                FileWriter.Write(User);
                this.Hide();
                Initial i = new Initial();
                i.Show();
            }
               
        }

        private void BGcurrency(object sender, MouseButtonEventArgs e)
        {
           Initial.Currency = Currency.BG;
        }

        private void EUcurrency(object sender, MouseButtonEventArgs e)
        {
            Initial.Currency = Currency.EU;
        }

        private void UKcurrency(object sender, MouseButtonEventArgs e)
        {
            Initial.Currency = Currency.UK;
        }
    }
}
