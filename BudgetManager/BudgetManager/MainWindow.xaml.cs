using BudgetManager.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon.Primitives;
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

        private static List<Category> categories = new List<Category>() 
        {
            new Category("Food", 1000),
            new Category("Games", 1000),
            new Category("Going Out", 1000),
            new Category("Drinks", 1000)
        };

        private List<Payement> payements = new List<Payement>()
        {
            new Payement("McDonalds", 12.58, categories[0].Name, DateTime.Now.ToShortDateString()),
            new Payement("V Poi", 12.58, categories[0].Name, DateTime.Now.ToShortDateString()),
            new Payement("McDonalds", 12.58, categories[0].Name, DateTime.Now.ToShortDateString()),
            new Payement("V Poi", 12.58, categories[0].Name, DateTime.Now.ToShortDateString()),
            new Payement("V Poi", 12.58, categories[0].Name, DateTime.Now.ToShortDateString()),
            new Payement("V Poi", 12.58, categories[0].Name, DateTime.Now.ToShortDateString()),
            new Payement("McDonalds", 12.58, categories[0].Name, DateTime.Now.ToShortDateString()),
            new Payement("V Poi", 12.58, categories[0].Name, DateTime.Now.ToShortDateString()),
        };

        public List<Category> Categories { get { return categories; } set { categories = value; } }
        public List<Payement> Payements { get { return payements; } set { payements = value; } }

        public MainWindow()
        {
            InitializeComponent();

            //MainFrame.Navigate(new homePage());
            MainFrame.Navigate(new SetUpPage());
        }
    }
}
