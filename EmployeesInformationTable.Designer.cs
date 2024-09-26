
namespace EmployeePayRollManagementSystem
{
    partial class EmployeesInformationTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesInformationTable));
            this.emp_payrollDataSetInformationTable = new EmployeePayRollManagementSystem.emp_payrollDataSetInformationTable();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new EmployeePayRollManagementSystem.emp_payrollDataSetInformationTableTableAdapters.employeesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empfirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emplastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empcontactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empqualificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empcityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empprovinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empcountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empapplieddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empcnicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empdesignationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empbloodgroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empbasicsalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empphotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.emp_payrollDataSetInformationTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // emp_payrollDataSetInformationTable
            // 
            this.emp_payrollDataSetInformationTable.DataSetName = "emp_payrollDataSetInformationTable";
            this.emp_payrollDataSetInformationTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.emp_payrollDataSetInformationTable;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empidDataGridViewTextBoxColumn,
            this.empfirstnameDataGridViewTextBoxColumn,
            this.emplastnameDataGridViewTextBoxColumn,
            this.empemailDataGridViewTextBoxColumn,
            this.empcontactDataGridViewTextBoxColumn,
            this.empqualificationDataGridViewTextBoxColumn,
            this.empageDataGridViewTextBoxColumn,
            this.empcityDataGridViewTextBoxColumn,
            this.empprovinceDataGridViewTextBoxColumn,
            this.empcountryDataGridViewTextBoxColumn,
            this.empapplieddateDataGridViewTextBoxColumn,
            this.empcnicDataGridViewTextBoxColumn,
            this.empdesignationDataGridViewTextBoxColumn,
            this.empbloodgroupDataGridViewTextBoxColumn,
            this.empbasicsalaryDataGridViewTextBoxColumn,
            this.empaddressDataGridViewTextBoxColumn,
            this.empphotoDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.employeesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1210, 537);
            this.dataGridView1.TabIndex = 0;
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "emp_id";
            this.empidDataGridViewTextBoxColumn.HeaderText = "emp_id";
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            this.empidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empfirstnameDataGridViewTextBoxColumn
            // 
            this.empfirstnameDataGridViewTextBoxColumn.DataPropertyName = "emp_first_name";
            this.empfirstnameDataGridViewTextBoxColumn.HeaderText = "emp_first_name";
            this.empfirstnameDataGridViewTextBoxColumn.Name = "empfirstnameDataGridViewTextBoxColumn";
            this.empfirstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emplastnameDataGridViewTextBoxColumn
            // 
            this.emplastnameDataGridViewTextBoxColumn.DataPropertyName = "emp_last_name";
            this.emplastnameDataGridViewTextBoxColumn.HeaderText = "emp_last_name";
            this.emplastnameDataGridViewTextBoxColumn.Name = "emplastnameDataGridViewTextBoxColumn";
            this.emplastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empemailDataGridViewTextBoxColumn
            // 
            this.empemailDataGridViewTextBoxColumn.DataPropertyName = "emp_email";
            this.empemailDataGridViewTextBoxColumn.HeaderText = "emp_email";
            this.empemailDataGridViewTextBoxColumn.Name = "empemailDataGridViewTextBoxColumn";
            this.empemailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empcontactDataGridViewTextBoxColumn
            // 
            this.empcontactDataGridViewTextBoxColumn.DataPropertyName = "emp_contact";
            this.empcontactDataGridViewTextBoxColumn.HeaderText = "emp_contact";
            this.empcontactDataGridViewTextBoxColumn.Name = "empcontactDataGridViewTextBoxColumn";
            this.empcontactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empqualificationDataGridViewTextBoxColumn
            // 
            this.empqualificationDataGridViewTextBoxColumn.DataPropertyName = "emp_qualification";
            this.empqualificationDataGridViewTextBoxColumn.HeaderText = "emp_qualification";
            this.empqualificationDataGridViewTextBoxColumn.Name = "empqualificationDataGridViewTextBoxColumn";
            this.empqualificationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empageDataGridViewTextBoxColumn
            // 
            this.empageDataGridViewTextBoxColumn.DataPropertyName = "emp_age";
            this.empageDataGridViewTextBoxColumn.HeaderText = "emp_age";
            this.empageDataGridViewTextBoxColumn.Name = "empageDataGridViewTextBoxColumn";
            this.empageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empcityDataGridViewTextBoxColumn
            // 
            this.empcityDataGridViewTextBoxColumn.DataPropertyName = "emp_city";
            this.empcityDataGridViewTextBoxColumn.HeaderText = "emp_city";
            this.empcityDataGridViewTextBoxColumn.Name = "empcityDataGridViewTextBoxColumn";
            this.empcityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empprovinceDataGridViewTextBoxColumn
            // 
            this.empprovinceDataGridViewTextBoxColumn.DataPropertyName = "emp_province";
            this.empprovinceDataGridViewTextBoxColumn.HeaderText = "emp_province";
            this.empprovinceDataGridViewTextBoxColumn.Name = "empprovinceDataGridViewTextBoxColumn";
            this.empprovinceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empcountryDataGridViewTextBoxColumn
            // 
            this.empcountryDataGridViewTextBoxColumn.DataPropertyName = "emp_country";
            this.empcountryDataGridViewTextBoxColumn.HeaderText = "emp_country";
            this.empcountryDataGridViewTextBoxColumn.Name = "empcountryDataGridViewTextBoxColumn";
            this.empcountryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empapplieddateDataGridViewTextBoxColumn
            // 
            this.empapplieddateDataGridViewTextBoxColumn.DataPropertyName = "emp_applieddate";
            this.empapplieddateDataGridViewTextBoxColumn.HeaderText = "emp_applieddate";
            this.empapplieddateDataGridViewTextBoxColumn.Name = "empapplieddateDataGridViewTextBoxColumn";
            this.empapplieddateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empcnicDataGridViewTextBoxColumn
            // 
            this.empcnicDataGridViewTextBoxColumn.DataPropertyName = "emp_cnic";
            this.empcnicDataGridViewTextBoxColumn.HeaderText = "emp_cnic";
            this.empcnicDataGridViewTextBoxColumn.Name = "empcnicDataGridViewTextBoxColumn";
            this.empcnicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empdesignationDataGridViewTextBoxColumn
            // 
            this.empdesignationDataGridViewTextBoxColumn.DataPropertyName = "emp_designation";
            this.empdesignationDataGridViewTextBoxColumn.HeaderText = "emp_designation";
            this.empdesignationDataGridViewTextBoxColumn.Name = "empdesignationDataGridViewTextBoxColumn";
            this.empdesignationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empbloodgroupDataGridViewTextBoxColumn
            // 
            this.empbloodgroupDataGridViewTextBoxColumn.DataPropertyName = "emp_bloodgroup";
            this.empbloodgroupDataGridViewTextBoxColumn.HeaderText = "emp_bloodgroup";
            this.empbloodgroupDataGridViewTextBoxColumn.Name = "empbloodgroupDataGridViewTextBoxColumn";
            this.empbloodgroupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empbasicsalaryDataGridViewTextBoxColumn
            // 
            this.empbasicsalaryDataGridViewTextBoxColumn.DataPropertyName = "emp_basicsalary";
            this.empbasicsalaryDataGridViewTextBoxColumn.HeaderText = "emp_basicsalary";
            this.empbasicsalaryDataGridViewTextBoxColumn.Name = "empbasicsalaryDataGridViewTextBoxColumn";
            this.empbasicsalaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empaddressDataGridViewTextBoxColumn
            // 
            this.empaddressDataGridViewTextBoxColumn.DataPropertyName = "emp_address";
            this.empaddressDataGridViewTextBoxColumn.HeaderText = "emp_address";
            this.empaddressDataGridViewTextBoxColumn.Name = "empaddressDataGridViewTextBoxColumn";
            this.empaddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empphotoDataGridViewImageColumn
            // 
            this.empphotoDataGridViewImageColumn.DataPropertyName = "emp_photo";
            this.empphotoDataGridViewImageColumn.HeaderText = "emp_photo";
            this.empphotoDataGridViewImageColumn.Name = "empphotoDataGridViewImageColumn";
            this.empphotoDataGridViewImageColumn.ReadOnly = true;
            // 
            // EmployeesInformationTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 537);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeesInformationTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmployeesInformationTable";
            this.Load += new System.EventHandler(this.EmployeesInformationTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emp_payrollDataSetInformationTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private emp_payrollDataSetInformationTable emp_payrollDataSetInformationTable;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private emp_payrollDataSetInformationTableTableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empfirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emplastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empcontactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empqualificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empcityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empprovinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empcountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empapplieddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empcnicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empdesignationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empbloodgroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empbasicsalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn empphotoDataGridViewImageColumn;
    }
}