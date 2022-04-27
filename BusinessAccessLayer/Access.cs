using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class Access
    {

        public static DataTable GetDepartments()
        {
            return Utility.GetDepartments();
        }

        public static DataTable GetDepartments(string SearchParam)
        {
            return Utility.GetDepartments(SearchParam);
        }

        public static void DeleteDept(int deptID)
        {
            Utility.DeleteDept(deptID);
        }
        public static void QuickEditDept(int empID, string deptName)
        {
            Utility.QuickEditDept(empID, deptName);
        }
        public static void EditDept(int deptID, string deptName, string deptContactName, string deptContactPhone, string deptLocation)
        {
            Utility.EditDept(deptID, deptName, deptContactName, deptContactPhone, deptLocation);
        }








        public static DataTable GetEmployees()
        {
            return Utility.GetEmployees();
        }

        public static Task<DataTable> GetEmployees(string searchParam)
        {
            Task<DataTable> x = Task.Run(() =>Utility.GetEmployees(searchParam));

            return x;
        }

        public static void DeleteEmployee(int empID)
        {
            Utility.DeleteEmployee(empID);
        }

        public static void QuickEditEmployee(int empID, string ssn, string fname, string lname)
        {
            Utility.QuickEditEmployee(empID, ssn, fname, lname);
        }

        public static void EditEmployee(int empID, string lname, string fname,string type, bool married, string salary, string commissionRate, string sales, string department, string address1, string address2, string State, DateTime bday, DateTime DateJoined, string ssn,  string city, int zip)
        {
            Utility.EditEmployee(empID, lname, fname, type, married, salary, commissionRate, sales, department, address1, address2, State, bday, DateJoined, ssn, city, zip);
        }

    }
}
