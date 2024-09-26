
namespace EmployeePayRollManagementSystem
{
    partial class EmployeesAttendanceTable
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesAttendanceTable));
            this.dgv_attendance = new System.Windows.Forms.DataGridView();
            this.emp_payrollDataSetAttendance = new EmployeePayRollManagementSystem.emp_payrollDataSetAttendance();
            this.empattendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emp_attendanceTableAdapter = new EmployeePayRollManagementSystem.emp_payrollDataSetAttendanceTableAdapters.emp_attendanceTableAdapter();
            this.attendidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attenddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_search_employee = new System.Windows.Forms.TextBox();
            this.btn_search_employee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_attendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_payrollDataSetAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empattendanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_attendance
            // 
            this.dgv_attendance.AllowUserToAddRows = false;
            this.dgv_attendance.AllowUserToDeleteRows = false;
            this.dgv_attendance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_attendance.AutoGenerateColumns = false;
            this.dgv_attendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_attendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attendidDataGridViewTextBoxColumn,
            this.empidDataGridViewTextBoxColumn,
            this.empnameDataGridViewTextBoxColumn,
            this.empemailDataGridViewTextBoxColumn,
            this.attendstatusDataGridViewTextBoxColumn,
            this.attenddateDataGridViewTextBoxColumn});
            this.dgv_attendance.DataSource = this.empattendanceBindingSource;
            this.dgv_attendance.Location = new System.Drawing.Point(1, 149);
            this.dgv_attendance.Name = "dgv_attendance";
            this.dgv_attendance.ReadOnly = true;
            this.dgv_attendance.Size = new System.Drawing.Size(642, 394);
            this.dgv_attendance.TabIndex = 0;
            // 
            // emp_payrollDataSetAttendance
            // 
            this.emp_payrollDataSetAttendance.DataSetName = "emp_payrollDataSetAttendance";
            this.emp_payrollDataSetAttendance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empattendanceBindingSource
            // 
            this.empattendanceBindingSource.DataMember = "emp_attendance";
            this.empattendanceBindingSource.DataSource = this.emp_payrollDataSetAttendance;
            // 
            // emp_attendanceTableAdapter
            // 
            this.emp_attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // attendidDataGridViewTextBoxColumn
            // 
            this.attendidDataGridViewTextBoxColumn.DataPropertyName = "attend_id";
            this.attendidDataGridViewTextBoxColumn.HeaderText = "attend_id";
            this.attendidDataGridViewTextBoxColumn.Name = "attendidDataGridViewTextBoxColumn";
            this.attendidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "emp_id";
            this.empidDataGridViewTextBoxColumn.HeaderText = "emp_id";
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            // 
            // empnameDataGridViewTextBoxColumn
            // 
            this.empnameDataGridViewTextBoxColumn.DataPropertyName = "emp_name";
            this.empnameDataGridViewTextBoxColumn.HeaderText = "emp_name";
            this.empnameDataGridViewTextBoxColumn.Name = "empnameDataGridViewTextBoxColumn";
            // 
            // empemailDataGridViewTextBoxColumn
            // 
            this.empemailDataGridViewTextBoxColumn.DataPropertyName = "emp_email";
            this.empemailDataGridViewTextBoxColumn.HeaderText = "emp_email";
            this.empemailDataGridViewTextBoxColumn.Name = "empemailDataGridViewTextBoxColumn";
            // 
            // attendstatusDataGridViewTextBoxColumn
            // 
            this.attendstatusDataGridViewTextBoxColumn.DataPropertyName = "attend_status";
            this.attendstatusDataGridViewTextBoxColumn.HeaderText = "attend_status";
            this.attendstatusDataGridViewTextBoxColumn.Name = "attendstatusDataGridViewTextBoxColumn";
            // 
            // attenddateDataGridViewTextBoxColumn
            // 
            this.attenddateDataGridViewTextBoxColumn.DataPropertyName = "attend_date";
            this.attenddateDataGridViewTextBoxColumn.HeaderText = "attend_date";
            this.attenddateDataGridViewTextBoxColumn.Name = "attenddateDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(107, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Employee:";
            // 
            // tb_search_employee
            // 
            this.tb_search_employee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_search_employee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_search_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search_employee.Location = new System.Drawing.Point(225, 68);
            this.tb_search_employee.Name = "tb_search_employee";
            this.tb_search_employee.Size = new System.Drawing.Size(218, 26);
            this.tb_search_employee.TabIndex = 2;
            this.tb_search_employee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_search_employee_KeyPress);
            // 
            // btn_search_employee
            // 
            this.btn_search_employee.BackColor = System.Drawing.Color.Transparent;
            this.btn_search_employee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search_employee.BackgroundImage")));
            this.btn_search_employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search_employee.Location = new System.Drawing.Point(454, 65);
            this.btn_search_employee.Name = "btn_search_employee";
            this.btn_search_employee.Size = new System.Drawing.Size(60, 29);
            this.btn_search_employee.TabIndex = 3;
            this.btn_search_employee.UseVisualStyleBackColor = false;
            this.btn_search_employee.Click += new System.EventHandler(this.Btn_search_employee_Click);
            // 
            // EmployeesAttendanceTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 545);
            this.Controls.Add(this.btn_search_employee);
            this.Controls.Add(this.tb_search_employee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_attendance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeesAttendanceTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmployeesAttendanceTable";
            this.Load += new System.EventHandler(this.EmployeesAttendanceTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_attendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_payrollDataSetAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empattendanceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_attendance;
        private emp_payrollDataSetAttendance emp_payrollDataSetAttendance;
        private System.Windows.Forms.BindingSource empattendanceBindingSource;
        private emp_payrollDataSetAttendanceTableAdapters.emp_attendanceTableAdapter emp_attendanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attenddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_search_employee;
        private System.Windows.Forms.Button btn_search_employee;
    }
}