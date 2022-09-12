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
        private Category _category;
        private DateTime _date;
        
        public string Title { get { return _title; } }
        public double Amount { get { return _amount; } }
        private Category Category { get { return _category; } }
        public DateTime Date { get { return _date; } }

        public Payement(string title, double amount, Category category, DateTime date)
        {
            _title = title;
            _amount = amount;
            _category = category;
            _date = date;
        }
    }
}
