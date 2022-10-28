using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BudgetManager.Windows
{
    /// <summary>
    /// Interaction logic for AddExpenseWindow.xaml
    /// </summary>
    public partial class AddExpenseWindow : Window
    {
        private string name;
        private double amount;
        private int catIndex;
        public bool close = false;

        public string Name { get { return name; } }
        public double Amount { get { return amount; } }
        public int CategoryIndex { get { return catIndex; } }

        public AddExpenseWindow()
        {
            InitializeComponent();

            foreach (Category c in (Application.Current.MainWindow as MainWindow).Categories)
            {
                cbCats.Items.Add(c.Name + " " + c.Limit + " CHF");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            close = true;
            name = tbName.Text;
            amount = Convert.ToDouble(tbAmount.Text);
            catIndex = cbCats.SelectedIndex;
            this.Close();
        }
    }
}
