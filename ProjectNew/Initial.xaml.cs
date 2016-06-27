using ProjectNew.Enums;
using ProjectNew.GraphicsOrganizer;
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
    /// Interaction logic for Initial.xaml
    /// </summary>
    public partial class Initial : Window
    {

        public Initial()
        {
            InitializeComponent();
            
        }
        public static Currency Currency { get; set; } = Currency.BG;
        private void Drag(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Application.Current.Shutdown();
        }

        private void buttonMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
   
        private void Date(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            DateBox.Text = date.ToString("ddMMyyyy");
        }

        private void CalcOpen(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            Calculator ex = new Calculator();
            ex.Show();
        }

        private void ShowAmount(object sender, EventArgs e)
        {
          
            decimal totalAmount = FileReader.GetUserTotalExpensesPrice();
            string stringAmount = totalAmount.ToString();
            if (totalAmount==0)
            {
                AmountBox.Text = stringAmount;
            }
            else
            {
                AmountBox.Text = stringAmount+ChooseCurrency();
            }
        }

        private void ResetButton(object sender, MouseButtonEventArgs e)
        {
            FileCleaner.Clear();
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
        public static string ChooseCurrency()
        {
            
            string currency = String.Empty;
            
                switch (Currency)
                {
                    case Currency.BG:
                        currency = "лв";
                        break;
                    case Currency.UK:
                        currency = "£";
                        break;
                    case Currency.EU:
                        currency = "€";
                        break;
                    default:
                        break;
                }
                return currency;          

        }

        private void OpenGraphics(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            Graphics graphicsWindow = new Graphics();
            graphicsWindow.Show();
        }       
    }
}
