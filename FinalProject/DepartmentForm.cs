using BusinessAccessLayer;
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
    public partial class DepartmentForm : Form
    {
        #region Global Property Initialization
        bool editing = false;
        int CurrentDeptID = -1;

        ErrorProvider NameError = new ErrorProvider();
        ErrorProvider ContactNameError = new ErrorProvider();
        ErrorProvider PhoneError = new ErrorProvider();
        ErrorProvider LocationError = new ErrorProvider();

        #endregion

        public DepartmentForm()
        {
            InitializeComponent();

            #region Data Bind Region


            DataTable dtDeptTable = Access.GetDepartments();
            dgDepts.DataSource = dtDeptTable;

            dgDepts.Columns["DeptName"].ReadOnly = false;
            dgDepts.Columns["DeptID"].ReadOnly = true;
            dgDepts.Columns["DeptID"].Visible = false;
            dgDepts.Columns["ContactName"].ReadOnly = true;
            dgDepts.Columns["ContactPhone"].ReadOnly = true;
            dgDepts.Columns["Location"].ReadOnly = true;

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "Use to delete";
            deleteColumn.Text = "Delete";
            deleteColumn.Name = "btnDelete";
            deleteColumn.UseColumnTextForButtonValue = true;
            dgDepts.Columns.Add(deleteColumn);

            //Edit Button
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.HeaderText = "Use to Edit";
            editColumn.Text = "Edit";
            editColumn.Name = "btnEdit";
            editColumn.UseColumnTextForButtonValue = true;
            dgDepts.Columns.Add(editColumn);
            dgDepts.CellClick += DgDepts_CellClick;

            #endregion

            #region Property Initialization Region

            lblDeptName.Visible = false;
            txtDeptName.Text = String.Empty;
            txtDeptName.Visible = false;

            lblLocation.Visible = false;
            txtLocation.Text = String.Empty;
            txtLocation.Visible = false;

            lblContactName.Visible = false;
            txtContactName.Text = String.Empty;
            txtContactName.Visible = false;

            lblContactPhone.Visible = false;
            txtContactPhone.Text = String.Empty;
            txtContactPhone.Visible = false;

            btnSubmit.Visible = false;
            btnReset.Visible = false;

            #endregion
        }

        private void DgDepts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currDeptID = -1;
            string deptName = string.Empty;
            string deptContactName = string.Empty;
            string deptContactPhone = string.Empty;
            string deptLocation = string.Empty;

            if (e.RowIndex < 0)
                return;

            DataGridView dg = (DataGridView)sender;
            DataGridViewRow row = dg.Rows[e.RowIndex];
            currDeptID = int.Parse(row.Cells["DeptID"].Value.ToString());

            if(e.ColumnIndex == -1)
            {
                //show data entry section, populate fields with values from the selected row
                currDeptID = int.Parse(row.Cells["DeptID"].Value.ToString());
                deptName = row.Cells["DeptName"].Value.ToString();
                deptContactName = row.Cells["ContactName"].Value.ToString();
                deptContactPhone = row.Cells["ContactPhone"].Value.ToString();
                deptLocation = row.Cells["Location"].Value.ToString();
                EditCell(sender, e, currDeptID, deptName, deptContactName, deptContactPhone, deptLocation);
                editing = true;
                CurrentDeptID = currDeptID;
                
                return;
            }

            if(dg.SelectedCells.Count == 1)
            {
                if(dg.SelectedCells[0] is DataGridViewButtonCell)
                {
                    DataGridViewButtonCell selected = (DataGridViewButtonCell)dg.SelectedCells[0];

                    if(selected.Value == null)
                    {
                        return;
                    }
                    if (selected.Value.Equals("Delete"))
                    {
                        DeleteCell(sender, e, currDeptID);
                        return;
                    }
                    else if (selected.Value.Equals("Edit"))
                    {
                        deptName = row.Cells["DeptName"].Value.ToString();
                        QuickEditCell(sender, e, currDeptID, deptName);
                        return;
                    }
                }
            }

        }

        private void DeleteCell(object sender, DataGridViewCellEventArgs e, int currDeptID)
        {
            Access.DeleteDept(currDeptID);
            RefreshGridData();
        }

        private void QuickEditCell(object sender, DataGridViewCellEventArgs e, int currentDeptID, string deptName)
        {
            Access.QuickEditDept(currentDeptID, deptName);
            RefreshGridData();
        }

        private void EditCell(object sender, DataGridViewCellEventArgs e, int currDeptID, string deptName, string deptContactName, string deptContactPhone, string deptLocation)
        {
            if (e.RowIndex >= dgDepts.Rows.Count - 1)
                return;

            btnAddDept_Click(sender, e);
            txtDeptName.Text = deptName;
            txtLocation.Text = deptLocation;
            txtContactName.Text = deptContactName;
            txtContactPhone.Text = deptContactPhone;

            RefreshGridData();
        }
       
        private void RefreshGridData()
        {
            DataTable dtDeptTable = new DataTable();
            dtDeptTable = Access.GetDepartments();
            dgDepts.DataSource = dtDeptTable;
            dgDepts.Columns["DeptName"].ReadOnly = false;
            dgDepts.Columns["DeptID"].ReadOnly = true;
            dgDepts.Columns["DeptID"].Visible = false;
            dgDepts.Columns["ContactName"].ReadOnly = true;
            dgDepts.Columns["ContactPhone"].ReadOnly = true;
            dgDepts.Columns["Location"].ReadOnly = true;

        }
       
        private void RefreshGridData(string SearchParam)
        {
            DataTable dtDeptTable = new DataTable();
            dtDeptTable = Access.GetDepartments(SearchParam);
            dgDepts.DataSource = dtDeptTable;
            dgDepts.Columns["DeptName"].ReadOnly = false;
            dgDepts.Columns["DeptID"].ReadOnly = true;
            dgDepts.Columns["DeptID"].Visible = false;
            dgDepts.Columns["ContactName"].ReadOnly = true;
            dgDepts.Columns["ContactPhone"].ReadOnly = true;
            dgDepts.Columns["Location"].ReadOnly = true;

        }

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            lblDeptName.Visible = true;
            txtDeptName.Visible = true;

            lblLocation.Visible = true;
            txtLocation.Visible = true;

            lblContactName.Visible = true;
            txtContactName.Visible = true;

            lblContactPhone.Visible = true;
            txtContactPhone.Visible = true;

            btnSubmit.Visible = true;
            btnReset.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshGridData(txtSearch.Text);
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = String.Empty;
            RefreshGridData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            lblDeptName.Visible = false;
            txtDeptName.Text = String.Empty;
            txtDeptName.Visible = false;

            lblLocation.Visible = false;
            txtLocation.Text = String.Empty;
            txtLocation.Visible = false;

            lblContactName.Visible = false;
            txtContactName.Text = String.Empty;
            txtContactName.Visible = false;

            lblContactPhone.Visible = false;
            txtContactPhone.Text = String.Empty;
            txtContactPhone.Visible = false;

            btnSubmit.Visible = false;
            btnReset.Visible = false;
            NameError.Clear();
            ContactNameError.Clear();
            PhoneError.Clear();
            LocationError.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool error = false;
            if(txtDeptName.Text == String.Empty || txtDeptName.Text.Length<=0 )
            {
                NameError.SetError(txtContactName, "Name Can't be empty");   
                error = true;
            }
            if(txtContactName.Text == String.Empty || txtContactName.Text.Length <= 0)
            {
                ContactNameError.SetError(txtContactName, "Contact Name Can't be empty");
                error = true;
            }
            if(txtContactPhone.Text == String.Empty || txtContactPhone.Text.Length <= 0)
            {
                PhoneError.SetError(txtContactPhone, "Phone Can't be empty");
                error = true;
            }
            if(txtLocation.Text == String.Empty || txtLocation.Text.Length <= 0)
            {
                LocationError.SetError(txtLocation, "Location Can't be empty");
                error = true;
            }
            if (error)
            {
                MessageBox.Show("Please fix the errors and try again");
                return;
            }

            if(editing)
            {
                Access.EditDept(CurrentDeptID,txtDeptName.Text, txtContactName.Text, txtContactPhone.Text, txtLocation.Text);
                editing = false;
                CurrentDeptID = -1;
                RefreshGridData();
                btnReset_Click(sender, e);
                return;
            }


            Department dept = new Department(txtDeptName.Text, txtLocation.Text, txtContactName.Text, txtContactPhone.Text);
            dept.SaveDept();

            RefreshGridData();

            btnReset_Click(sender, e);
        }

        private void txtDeptName_Leave(object sender, EventArgs e)
        {
            if (txtDeptName.Text.Length <= 0)
            {
                NameError.SetError(txtDeptName, "Name Can't be Empty");
            }
            else if (txtDeptName.Text == String.Empty)
            {
                NameError.Clear();
            }
            else
                NameError.Clear();
        }

        private void txtLocation_Leave(object sender, EventArgs e)
        {
            if (txtLocation.Text.Length <= 0)
            {
                LocationError.SetError(txtDeptName, "Name Can't be Empty");
            }
            else if (txtLocation.Text == String.Empty)
            {
                LocationError.Clear();
            }
            else
                LocationError.Clear();

        }

        private void txtContactName_Leave(object sender, EventArgs e)
        {
            if (txtContactName.Text.Length <= 0)
            {
                ContactNameError.SetError(txtDeptName, "Name Can't be Empty");
            }
            else if (txtContactName.Text == String.Empty)
            {
                ContactNameError.Clear();
            }
            else
                ContactNameError.Clear();
        }

        private void txtContactPhone_Leave(object sender, EventArgs e)
        {
            if (txtContactPhone.Text.Length <= 0)
            {
                PhoneError.SetError(txtDeptName, "Name Can't be Empty");
            }
            else if (txtContactPhone.Text == String.Empty)
            {
                PhoneError.Clear();
            }
            else
                PhoneError.Clear();
        }
    }
}

    