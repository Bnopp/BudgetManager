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
using System.Text.RegularExpressions;

namespace BudgetManager.Windows
{
    /// <summary>
    /// Interaction logic for CategoryWindows.xaml
    /// </summary>
    public partial class CategoryWindows : Window
    {
        private string _name = "";
        private double _limit = 0;

        public string CatName { get { return _name; } }
        public double CatLimit { get { return _limit; } }

        public CategoryWindows()
        {
            InitializeComponent();
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _name = tbName.Text;
            _limit = Convert.ToDouble(tbLimit.Text);
            this.Close();
        }
    }
}
