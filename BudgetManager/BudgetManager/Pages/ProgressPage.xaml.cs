using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
    /// Interaction logic for ProgressPage.xaml
    /// </summary>
    public partial class ProgressPage : Page
    {
        MainWindow mw = (Application.Current.MainWindow as MainWindow);

        public ProgressPage()
        {
            InitializeComponent();

            if (mw.Categories.Count >= 1) 
            {
                double value = 0;

                foreach (Payement p in mw.Categories[0].Payments)
                {
                    value += p.Amount;
                }

                tbCat.Text = mw.Categories[0].Name + " " + value + "/" + mw.Categories[0].Limit + " CHF";

                pgCat.Value = value;
                pgCat.Maximum = mw.Categories[0].Limit;

                tbProCat.Text = Math.Round(pgCat.Value / pgCat.Maximum * 100) + "%";
            }
            if (mw.Categories.Count >= 2)
            {
                double value = 0;

                foreach (Payement p in mw.Categories[1].Payments)
                {
                    value += p.Amount;
                }

                tbCat1.Text = mw.Categories[1].Name + " " + value + "/" + mw.Categories[1].Limit + " CHF";

                pgCat1.Value = value;
                pgCat1.Maximum = mw.Categories[1].Limit;

                tbProCat1.Text = Math.Round(pgCat1.Value / pgCat1.Maximum * 100) + "%";

                spCat1.Visibility = Visibility.Visible;
            }
            if (mw.Categories.Count >= 3)
            {
                double value = 0;

                foreach (Payement p in mw.Categories[2].Payments)
                {
                    value += p.Amount;
                }

                tbCat2.Text = mw.Categories[2].Name + " " + value + "/" + mw.Categories[2].Limit + " CHF";

                pgCat2.Value = value;
                pgCat2.Maximum = mw.Categories[2].Limit;

                tbProCat2.Text = Math.Round(pgCat2.Value / pgCat2.Maximum * 100) + "%";

                spCat2.Visibility = Visibility.Visible;
            }
            if (mw.Categories.Count >= 4)
            {
                double value = 0;

                foreach (Payement p in mw.Categories[3].Payments)
                {
                    value += p.Amount;
                }

                tbCat3.Text = mw.Categories[3].Name + " " + value + "/" + mw.Categories[3].Limit + " CHF";

                pgCat3.Value = value;
                pgCat3.Maximum = mw.Categories[3].Limit;

                tbProCat3.Text = Math.Round(pgCat3.Value / pgCat3.Maximum * 100) + "%";

                spCat3.Visibility = Visibility.Visible;
            }
            if (mw.Categories.Count >= 5)
            {
                double value = 0;

                foreach (Payement p in mw.Categories[4].Payments)
                {
                    value += p.Amount;
                }

                tbCat4.Text = mw.Categories[4].Name + " " + value + "/" + mw.Categories[4].Limit + " CHF";

                pgCat4.Value = value;
                pgCat4.Maximum = mw.Categories[4].Limit;

                tbProCat4.Text = Math.Round(pgCat4.Value / pgCat4.Maximum * 100) + "%";

                spCat4.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).MainFrame.Navigate(new HomePage());
        }
    }
}
