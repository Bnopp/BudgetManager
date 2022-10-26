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

namespace BudgetManager.Windows
{
    /// <summary>
    /// Interaction logic for DeleteCategoryWindow.xaml
    /// </summary>
    public partial class DeleteCategoryWindow : Window
    {
        private int deletedIndex = -1;

        public int DeletedIndex { get { return deletedIndex; } }

        public DeleteCategoryWindow(List<Category> cats)
        {
            InitializeComponent();
            
            if (cats.Count > 0)
            {
                foreach (Category c in cats)
                {
                    cbCats.Items.Add(c.Name + " " + c.Limit + " CHF");
                }
                cbCats.SelectedIndex = 0;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            deletedIndex = cbCats.SelectedIndex;
            this.Close();
        }
    }
}
