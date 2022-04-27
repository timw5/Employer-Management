using System;
using System.Windows.Forms;

namespace BusinessAccessLayer
{
    public class BasePlusCommisionEmployee : CommisionEmployee
    {
        private decimal _baseSalary;
        public BasePlusCommisionEmployee() : base() { }

        public BasePlusCommisionEmployee(string fname, string lname, string ssn, decimal sales, decimal commision, decimal baseSalary)
            :base(fname,lname,ssn,sales,commision)
        {
            BaseSalary = baseSalary;
        }
        public decimal BaseSalary {
            get { return _baseSalary; }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("value cannot be negative");
                    }
                    _baseSalary = value;
                }
                catch(ArgumentException aex)
                {
                    MessageBox.Show(aex.Message + "\n Employee Not saved");
                    return;
                }
            }
        }

        public override decimal Earning()
        {
            return  base.Earning() + BaseSalary;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" + "Base Salary: " + BaseSalary;
        }
    }
}
