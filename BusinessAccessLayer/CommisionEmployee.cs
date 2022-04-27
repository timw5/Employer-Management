using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class CommisionEmployee : Employee
    {
        private decimal _grossSales;
        private decimal _commisionRate;

        public CommisionEmployee() : base() { }
        public CommisionEmployee(string fname, string lname, string ssn, decimal sales, decimal commision)
            : base(fname, lname, ssn)
        {
            CommisionRate = commision;
            GrossSales = sales;
        }
        public decimal GrossSales {
            get { return _grossSales; }
            set
            {
                if (value < 0) {
                    throw new ArgumentOutOfRangeException("Sales cannot be negative");
                }
                _grossSales = value;
            }
        }
        public decimal CommisionRate
        {
            get { return _commisionRate; }
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException("Sales cannot be negative");
                }
                _commisionRate = value;
            }
        }

        public override decimal Earning()
        {
            return CommisionRate * GrossSales;
        }

        public override string ToString()
        {
            return base.ToString() + "Commision Rate: " + CommisionRate + "\n" + "Gross Sales: " + GrossSales + "\n" + "Earning: " + Earning();
        }

    }
}
