using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public abstract class Employee : IPayable 
    {
        
        public string FirstName { get; }
        public string LastName { get; }
        public string SSN { get; }

        public Employee() { }
        public Employee(string fname, string lname, string ssn) {
            FirstName = fname;
            LastName = lname;
            SSN = ssn;
        }

        public override string ToString()
        {
            return "Name: " + FirstName + " " + LastName + "\n" + "SSN: " + SSN + "\n";
        }

        public abstract decimal Earning();

        public decimal GetPaymentAmount()
        {
            return Earning();
        }

        public void SaveEmployee(string deptName, string empType, string state, string city, int zip, DateTime bday, DateTime joinedDate, bool married, string addressl1, string addressl2)
        {

            if(this is SalariedEmployee)             
                Utility.SaveEmployee(this.FirstName, this.LastName, this.SSN, deptName, ((SalariedEmployee)this).WeeklySalary, 0, 0, "Salary", state, city, zip, bday, joinedDate, married, addressl1, addressl2);
                                                                                  
            else if (this is BasePlusCommisionEmployee)                           
                Utility.SaveEmployee(this.FirstName, this.LastName, this.SSN, deptName, ((BasePlusCommisionEmployee)this).BaseSalary, ((BasePlusCommisionEmployee)this).CommisionRate, ((BasePlusCommisionEmployee)this).GrossSales, "Base Plus Commission", state, city, zip, bday, joinedDate, married, addressl1, addressl2);
                                                                                  
            else if (this is CommisionEmployee)                                   
                Utility.SaveEmployee(this.FirstName, this.LastName, this.SSN, deptName, 0, ((CommisionEmployee)this).CommisionRate, ((CommisionEmployee)this).GrossSales, "Commission", state, city, zip, bday, joinedDate, married, addressl1, addressl2);
        }

        public void DeleteEmployee(int EmpID)
        {
            Utility.DeleteEmployee(EmpID);
        }
        

        
    }
}
