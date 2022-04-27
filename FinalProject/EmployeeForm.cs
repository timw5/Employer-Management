using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessAccessLayer;

namespace FinalProject
{
    public partial class EmployeeForm : Form
    {
        #region Global Property Initialization
        Color originalGroupBoxColor = Color.White;
        Color OriginalSubmitButtonColor = Color.White;
        bool editing = false;
        int CurrEmpID = -1;
        ErrorProvider FnameError = new ErrorProvider();
        ErrorProvider LnameError = new ErrorProvider();
        ErrorProvider ZipError = new ErrorProvider();
        ErrorProvider SSNError = new ErrorProvider();
        ErrorProvider BirthDateError = new ErrorProvider();
        #endregion

        public EmployeeForm()
        {
            InitializeComponent();
            
            #region Property Initialization Region
            originalGroupBoxColor = groupEmployeeType.BackColor;
            OriginalSubmitButtonColor = btnSubmit.BackColor;

            groupEmployeeType.BackColor = Color.WhiteSmoke;
            cmbState.SelectedItem = " ";





            lblFname.Visible = false;
            txtFname.Visible = false;
            lblLname.Visible = false;
            txtLname.Visible = false;
            lblSSN.Visible = false;
            txtSSN.Visible = false;
            lblAddress1.Visible = false;
            txtAddress1.Visible = false;
            lblAddress2.Visible = false;
            txtAddress2.Visible = false;
            lblBday.Visible = false;
            dateTimeBday.Visible = false;
            lblJoinDate.Visible = false;
            dateTimeJoinDate.Visible = false;
            lblCity.Visible = false;
            txtCity.Visible = false;
            lblState.Visible = false;
            cmbState.Visible = false;
            lblZip.Visible = false;
            txtZip.Visible = false;
            lblDpt.Visible = false;
            cmbDept.Visible = false;
            groupEmployeeType.Visible = false;

            radioBasePlusCommission.Checked = false;
            radioSalaried.Checked = false;
            radioCommission.Checked = false;
            lblSalary.Visible = false;
            txtSalary.Visible = false;
            lblCommissionRate.Visible = false;
            txtCommission.Visible = false;
            lblSales.Visible = false;
            txtSales.Visible = false;

            chkMarried.Checked = false;
            chkMarried.Visible = false;

            btnSubmit.Visible = false;
            btnReset.Visible = false;

            #endregion

            #region Event Initialization Region

            btnSubmit.MouseEnter += BtnSubmit_MouseEnter;
            btnSubmit.MouseLeave += BtnSubmit_MouseLeave;

            txtLname.MouseEnter += TxtLname_MouseEnter;
            txtLname.MouseLeave += TxtLname_MouseLeave;

            txtSSN.Leave += TxtSSN_Leave;

            #endregion

            #region data bind region
            
            txtAddress1.Text = string.Empty;
            txtAddress2.Text = string.Empty;
            txtFname.Text = string.Empty;
            txtLname.Text = string.Empty;
            cmbState.Text = string.Empty;
            txtZip.Text = string.Empty;
            txtSSN.Text = string.Empty;
            txtSales.Text = string.Empty;
            txtCommission.Text = string.Empty;
            txtSalary.Text = string.Empty;





            DataTable dtDeptTable = Access.GetDepartments();
            cmbDept.DataSource = dtDeptTable;
            int DeptNameColumnIndex = dtDeptTable.Columns.IndexOf("DeptName");
            int DeptIDColumnIndex = dtDeptTable.Columns.IndexOf("DeptID");
            cmbDept.DisplayMember = dtDeptTable.Columns[DeptNameColumnIndex].ToString();
            cmbDept.ValueMember = dtDeptTable.Columns[DeptIDColumnIndex].ToString();

            DataTable dtEmployeesTable = Access.GetEmployees();
            dgEmp.DataSource = dtEmployeesTable;

            //Readonly
            dgEmp.Columns["Department"].ReadOnly = true;
            

            //Visibility
            dgEmp.Columns["Marrried"].Visible = false;
            dgEmp.Columns["EmployeeID"].Visible = false;
            dgEmp.Columns["Salary"].Visible = false;
            dgEmp.Columns["Sales"].Visible = false;
            dgEmp.Columns["CommissionRate"].Visible = false;
            dgEmp.Columns["AddressL1"].Visible = false;
            dgEmp.Columns["AddressL2"].Visible = false;
            dgEmp.Columns["EmployeeType"].Visible = false;
            dgEmp.Columns["DateJoined"].Visible = false;
            dgEmp.Columns["BirthDate"].Visible = false;
            dgEmp.Columns["Zip"].Visible = false;
            dgEmp.Columns["State"].Visible = false;
            dgEmp.Columns["City"].Visible = false;

            //Delete Button
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "Use to Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.Name = "btnDelete";
            deleteColumn.UseColumnTextForButtonValue = true;
            dgEmp.Columns.Add(deleteColumn);

            //Edit Button
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.HeaderText = "Use to Edit";
            editColumn.Text = "Edit";
            editColumn.Name = "btnEdit";
            editColumn.UseColumnTextForButtonValue = true;
            dgEmp.Columns.Add(editColumn);
            dgEmp.CellClick += DgEmp_CellClick;

            #endregion

        }

