using BudgetManager.Pages;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using System.Xml.Serialization;

namespace BudgetManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string _DefaultDatapath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\BudgetManager";
        public const string CatsFile = @"\budgetDataCategories.json";
        public const string PayementsFile = @"\budgetDataPayements.json";

        private static List<Category> categories = new List<Category>() 
        {
            new Category("General", 1000)
        };

        private List<Payement> payements = new List<Payement>()
        {
        };

        public List<Category> Categories { get { return categories; } set { categories = value; } }
        public List<Payement> Payements { get { return payements; } set { payements = value; } }

        public MainWindow()
        {
            InitializeComponent();

            if (!Directory.Exists(_DefaultDatapath))
            {
                Directory.CreateDirectory(_DefaultDatapath);
            }

            if (File.Exists(_DefaultDatapath + CatsFile))
            {
                Categories = ReadFromJsonFile<List<Category>>(_DefaultDatapath + CatsFile);
            }
            if (File.Exists(_DefaultDatapath + PayementsFile))
            {
                Payements = ReadFromJsonFile<List<Payement>>(_DefaultDatapath + PayementsFile);
            }

            MainFrame.Navigate(new HomePage());
        }

        public static void WriteToJsonFile<T>(string filePath, T objectToWrite, bool append = false) where T : new()
        {
            TextWriter writer = null;
            try
            {
                var contentsToWriteToFile = JsonConvert.SerializeObject(objectToWrite);
                writer = new StreamWriter(filePath, append);
                writer.Write(contentsToWriteToFile);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        public static T ReadFromJsonFile<T>(string filePath) where T : new()
        {
            TextReader reader = null;
            try
            {
                reader = new StreamReader(filePath);
                var fileContents = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(fileContents);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            WriteToJsonFile(_DefaultDatapath + CatsFile, Categories, false);
            WriteToJsonFile(_DefaultDatapath + PayementsFile, Payements, false);
            this.Close();
        }
    }
}
