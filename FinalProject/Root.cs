using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
   
    public partial class Root : Form
    {
        Form empForm;
        Form deptForm;
        public Root()
        {
            InitializeComponent();
            empForm = new EmployeeForm
            {
                MdiParent = this
            };

            deptForm = new DepartmentForm
            {
                MdiParent = this
            };

        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            empForm.Dock = DockStyle.Fill;
            empForm.Show();
            label1.Hide();
            label2.Hide();
        }

        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deptForm.Dock = DockStyle.Fill;
            deptForm.Show();
            label1.Hide();
            label2.Hide();
            empForm.Hide();
        }


    }
}
