using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager
{
    public class Category
    {
        private string _name;
        private double _limit;
        private List<Payement> _payments = new List<Payement>();

        public string Name { get { return _name; } }
        public double Limit { get { return _limit; } set { _limit = value; } }
        public List<Payement> Payments { get { return _payments; } set { _payments = value; } }

        public Category(string name, double limit)
        {
            _name = name;
            _limit = limit;
        }
    }
}
