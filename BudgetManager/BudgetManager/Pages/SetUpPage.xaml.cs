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
using BudgetManager.Windows;

namespace BudgetManager.Pages
{

    /// <summary>
    /// Interaction logic for SetUpPage.xaml
    /// </summary>
    public partial class SetUpPage : Page
    {
        private MainWindow mw = Application.Current.MainWindow as MainWindow;

        public SetUpPage()
        {
            InitializeComponent();
            
            LoadCategories();
        }

        private void LoadCategories()
        {
            gCreatedCatsName.Children.Clear();
            gCreatedCatsLimit.Children.Clear();

            var counter = 0;
            foreach (Category cat in mw.Categories)
            {
                TextBlock tbName = new TextBlock()
                {
                    Text = cat.Name
                };
                TextBlock tbLimit = new TextBlock()
                {
                    Text = cat.Limit.ToString() + " CHF"
                };

                gCreatedCatsName.Children.Add(tbName);
                tbName.SetValue(Grid.RowProperty, counter);
                gCreatedCatsLimit.Children.Add(tbLimit);
                tbLimit.SetValue(Grid.RowProperty, counter);
                counter++;
            }
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (mw.Categories.Count < 5)
            {
                CategoryWindows cw = new CategoryWindows();
                cw.ShowDialog();
                if (cw.CatName != " ")
                {
                    Category newCat = new Category(cw.CatName, cw.CatLimit);
                    (Application.Current.MainWindow as MainWindow).Categories.Add(newCat);
                    LoadCategories();
                }
            }
            else
                MessageBox.Show("You have reached the category limit of 5");
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if ((Application.Current.MainWindow as MainWindow).Categories.Count > 1)
            {
                DeleteCategoryWindow dcw = new DeleteCategoryWindow((Application.Current.MainWindow as MainWindow).Categories);
                dcw.ShowDialog();
                if (dcw.DeletedIndex != -1)
                {
                    (Application.Current.MainWindow as MainWindow).Categories.Remove((Application.Current.MainWindow as MainWindow).Categories[dcw.DeletedIndex]);
                }
                LoadCategories();
            }
            else
            {
                MessageBox.Show("You must have at least one existant category at all times");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).MainFrame.Navigate(new HomePage());
        }
    }
}