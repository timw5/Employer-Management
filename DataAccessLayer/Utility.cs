using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public static class Utility
    {
        public static Data.DepartmentsDataTable GetDepartments()
        {
            Data.DepartmentsDataTable dtDeptTable = new Data.DepartmentsDataTable();
            DataTableAdapters.DepartmentsTableAdapter deptAdapter = new DataTableAdapters.DepartmentsTableAdapter();
            deptAdapter.Fill(dtDeptTable);

            return dtDeptTable;
        }

        public static DataTable GetDepartments(string searchParam)
        {
            DataTable dtDeptTable = new Data.DepartmentsDataTable();
            DataView dvDept = new DataView();
            DataTableAdapters.DepartmentsTableAdapter dptAdapter = new DataTableAdapters.DepartmentsTableAdapter();
            dptAdapter.Fill((Data.DepartmentsDataTable)dtDeptTable);
            try
            {
                dvDept = dtDeptTable.AsDataView();
                string filter = $"(DeptName LIKE'%{searchParam}%') OR " +
                                $"(Location LIKE'%{searchParam}%') OR " +
                                $"(ContactName LIKE'%{searchParam}%') OR " +
                                $"(ContactPhone LIKE'%{searchParam}%')";
                dvDept.RowFilter = filter;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Sorry, Unexpected Error");
            }
            dtDeptTable = dvDept.ToTable();
            return dtDeptTable;


        }
        public static void EditDept(int deptID, string deptName, string deptContactName, string deptContactPhone, string deptLocation)
        {
            Data.DepartmentsDataTable dtdept = new Data.DepartmentsDataTable();
            DataTableAdapters.DepartmentsTableAdapter dptAdapter = new DataTableAdapters.DepartmentsTableAdapter();
            dptAdapter.Fill(dtdept);
            Data.DepartmentsRow row;

            row = dtdept.Where(x => x.DeptID == deptID).SingleOrDefault();
            row.DeptName = deptName;
            row.ContactName = deptContactName;
            row.ContactPhone = deptContactPhone;
            row.Location = deptLocation;
            dptAdapter.Update(dtdept);
        }
        public static void QuickEditDept(int deptID, string deptName)
        {
            Data.DepartmentsDataTable dtdept = new Data.DepartmentsDataTable();
            DataTableAdapters.DepartmentsTableAdapter dptAdapter = new DataTableAdapters.DepartmentsTableAdapter();
            dptAdapter.Fill(dtdept);
            Data.DepartmentsRow row;

            row = dtdept.Where(x => x.DeptID == deptID).SingleOrDefault();
            row.DeptName = deptName;
            dptAdapter.Update(dtdept);
        }

        public static void SaveDept(string deptName, string location, string contactName, string contactPhone)
        {
            Data.DepartmentsDataTable dtdept = new Data.DepartmentsDataTable();
            DataTableAdapters.DepartmentsTableAdapter dptAdapter = new DataTableAdapters.DepartmentsTableAdapter();
            dptAdapter.Fill(dtdept);
            Data.DepartmentsRow newrow = dtdept.NewDepartmentsRow();

            newrow.DeptName = deptName;
            newrow.Location = location;
            newrow.ContactName = contactName;
            newrow.ContactPhone = contactPhone;

            dtdept.AddDepartmentsRow(newrow);
            dptAdapter.Update(dtdept);
        }

        public static void DeleteDept(int deptID)
        {
            Data.DepartmentsDataTable dtdept = new Data.DepartmentsDataTable();
            DataTableAdapters.DepartmentsTableAdapter dptAdapter = new DataTableAdapters.DepartmentsTableAdapter();
            dptAdapter.Fill(dtdept);
            Data.DepartmentsRow row;
            row = dtdept.Where(x => x.DeptID == deptID).SingleOrDefault();
            dptAdapter.Delete(row.DeptID, row.DeptName, row.Location, row.ContactName, row.ContactPhone);
            dtdept.AcceptChanges();

        }


        public static DataTable GetEmployees()
        {
            DataTable dtEmployeesTable = new Data.EmployeesDataTable();
            DataTableAdapters.EmployeesTableAdapter empAdapter = new DataTableAdapters.EmployeesTableAdapter();
            empAdapter.Fill((Data.EmployeesDataTable)dtEmployeesTable);

            return dtEmployeesTable;
        }

        public static DataTable GetEmployees(string searchParam)
        {
            DataTable dtEmployeesTable = new Data.EmployeesDataTable();
            DataView dv = new DataView();
            DataTableAdapters.EmployeesTableAdapter empAdapter = new DataTableAdapters.EmployeesTableAdapter();
            empAdapter.Fill((Data.EmployeesDataTable)dtEmployeesTable);
            try
            {
                dv = dtEmployeesTable.AsDataView();
                
                string filter = $"(FirstName LIKE '%{searchParam}%') OR" +
                                $"(LastName LIKE '%{searchParam}') OR" +
                                $"(Department LIKE '%{searchParam}%') OR" +
                                $"(AddressL1 LIKE '%{searchParam}%') OR" +
                                $"(AddressL2 LIKE '%{searchParam}%') OR" +
                                $"(SSN LIKE '%{searchParam}%') OR" +
                                $"(State LIKE '%{searchParam}%') OR" +
                                $"(City LIKE '%{searchParam}%')";
                    dv.RowFilter = filter;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Sorry, Unexpected error");
            }
             dtEmployeesTable = dv.ToTable();

            return dtEmployeesTable;
        }

        public static void SaveEmployee(string fname, string lname, string ssn, string deptName, decimal salary, decimal commissionRate, decimal sales, string employeeType, string state, string city, int zip, DateTime bday, DateTime joinedDate, bool married, string addressl1, string addressl2)
        {

            Data.EmployeesDataTable dtEmpTable = new Data.EmployeesDataTable();
            DataTableAdapters.EmployeesTableAdapter empAdapter = new DataTableAdapters.EmployeesTableAdapter();

            empAdapter.Fill(dtEmpTable);

            Data.EmployeesRow newEmpRow = dtEmpTable.NewEmployeesRow();


            newEmpRow.City = city;
            newEmpRow.State = state;
            newEmpRow.FirstName = fname;
            newEmpRow.LastName = lname;
            newEmpRow.SSN = ssn;
            newEmpRow.Department = deptName;
            newEmpRow.Marrried = married;
            newEmpRow.Salary = salary;
            newEmpRow.CommissionRate = commissionRate;
            newEmpRow.Sales = sales;
            newEmpRow.EmployeeType = employeeType;
            newEmpRow.AddressL1 = addressl1;
            newEmpRow.AddressL2 = addressl2;
            newEmpRow.Zip = zip;
            newEmpRow.BirthDate = bday;
            newEmpRow.DateJoined = joinedDate;

            dtEmpTable.AddEmployeesRow(newEmpRow);

            empAdapter.Update(dtEmpTable);
        }

        public static void DeleteEmployee(int empID)
        {
            Data.EmployeesDataTable dtEmpTable = new Data.EmployeesDataTable();
            DataTableAdapters.EmployeesTableAdapter empAdapter = new DataTableAdapters.EmployeesTableAdapter();
            empAdapter.Fill(dtEmpTable);
            Data.EmployeesRow row;
            row = dtEmpTable.Where(x => x.EmployeeID == empID).SingleOrDefault();
            empAdapter.Delete(row.EmployeeID, row.FirstName, row.LastName, row.AddressL1, row.AddressL2, row.City, row.State, row.Zip, row.SSN, row.Department, row.EmployeeType, row.DateJoined, row.BirthDate, row.Marrried, row.Salary, row.CommissionRate, row.Sales);
            dtEmpTable.AcceptChanges();
            
        }

        public static void QuickEditEmployee(int empID, string ssn, string fname, string lname)
        {
            Data.EmployeesDataTable dtEmpTable = new Data.EmployeesDataTable();

            DataTableAdapters.EmployeesTableAdapter empAdapter = new DataTableAdapters.EmployeesTableAdapter();
            empAdapter.Fill(dtEmpTable);

            Data.EmployeesRow row;
            row = dtEmpTable.Where(x => x.EmployeeID == empID).SingleOrDefault();

            row.SSN = ssn;
            row.FirstName = fname;
            row.LastName = lname;

            empAdapter.Update(dtEmpTable);
        }

        public static void EditEmployee(int empID, string lname, string fname, string type, bool married, string salary, string commissionRate, string sales, string department, string address1, string address2, string State, DateTime bday, DateTime DateJoined, string ssn, string city, int zip)
        {
            Data.EmployeesDataTable dtEmpTable = new Data.EmployeesDataTable();

            DataTableAdapters.EmployeesTableAdapter empAdapter = new DataTableAdapters.EmployeesTableAdapter();
            empAdapter.Fill(dtEmpTable);
            Data.EmployeesRow row;
            row = dtEmpTable.Where(x => x.EmployeeID == empID).SingleOrDefault();

            row.LastName = lname;
            row.FirstName= fname;
            row.EmployeeType = type;
            row.Marrried = married;
            row.Salary = decimal.Parse(salary);
            row.CommissionRate = decimal.Parse(commissionRate);
            row.Sales = decimal.Parse(sales);
            row.Department = department;
            row.AddressL1 = address1;
            row.AddressL2 = address2;
            row.State = State;
            row.BirthDate = bday;
            row.DateJoined = DateJoined;
            row.SSN = ssn;
            row.City = city;
            row.Zip = zip;

            empAdapter.Update(dtEmpTable);
        }

    }
}
