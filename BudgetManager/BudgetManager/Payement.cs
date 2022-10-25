using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager
{
    public class Payement
    {
        private string _title;
        private double _amount;
        private string _category;
        private string _date;
        
        public string Title { get { return _title; } }
        public double Amount { get { return _amount; } }
        public string Category { get { return _category; } }
        public string Date { get { return _date; } }

        public Payement(string title, double amount, string category, string date)
        {
            _title = title;
            _amount = amount;
            _category = category;
            _date = date;
        }
    }
}
