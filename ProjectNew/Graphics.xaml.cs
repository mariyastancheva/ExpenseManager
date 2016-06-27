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
    /// Interaction logic for Graphics.xaml
    /// </summary>
    public partial class Graphics : Window
    {        
        public Graphics()
        {
            InitializeComponent();
            Graphic graphic = new Graphic();         

        }
        private void Drag(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ClickExit(object sender, RoutedEventArgs e)
        {
            this.Close();
            Application.Current.Shutdown();
        }

        private void ClickMinimize(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void UndoClick(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Initial i = new Initial();
            i.Show();
        }

        private void ProgressiveBars(object sender, RoutedEventArgs e)
        {
            double maximum = Convert.ToDouble(FileReader.GetUserTotalExpensesPrice());

            ClothesBar.Maximum = maximum;
            this.ClothesBar.Value = Convert.ToDouble(Graphic.GetAmount(ExpenseType.Clothes));
            this.clothesMoney.Text = Convert.ToString(Graphic.GetAmount(ExpenseType.Clothes)) + Initial.ChooseCurrency();

            barEntertainment.Maximum = maximum;
            this.barEntertainment.Value = Convert.ToDouble(Graphic.GetAmount(ExpenseType.Entertaiment));
            this.entertainmentMoney.Text = Convert.ToString(Graphic.GetAmount(ExpenseType.Entertaiment)) + Initial.ChooseCurrency();


            barCosmetics.Maximum = maximum;
            this.barCosmetics.Value = Convert.ToDouble(Graphic.GetAmount(ExpenseType.Cosmetic));
            this.cosmeticsMoney.Text = Convert.ToString(Graphic.GetAmount(ExpenseType.Cosmetic)) + Initial.ChooseCurrency();

            barMedicine.Maximum = maximum;
            this.barMedicine.Value = Convert.ToDouble(Graphic.GetAmount(ExpenseType.Medicine));
            this.medicineMoney.Text = Convert.ToString(Graphic.GetAmount(ExpenseType.Medicine)) + Initial.ChooseCurrency();

            barHousehold.Maximum = maximum;
            this.barHousehold.Value = Convert.ToDouble(Graphic.GetAmount(ExpenseType.Groceries));
            this.householdMoney.Text = Convert.ToString(Graphic.GetAmount(ExpenseType.Groceries)) + Initial.ChooseCurrency();

            barFood.Maximum = maximum;
            this.barFood.Value = Convert.ToDouble(Graphic.GetAmount(ExpenseType.Food));
            this.foodMoney.Text = Convert.ToString(Graphic.GetAmount(ExpenseType.Food)) + Initial.ChooseCurrency();

            barTransport.Maximum = maximum;
            this.barTransport.Value = Convert.ToDouble(Graphic.GetAmount(ExpenseType.Transport));
            this.transportMoney.Text = Convert.ToString(Graphic.GetAmount(ExpenseType.Transport)) + Initial.ChooseCurrency();

            barTaxes.Maximum = maximum;
            this.barTaxes.Value = Convert.ToDouble(Graphic.GetAmount(ExpenseType.Taxes));
            this.taxesMoney.Text = Convert.ToString(Graphic.GetAmount(ExpenseType.Taxes)) + Initial.ChooseCurrency();

        }
    }
}