        private void DgEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentEmpID = -1;
            string ssn = string.Empty;
            string fname = string.Empty;
            string lname = string.Empty;
            if (e.RowIndex < 0)
                return;

            DataGridView dg = (DataGridView)sender;//cast
            DataGridViewRow rowToBeOperatedOn = dg.Rows[e.RowIndex];
            currentEmpID = int.Parse(rowToBeOperatedOn.Cells["EmployeeID"].Value.ToString());
            CurrEmpID = currentEmpID;

           

            if (e.ColumnIndex == -1)
            {
                //show data entry section, and populate the fields
                EditCell(sender, e, currentEmpID);
                editing = true;
                return;
            }



            if (dg.SelectedCells.Count == 1)
            {

                if (dg.SelectedCells[0] is DataGridViewButtonCell)
                {
                    DataGridViewButtonCell selected = (DataGridViewButtonCell)dg.SelectedCells[0];

                    if(selected.Value == null)
                    {
                        return;
                    }
                    if (selected.Value.Equals("Delete"))
                    {
                        DeleteCell(sender, e, currentEmpID);
                        return;
                    }
                    else if (selected.Value.Equals("Edit"))
                    {
                        currentEmpID = int.Parse(rowToBeOperatedOn.Cells["EmployeeID"].Value.ToString());
                        ssn = rowToBeOperatedOn.Cells["SSN"].Value.ToString();
                        fname = rowToBeOperatedOn.Cells["FirstName"].Value.ToString();
                        lname = rowToBeOperatedOn.Cells["LastName"].Value.ToString();

                        QuickEditCell(sender, e, currentEmpID, ssn, fname, lname);
                        return;
                    }
                }
            }
        }

        private void EditCell(Object sender, DataGridViewCellEventArgs e, int EmpID)
        {
            DataGridView dg = (DataGridView)sender;
            DataGridViewRow rowToBeOperatedOn = dg.Rows[e.RowIndex];
            if(e.RowIndex >= dgEmp.Rows.Count-1)
            {
                return;
            }
            button1_Click(sender, e);
            txtAddress1.Text = rowToBeOperatedOn.Cells["AddressL1"].Value.ToString();
            txtAddress2.Text = rowToBeOperatedOn.Cells["AddressL2"].Value.ToString();
            txtFname.Text = rowToBeOperatedOn.Cells["FirstName"].Value.ToString();
            txtLname.Text = rowToBeOperatedOn.Cells["LastName"].Value.ToString();
            cmbState.Text = rowToBeOperatedOn.Cells["State"].Value.ToString();
            txtZip.Text = rowToBeOperatedOn.Cells["Zip"].Value.ToString();
            txtSSN.Text = rowToBeOperatedOn.Cells["SSN"].Value.ToString();
            txtSales.Text = rowToBeOperatedOn.Cells["Sales"].Value.ToString();
            txtCommission.Text = rowToBeOperatedOn.Cells["CommissionRate"].Value.ToString();
            txtSalary.Text = rowToBeOperatedOn.Cells["Salary"].Value.ToString();
            txtCity.Text = rowToBeOperatedOn.Cells["City"].Value.ToString();
            dateTimeBday.Value = DateTime.Parse(rowToBeOperatedOn.Cells["BirthDate"].Value.ToString());
            dateTimeJoinDate.Value = DateTime.Parse(rowToBeOperatedOn.Cells["DateJoined"].Value.ToString());

            if ((bool)rowToBeOperatedOn.Cells["Marrried"].Value)
                chkMarried.Checked = true;
            if(rowToBeOperatedOn.Cells["EmployeeType"].Value.ToString().ToLower() == "base plus commission")
                radioBasePlusCommission.Checked = true;
            else if (rowToBeOperatedOn.Cells["EmployeeType"].Value.ToString().ToLower() == "commission")
                radioCommission.Checked= true;
            else if (rowToBeOperatedOn.Cells["EmployeeType"].Value.ToString().ToLower() == "salaried") 
                radioSalaried.Checked = true;
            editing = true;
            CurrEmpID = EmpID;

        }

