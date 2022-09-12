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
        private string _description;
        private double _limit;
        private List<Payement> _payments;

        public string Name { get { return _name; } }
        public string Description { get { return _description; } }
        public double Limit { get { return _limit; } set { _limit = value; } }
        public List<Payement> Payments { get { return _payments; } set { _payments = value; } }

        public Category(string name, string description, double limit, List<Payement> payments)
        {
            _name = name;
            _description = description;
            _limit = limit;
            _payments = payments;
        }
    }
}
