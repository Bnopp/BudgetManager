using BudgetManager.Windows;
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

namespace BudgetManager.Pages
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();

            dgPurchases.ItemsSource = (Application.Current.MainWindow as MainWindow).Payements;

            double totalLimit = 0;
            foreach (Category c in (Application.Current.MainWindow as MainWindow).Categories)
            {
                totalLimit += c.Limit;
            }

            GeneralPG.Maximum = totalLimit;

            double used = 0;
            foreach (Payement p in (Application.Current.MainWindow as MainWindow).Payements)
            {
                used += p.Amount;
            }
            GeneralPG.Value = used;

            tbProgress.Text = Convert.ToString(Math.Round(GeneralPG.Value / GeneralPG.Maximum * 100)) + "%";
            tbGenProgress.Text = Convert.ToString(Math.Round(GeneralPG.Value,2) + " / " + GeneralPG.Maximum + " CHF");
        }

        private void SetupButton_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).MainFrame.Navigate(new SetUpPage());
        }

        private void AddExpenseButton_Click(object sender, RoutedEventArgs e)
        {
            AddExpenseWindow aew = new AddExpenseWindow();
            aew.ShowDialog();
            if (aew.close)
            {
                Payement p = new Payement(aew.Name, aew.Amount, (Application.Current.MainWindow as MainWindow).Categories[aew.CategoryIndex].Name, DateTime.Now.ToShortDateString());
                (Application.Current.MainWindow as MainWindow).Payements.Add(p);
                (Application.Current.MainWindow as MainWindow).Categories[aew.CategoryIndex].Payments.Add(p);

                List<Payement> l = new List<Payement>();
                foreach (Payement i in (Application.Current.MainWindow as MainWindow).Payements)
                {
                    l.Add(i);
                }
                l.Reverse();
                dgPurchases.ItemsSource = l;
                dgPurchases.Items.Refresh();

                GeneralPG.Value += p.Amount;

                tbProgress.Text = Convert.ToString(Math.Round(GeneralPG.Value / GeneralPG.Maximum * 100)) + "%";
                tbGenProgress.Text = Convert.ToString(GeneralPG.Value + " / " + GeneralPG.Maximum + " CHF");
            }
        }

        private void ProgressButton_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).MainFrame.Navigate(new ProgressPage());
        }
    }
}