        private void RefreshGridData()
        {
            DataTable dtEmpTable = new DataTable();
                dtEmpTable = Access.GetEmployees();

            dgEmp.DataSource = dtEmpTable;
            dgEmp.Columns["Marrried"].Visible = false;
            dgEmp.Columns["EmployeeID"].Visible = false;
            dgEmp.Columns["Salary"].Visible = false;
            dgEmp.Columns["Sales"].Visible = false;
            dgEmp.Columns["CommissionRate"].Visible = false;
            dgEmp.Columns["AddressL1"].Visible = false;
            dgEmp.Columns["AddressL2"].Visible = false;
            dgEmp.Columns["EmployeeType"].Visible = false;
            dgEmp.Columns["DateJoined"].Visible = false;
            dgEmp.Columns["BirthDate"].Visible = false;
            dgEmp.Columns["Zip"].Visible = false;
            dgEmp.Columns["State"].Visible = false;
            dgEmp.Columns["City"].Visible = false;
        }

        private void RefreshGridData(string searchParam)
        {

            DataTable dtEmpTable = new DataTable();
            dtEmpTable = Access.GetEmployees(searchParam).Result;
            

            dgEmp.DataSource = dtEmpTable;
            dgEmp.Columns["Marrried"].Visible = false;
            dgEmp.Columns["EmployeeID"].Visible = false;
            dgEmp.Columns["Salary"].Visible = false;
            dgEmp.Columns["Sales"].Visible = false;
            dgEmp.Columns["CommissionRate"].Visible = false;
            dgEmp.Columns["AddressL1"].Visible = false;
            dgEmp.Columns["AddressL2"].Visible = false;
            dgEmp.Columns["EmployeeType"].Visible = false;
            dgEmp.Columns["DateJoined"].Visible = false;
            dgEmp.Columns["BirthDate"].Visible = false;
            dgEmp.Columns["Zip"].Visible = false;
            dgEmp.Columns["State"].Visible = false;
            dgEmp.Columns["City"].Visible = false;
        }

        private void QuickEditCell(object sender, DataGridViewCellEventArgs e, int empID, string ssn, string fname, string lname)
        {

            Access.QuickEditEmployee(empID, ssn, fname, lname);
            RefreshGridData();

        }

        private void DeleteCell(object sender, DataGridViewCellEventArgs e, int empID)
        {
            Access.DeleteEmployee(empID);
            RefreshGridData();
        }

