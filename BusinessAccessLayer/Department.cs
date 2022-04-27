using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class Department
    {
        string DeptName { get; set; }
        string Location { get; set; }
        string ContactName { get; set; }
        string ContactPhone { get; set; }

        public Department(string deptName, string location, string contactName, string contactPhone)
        {
            this.DeptName = deptName;
            this.Location = location;
            this.ContactName = contactName;
            this.ContactPhone = contactPhone;
        }

        public void SaveDept()
        {
            Utility.SaveDept(this.DeptName, this.Location, this.ContactName, this.ContactPhone);
        }

        public static void DeleteDept(int deptID)
        {
            Utility.DeleteDept(deptID);
        }
    }
}
