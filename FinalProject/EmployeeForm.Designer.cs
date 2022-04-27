using System.Windows.Forms;
using System;

namespace FinalProject
{
    partial class EmployeeForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFname = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.lblLname = new System.Windows.Forms.Label();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.lblSSN = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.chkMarried = new System.Windows.Forms.CheckBox();
            this.radioSalaried = new System.Windows.Forms.RadioButton();
            this.radioBasePlusCommission = new System.Windows.Forms.RadioButton();
            this.radioCommission = new System.Windows.Forms.RadioButton();
            this.groupEmployeeType = new System.Windows.Forms.GroupBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblCommissionRate = new System.Windows.Forms.Label();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.lblSales = new System.Windows.Forms.Label();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.lblDpt = new System.Windows.Forms.Label();
            this.dgEmp = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dateTimeBday = new System.Windows.Forms.DateTimePicker();
            this.lblBday = new System.Windows.Forms.Label();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.dateTimeJoinDate = new System.Windows.Forms.DateTimePicker();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnResetSearch = new System.Windows.Forms.Button();
            this.groupEmployeeType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(23, 469);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(75, 18);
            this.lblFname.TabIndex = 0;
            this.lblFname.Text = "First Name";
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(142, 462);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(170, 25);
            this.txtFname.TabIndex = 0;
            this.txtFname.Leave += new System.EventHandler(this.txtFname_Leave);
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(142, 513);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(170, 25);
            this.txtLname.TabIndex = 1;
            this.txtLname.Leave += new System.EventHandler(this.txtLname_Leave);
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.Location = new System.Drawing.Point(23, 520);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(73, 18);
            this.lblLname.TabIndex = 5;
            this.lblLname.Text = "Last Name";
            // 
            // txtSSN
            // 
            this.txtSSN.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSN.Location = new System.Drawing.Point(142, 564);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(170, 25);
            this.txtSSN.TabIndex = 2;
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSN.Location = new System.Drawing.Point(23, 571);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(33, 18);
            this.lblSSN.TabIndex = 7;
            this.lblSSN.Text = "SSN";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress1.Location = new System.Drawing.Point(140, 609);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(170, 25);
            this.txtAddress1.TabIndex = 3;
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.Location = new System.Drawing.Point(22, 616);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(97, 18);
            this.lblAddress1.TabIndex = 9;
            this.lblAddress1.Text = "Address Line 1";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress2.Location = new System.Drawing.Point(142, 652);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(170, 25);
            this.txtAddress2.TabIndex = 4;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.Location = new System.Drawing.Point(23, 659);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(97, 18);
            this.lblAddress2.TabIndex = 11;
            this.lblAddress2.Text = "Address Line 2";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(352, 612);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(38, 18);
            this.lblState.TabIndex = 14;
            this.lblState.Text = "State";
            // 
            // cmbState
            // 
            this.cmbState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbState.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.cmbState.Location = new System.Drawing.Point(455, 608);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(170, 26);
            this.cmbState.TabIndex = 5;
            this.cmbState.SelectedIndexChanged += new System.EventHandler(this.cmbState_SelectedIndexChanged);
            // 
            // chkMarried
            // 
            this.chkMarried.AutoSize = true;
            this.chkMarried.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMarried.Location = new System.Drawing.Point(455, 691);
            this.chkMarried.Name = "chkMarried";
            this.chkMarried.Size = new System.Drawing.Size(79, 22);
            this.chkMarried.TabIndex = 7;
            this.chkMarried.Text = "Married";
            this.chkMarried.UseVisualStyleBackColor = true;
            this.chkMarried.CheckedChanged += new System.EventHandler(this.chkMarried_CheckedChanged);
            // 
            // radioSalaried
            // 
            this.radioSalaried.AutoSize = true;
            this.radioSalaried.Location = new System.Drawing.Point(6, 24);
            this.radioSalaried.Name = "radioSalaried";
            this.radioSalaried.Size = new System.Drawing.Size(78, 22);
            this.radioSalaried.TabIndex = 9;
            this.radioSalaried.TabStop = true;
            this.radioSalaried.Text = "Salaried";
            this.radioSalaried.UseVisualStyleBackColor = true;
            this.radioSalaried.CheckedChanged += new System.EventHandler(this.radioSalaried_CheckedChanged);
            // 
            // radioBasePlusCommission
            // 
            this.radioBasePlusCommission.AutoSize = true;
            this.radioBasePlusCommission.Location = new System.Drawing.Point(6, 102);
            this.radioBasePlusCommission.Name = "radioBasePlusCommission";
            this.radioBasePlusCommission.Size = new System.Drawing.Size(163, 22);
            this.radioBasePlusCommission.TabIndex = 19;
            this.radioBasePlusCommission.TabStop = true;
            this.radioBasePlusCommission.Text = "Base Plus Commission";
            this.radioBasePlusCommission.UseVisualStyleBackColor = true;
            this.radioBasePlusCommission.CheckedChanged += new System.EventHandler(this.radioBasePlusCommission_CheckedChanged);
            // 
            // radioCommission
            // 
            this.radioCommission.AutoSize = true;
            this.radioCommission.Location = new System.Drawing.Point(6, 62);
            this.radioCommission.Name = "radioCommission";
            this.radioCommission.Size = new System.Drawing.Size(104, 22);
            this.radioCommission.TabIndex = 18;
            this.radioCommission.TabStop = true;
            this.radioCommission.Text = "Commission";
            this.radioCommission.UseVisualStyleBackColor = true;
            this.radioCommission.CheckedChanged += new System.EventHandler(this.radioCommission_CheckedChanged);
            // 
            // groupEmployeeType
            // 
            this.groupEmployeeType.Controls.Add(this.radioCommission);
            this.groupEmployeeType.Controls.Add(this.radioSalaried);
            this.groupEmployeeType.Controls.Add(this.radioBasePlusCommission);
            this.groupEmployeeType.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupEmployeeType.Location = new System.Drawing.Point(757, 533);
            this.groupEmployeeType.Name = "groupEmployeeType";
            this.groupEmployeeType.Size = new System.Drawing.Size(193, 159);
            this.groupEmployeeType.TabIndex = 8;
            this.groupEmployeeType.TabStop = false;
            this.groupEmployeeType.Text = "Employee Type";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(956, 552);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 25);
            this.txtSalary.TabIndex = 10;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(953, 533);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(126, 18);
            this.lblSalary.TabIndex = 26;
            this.lblSalary.Text = "Salary / Base Salary";
            // 
            // lblCommissionRate
            // 
            this.lblCommissionRate.AutoSize = true;
            this.lblCommissionRate.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommissionRate.Location = new System.Drawing.Point(953, 595);
            this.lblCommissionRate.Name = "lblCommissionRate";
            this.lblCommissionRate.Size = new System.Drawing.Size(113, 18);
            this.lblCommissionRate.TabIndex = 28;
            this.lblCommissionRate.Text = "Commission Rate";
            // 
            // txtCommission
            // 
            this.txtCommission.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommission.Location = new System.Drawing.Point(956, 614);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(100, 25);
            this.txtCommission.TabIndex = 11;
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSales.Location = new System.Drawing.Point(953, 648);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(38, 18);
            this.lblSales.TabIndex = 30;
            this.lblSales.Text = "Sales";
            // 
            // txtSales
            // 
            this.txtSales.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSales.Location = new System.Drawing.Point(956, 667);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(100, 25);
            this.txtSales.TabIndex = 12;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSubmit.Location = new System.Drawing.Point(16, 708);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(103, 38);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(350, 655);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(62, 18);
            this.lblZip.TabIndex = 33;
            this.lblZip.Text = "Zip Code";
            // 
            // txtZip
            // 
            this.txtZip.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZip.Location = new System.Drawing.Point(455, 649);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(170, 25);
            this.txtZip.TabIndex = 6;
            this.txtZip.Leave += new System.EventHandler(this.txtZip_Leave);
            // 
            // cmbDept
            // 
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(853, 473);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(170, 24);
            this.cmbDept.TabIndex = 34;
            // 
            // lblDpt
            // 
            this.lblDpt.AutoSize = true;
            this.lblDpt.Location = new System.Drawing.Point(760, 476);
            this.lblDpt.Name = "lblDpt";
            this.lblDpt.Size = new System.Drawing.Size(77, 16);
            this.lblDpt.TabIndex = 35;
            this.lblDpt.Text = "Department";
            // 
            // dgEmp
            // 
            this.dgEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmp.Location = new System.Drawing.Point(24, 78);
            this.dgEmp.Name = "dgEmp";
            this.dgEmp.RowHeadersWidth = 51;
            this.dgEmp.RowTemplate.Height = 24;
            this.dgEmp.Size = new System.Drawing.Size(940, 292);
            this.dgEmp.TabIndex = 36;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 887);
            this.splitter1.TabIndex = 37;
            this.splitter1.TabStop = false;
            // 
            // dateTimeBday
            // 
            this.dateTimeBday.Location = new System.Drawing.Point(455, 462);
            this.dateTimeBday.Name = "dateTimeBday";
            this.dateTimeBday.Size = new System.Drawing.Size(253, 22);
            this.dateTimeBday.TabIndex = 38;
            this.dateTimeBday.Leave += new System.EventHandler(this.dateTimeBday_Leave);
            // 
            // lblBday
            // 
            this.lblBday.AutoSize = true;
            this.lblBday.Location = new System.Drawing.Point(350, 468);
            this.lblBday.Name = "lblBday";
            this.lblBday.Size = new System.Drawing.Size(56, 16);
            this.lblBday.TabIndex = 39;
            this.lblBday.Text = "Birthday";
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.AutoSize = true;
            this.lblJoinDate.Location = new System.Drawing.Point(350, 519);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(84, 16);
            this.lblJoinDate.TabIndex = 41;
            this.lblJoinDate.Text = "Starting Date";
            // 
            // dateTimeJoinDate
            // 
            this.dateTimeJoinDate.Location = new System.Drawing.Point(455, 513);
            this.dateTimeJoinDate.Name = "dateTimeJoinDate";
            this.dateTimeJoinDate.Size = new System.Drawing.Size(253, 22);
            this.dateTimeJoinDate.TabIndex = 40;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(31, 38);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(115, 16);
            this.lblSearch.TabIndex = 42;
            this.lblSearch.Text = "Search Employee";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(152, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(405, 22);
            this.txtSearch.TabIndex = 43;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(455, 564);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(170, 25);
            this.txtCity.TabIndex = 44;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(350, 570);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 18);
            this.lblCity.TabIndex = 45;
            this.lblCity.Text = "City";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(573, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 32);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 33);
            this.button1.TabIndex = 47;
            this.button1.Text = "Add New Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(140, 708);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 38);
            this.btnReset.TabIndex = 48;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnResetSearch
            // 
            this.btnResetSearch.Location = new System.Drawing.Point(681, 30);
            this.btnResetSearch.Name = "btnResetSearch";
            this.btnResetSearch.Size = new System.Drawing.Size(142, 32);
            this.btnResetSearch.TabIndex = 49;
            this.btnResetSearch.Text = "Reset Search";
            this.btnResetSearch.UseVisualStyleBackColor = true;
            this.btnResetSearch.Click += new System.EventHandler(this.btnResetSearch_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1259, 887);
            this.Controls.Add(this.btnResetSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblJoinDate);
            this.Controls.Add(this.dateTimeJoinDate);
            this.Controls.Add(this.lblBday);
            this.Controls.Add(this.dateTimeBday);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dgEmp);
            this.Controls.Add(this.lblDpt);
            this.Controls.Add(this.cmbDept);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.txtSales);
            this.Controls.Add(this.lblCommissionRate);
            this.Controls.Add(this.txtCommission);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.groupEmployeeType);
            this.Controls.Add(this.chkMarried);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.lblFname);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.VisibleChanged += new System.EventHandler(this.EmployeeForm_VisibleChanged);
            this.groupEmployeeType.ResumeLayout(false);
            this.groupEmployeeType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.CheckBox chkMarried;
        private System.Windows.Forms.RadioButton radioSalaried;
        private System.Windows.Forms.RadioButton radioBasePlusCommission;
        private System.Windows.Forms.RadioButton radioCommission;
        private System.Windows.Forms.GroupBox groupEmployeeType;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblCommissionRate;
        private System.Windows.Forms.TextBox txtCommission;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.Label lblDpt;
        private System.Windows.Forms.DataGridView dgEmp;
        private Splitter splitter1;
        private DateTimePicker dateTimeBday;
        private Label lblBday;
        private Label lblJoinDate;
        private DateTimePicker dateTimeJoinDate;
        private Label lblSearch;
        private TextBox txtSearch;
        private TextBox txtCity;
        private Label lblCity;
        private Button btnSearch;
        private Button button1;
        private Button btnReset;
        private Button btnResetSearch;
    }
}

