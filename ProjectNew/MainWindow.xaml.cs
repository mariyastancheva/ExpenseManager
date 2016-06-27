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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectNew
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();           
        }
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Initial initial = new Initial();
            initial.Show();
        }

        private void DateAndTime(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            DateBox.Text = date.ToString("dd.MM.yyyy HH:mm");
        }
    }
}