        private void TxtSSN_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtSSN.Text, @"^\d{3}[-]\d{2}[-]\d{4}$"))
            {
                SSNError.SetError(txtSSN, "Zip must be in the form xxx-xx-xxxx");
                txtSSN.Clear();
            }
            else if (txtSSN.Text == String.Empty)
                SSNError.Clear();
            else
            {
                SSNError.Clear();
            }
        }

        private void TxtLname_MouseLeave(object sender, EventArgs e)
        {
            txtLname.Size = new Size(txtLname.Size.Width - 1, txtLname.Size.Height);
        }

        private void TxtLname_MouseEnter(object sender, EventArgs e)
        {
            txtLname.Size = new Size(txtLname.Size.Width + 1, txtLname.Size.Height);
        }

        private void BtnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.BackColor = OriginalSubmitButtonColor;
        }

        private void BtnSubmit_MouseEnter(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.Azure;
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show($"Item: {cmbState.SelectedItem}\nIndex: {cmbState.SelectedIndex}");
        }

        private void chkMarried_CheckedChanged(object sender, EventArgs e)
        {
            // MessageBox.Show($"Is Married: {chkMarried.Checked}");
        }

        private void radioSalaried_CheckedChanged(object sender, EventArgs e)
        {
            lblSalary.Visible = true;
            txtSalary.Visible = true;

            lblCommissionRate.Visible = false;
            txtCommission.Visible = false;

            lblSales.Visible = false;
            txtSales.Visible = false;
        }

        private void radioCommission_CheckedChanged(object sender, EventArgs e)
        {
            lblCommissionRate.Visible = true;
            txtCommission.Visible = true;

            lblSalary.Visible = false;
            txtSalary.Visible = false;

            lblSales.Visible = true;
            txtSales.Visible = true;


        }

        private void radioBasePlusCommission_CheckedChanged(object sender, EventArgs e)
        {
            #region Property Re-Initialization
            lblSales.Visible = true;
            txtSales.Visible = true;

            lblSalary.Visible = true;
            txtSalary.Visible = true;

            lblCommissionRate.Visible = true;
            txtCommission.Visible = true;
            #endregion
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            groupEmployeeType.BackColor = originalGroupBoxColor;

            bool error = false;
            if(txtFname.Text == string.Empty)
            {
                FnameError.SetError(txtFname, "First name cant be empty");
                error = true;
            }
            if(txtLname.Text == string.Empty)
            {
                LnameError.SetError(txtLname, "Last Name cant be empty");
                error = true;
            }
            if(!Regex.IsMatch(txtZip.Text,@"\d{5}$" ))
            {
                ZipError.SetError(txtZip, "zip code must be 5 digits");
                error = true;
            }
           
            if(error)
            {
                MessageBox.Show("Please fix the errors and try again");
                return;
            }

            bool married = false;
            if (chkMarried.Checked)
                married = true;
            if (editing)
            {
                
                if(chkMarried.Checked)
                {
                   married = true;
                }
                string EmpType = string.Empty;
                if (radioBasePlusCommission.Checked)
                    EmpType = "Base Plus Commission";
                else if (radioCommission.Checked)
                    EmpType = "Commission";
                else if (radioSalaried.Checked)
                    EmpType = "Salaried";
                Access.EditEmployee(CurrEmpID,
                                    txtLname.Text,
                                    txtFname.Text,
                                    EmpType,
                                    married,
                                    txtSalary.Text,
                                    txtCommission.Text,
                                    txtSales.Text,
                                    cmbDept.Text,
                                    txtAddress1.Text,
                                    txtAddress2.Text,
                                    cmbState.Text,
                                    dateTimeJoinDate.Value,
                                    dateTimeBday.Value,
                                    txtSSN.Text,
                                    txtCity.Text,
                                    int.Parse(txtZip.Text)
                                    );

                editing = false;
                CurrEmpID = -1;
                RefreshGridData();
                btnReset_Click(sender, e);
                return;

            }


            

            Employee emp = null;

            try
            {
                if (radioSalaried.Checked)
                    emp = new SalariedEmployee(txtFname.Text, txtLname.Text, txtSSN.Text, decimal.Parse(txtSalary.Text));
                else if (radioCommission.Checked)
                    emp = new CommisionEmployee(txtFname.Text, txtLname.Text, txtSSN.Text, decimal.Parse(txtSales.Text), decimal.Parse(txtCommission.Text));
                else if (radioBasePlusCommission.Checked)
                    emp = new BasePlusCommisionEmployee(txtFname.Text, txtLname.Text, txtSSN.Text, decimal.Parse(txtSales.Text), decimal.Parse(txtCommission.Text), decimal.Parse(txtSalary.Text));
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Try again");
                return;
            }

            string emptype = string.Empty;
            if (radioBasePlusCommission.Checked)
                emptype = "Base Plus Commission";
            else if (radioCommission.Checked)
                emptype = "Commission";
            else if (radioSalaried.Checked)
                emptype = "Salaried";

            emp.SaveEmployee(cmbDept.Text.ToString(), emptype, cmbState.Text, txtCity.Text, int.Parse(txtZip.Text), dateTimeBday.Value, dateTimeJoinDate.Value, married, txtAddress1.Text, txtAddress2.Text);

            RefreshGridData();

            btnReset_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region hideVals
            radioSalaried.Checked = true;
            lblFname.Visible = true;
            txtFname.Visible = true;
            lblLname.Visible = true;
            txtLname.Visible = true;
            lblSSN.Visible = true;
            txtSSN.Visible = true;
            lblAddress1.Visible = true;
            txtAddress1.Visible = true;
            lblAddress2.Visible = true;
            txtAddress2.Visible = true;
            lblBday.Visible = true;
            dateTimeBday.Visible = true;
            lblJoinDate.Visible = true;
            dateTimeJoinDate.Visible = true;
            lblCity.Visible = true;
            txtCity.Visible = true;
            lblState.Visible = true;
            cmbState.Visible = true;
            lblZip.Visible = true;
            txtZip.Visible = true;
            lblDpt.Visible = true;
            cmbDept.Visible = true;
            groupEmployeeType.Visible = true;
            btnSubmit.Visible = true;
            btnReset.Visible = true;
            chkMarried.Visible = true;
            editing = false;
            #endregion

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            #region hideVals
            lblFname.Visible = false;
            txtFname.Visible = false;
            txtFname.Text = String.Empty;

            lblLname.Visible = false;
            txtLname.Visible = false;
            txtLname.Text = String.Empty;

            lblSSN.Visible = false;
            txtSSN.Visible = false;
            txtSSN.Text = String.Empty;

            lblAddress1.Visible = false;
            txtAddress1.Visible = false;
            txtAddress1.Text = String.Empty;

            lblAddress2.Visible = false;
            txtAddress2.Visible = false;
            txtAddress2.Text = String.Empty;

            lblBday.Visible = false;
            dateTimeBday.Visible = false;
            dateTimeBday.Value = DateTime.Now;

            lblJoinDate.Visible = false;
            dateTimeJoinDate.Value = DateTime.Now;
            dateTimeJoinDate.Visible = false;

            lblCity.Visible = false;
            txtCity.Visible = false;
            txtCity.Text = String.Empty;

            lblState.Visible = false;
            cmbState.Visible = false;
            
            lblZip.Visible = false;
            txtZip.Visible = false;
            txtZip.Text = String.Empty;

            lblDpt.Visible = false;
            cmbDept.Visible = false;

            groupEmployeeType.Visible = false;

            radioBasePlusCommission.Checked = false;
            radioSalaried.Checked = false;
            radioCommission.Checked = false;
            lblSalary.Visible = false;
            txtSalary.Visible = false;
            txtSalary.Text = String.Empty;

            lblCommissionRate.Visible = false;
            txtCommission.Visible = false;
            txtCommission.Text = String.Empty;

            lblSales.Visible = false;
            txtSales.Visible = false;
            txtSales.Text = String.Empty;

            chkMarried.Checked = false;
            chkMarried.Visible = false;

            btnSubmit.Visible = false;
            btnReset.Visible = false;

            #endregion
            FnameError.Clear();
            LnameError.Clear();
            ZipError.Clear();
            SSNError.Clear();
            BirthDateError.Clear();

        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = String.Empty;
            RefreshGridData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
           RefreshGridData(txtSearch.Text);

            
        }

        private void txtFname_Leave(object sender, EventArgs e)
        {
            if (txtFname.Text.Length <= 0)
            {
                FnameError.SetError(txtFname, "first name can't be empty");
                txtFname.Clear();
            }
            else if(txtFname.Text == String.Empty)
                FnameError.Clear();
            
            else
                FnameError.Clear();


        }

        private void txtLname_Leave(object sender, EventArgs e)
        {
            if (txtLname.Text.Length <= 0)
            {
                LnameError.SetError(txtLname, "Lname must not be empty");
                txtLname.Clear();
            }
            else if (txtLname.Text == String.Empty)
                LnameError.Clear();
            else
                LnameError.Clear();
                
            
        }

        private void txtZip_Leave(object sender, EventArgs e)
        {

            if (!Regex.IsMatch(txtZip.Text, @"\d{5}$"))
            {
                ZipError.SetError(txtZip, "Zip must be a 5 digit character");
                txtZip.Clear();
            }
            else if (txtZip.Text == String.Empty)
                ZipError.Clear();
            else
                ZipError.Clear();
            
            
                
        }

        private void dateTimeBday_Leave(object sender, EventArgs e)
        {
            if(dateTimeBday.Value > DateTime.Now)
            {
                BirthDateError.SetError(dateTimeBday, "Birth day must not be in the future");
            }
            else if(dateTimeBday.Value > DateTime.Now.AddYears(-18))
            {
                BirthDateError.SetError(dateTimeBday, "Must be at least 18 years old");
            }
            else
            {
                BirthDateError.Clear();
            }
        }

        private void EmployeeForm_VisibleChanged(object sender, EventArgs e)
        {
            DataTable dtDeptTable = Access.GetDepartments();
            cmbDept.DataSource = dtDeptTable;
            int DeptNameColumnIndex = dtDeptTable.Columns.IndexOf("DeptName");
            int DeptIDColumnIndex = dtDeptTable.Columns.IndexOf("DeptID");
            cmbDept.DisplayMember = dtDeptTable.Columns[DeptNameColumnIndex].ToString();
            cmbDept.ValueMember = dtDeptTable.Columns[DeptIDColumnIndex].ToString();

        }


    }
}
