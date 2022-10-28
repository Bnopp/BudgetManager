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
        
        public string Title { get { return _title; } set { _title = value; } }
        public double Amount { get { return _amount; } set { _amount = value; } }
        public string Category { get { return _category; } set { _category = value; } }
        public string Date { get { return _date; } set { _date = value; } }

        public Payement()
        {

        }

        public Payement(string title, double amount, string category, string date)
        {
            _title = title;
            _amount = amount;
            _category = category;
            _date = date;
        }
    }
}
