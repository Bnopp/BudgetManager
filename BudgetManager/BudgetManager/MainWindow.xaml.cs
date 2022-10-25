using BudgetManager.Pages;
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

namespace BudgetManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Category catFood = new Category("Food", "Eating", 1000, new List<Payement>());

        public List<Payement> payements = new List<Payement>()
        {
            new Payement("McDonalds", 12.58, catFood.Name, DateTime.Now.ToShortDateString()),
            new Payement("V Poi", 12.58, catFood.Name, DateTime.Now.ToShortDateString()),
            new Payement("McDonalds", 12.58, catFood.Name, DateTime.Now.ToShortDateString()),
            new Payement("V Poi", 12.58, catFood.Name, DateTime.Now.ToShortDateString()),
            new Payement("V Poi", 12.58, catFood.Name, DateTime.Now.ToShortDateString()),
            new Payement("V Poi", 12.58, catFood.Name, DateTime.Now.ToShortDateString()),
            new Payement("McDonalds", 12.58, catFood.Name, DateTime.Now.ToShortDateString()),
            new Payement("V Poi", 12.58, catFood.Name, DateTime.Now.ToShortDateString()),
        };

        public List<Payement> Payements { get { return payements; } }

        public MainWindow()
        {
            InitializeComponent();

            HomePage homePage = new HomePage();
            homePage.dgPurchases.ItemsSource = payements;

            MainFrame.Navigate(homePage);
        }
    }
}
