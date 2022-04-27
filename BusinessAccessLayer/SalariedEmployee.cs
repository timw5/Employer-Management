using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class SalariedEmployee : Employee
    {
        private decimal _weeklySalary;
        //readonly decimal Max_Salary = 1000000m;

        public SalariedEmployee() : base()
        {
        }

        public SalariedEmployee(string fname, string lname, string ssn, decimal weeklySalary)
            : base(fname, lname, ssn) {
            WeeklySalary = weeklySalary;
        }

        public decimal WeeklySalary {
            get { return _weeklySalary; }
            set {
                if (value < 0) {
                    throw new ArgumentOutOfRangeException("Weekly salary cannot be negative");
                }
                _weeklySalary = value;
            }
        }

        public override decimal Earning()
        {
            return WeeklySalary;
        }

        public override string ToString()
        {
            return base.ToString() + "Weekly Salary: " + WeeklySalary + "\n" + "Earning: " + Earning();
        }

        

    }
}
