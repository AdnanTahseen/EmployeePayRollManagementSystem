
namespace EmployeePayRollManagementSystem
{
    partial class EmployeesFinalSalaryTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesFinalSalaryTable));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emp_payrollDataSetFinalSalaryTable = new EmployeePayRollManagementSystem.emp_payrollDataSetFinalSalaryTable();
            this.finalsalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalsalaryTableAdapter = new EmployeePayRollManagementSystem.emp_payrollDataSetFinalSalaryTableTableAdapters.finalsalaryTableAdapter();
            this.finalsalidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empcontactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salmonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empabsenteesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnetsalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empdailywageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empfinalsalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_final_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_payrollDataSetFinalSalaryTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalsalaryBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.finalsalidDataGridViewTextBoxColumn,
            this.empidDataGridViewTextBoxColumn,
            this.empnameDataGridViewTextBoxColumn,
            this.empemailDataGridViewTextBoxColumn,
            this.empcontactDataGridViewTextBoxColumn,
            this.salmonthDataGridViewTextBoxColumn,
            this.salyearDataGridViewTextBoxColumn,
            this.empabsenteesDataGridViewTextBoxColumn,
            this.empnetsalaryDataGridViewTextBoxColumn,
            this.empdailywageDataGridViewTextBoxColumn,
            this.empfinalsalaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.finalsalaryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 92);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1109, 431);
            this.dataGridView1.TabIndex = 0;
            // 
            // emp_payrollDataSetFinalSalaryTable
            // 
            this.emp_payrollDataSetFinalSalaryTable.DataSetName = "emp_payrollDataSetFinalSalaryTable";
            this.emp_payrollDataSetFinalSalaryTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // finalsalaryBindingSource
            // 
            this.finalsalaryBindingSource.DataMember = "finalsalary";
            this.finalsalaryBindingSource.DataSource = this.emp_payrollDataSetFinalSalaryTable;
            // 
            // finalsalaryTableAdapter
            // 
            this.finalsalaryTableAdapter.ClearBeforeFill = true;
            // 
            // finalsalidDataGridViewTextBoxColumn
            // 
            this.finalsalidDataGridViewTextBoxColumn.DataPropertyName = "final_sal_id";
            this.finalsalidDataGridViewTextBoxColumn.HeaderText = "final_sal_id";
            this.finalsalidDataGridViewTextBoxColumn.Name = "finalsalidDataGridViewTextBoxColumn";
            this.finalsalidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "emp_id";
            this.empidDataGridViewTextBoxColumn.HeaderText = "emp_id";
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            this.empidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empnameDataGridViewTextBoxColumn
            // 
            this.empnameDataGridViewTextBoxColumn.DataPropertyName = "emp_name";
            this.empnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.empnameDataGridViewTextBoxColumn.Name = "empnameDataGridViewTextBoxColumn";
            this.empnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empemailDataGridViewTextBoxColumn
            // 
            this.empemailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.empemailDataGridViewTextBoxColumn.HeaderText = "emp_email";
            this.empemailDataGridViewTextBoxColumn.Name = "empemailDataGridViewTextBoxColumn";
            this.empemailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empcontactDataGridViewTextBoxColumn
            // 
            this.empcontactDataGridViewTextBoxColumn.DataPropertyName = "emp_contact";
            this.empcontactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.empcontactDataGridViewTextBoxColumn.Name = "empcontactDataGridViewTextBoxColumn";
            this.empcontactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salmonthDataGridViewTextBoxColumn
            // 
            this.salmonthDataGridViewTextBoxColumn.DataPropertyName = "sal_month";
            this.salmonthDataGridViewTextBoxColumn.HeaderText = "Salary Month";
            this.salmonthDataGridViewTextBoxColumn.Name = "salmonthDataGridViewTextBoxColumn";
            this.salmonthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salyearDataGridViewTextBoxColumn
            // 
            this.salyearDataGridViewTextBoxColumn.DataPropertyName = "sal_year";
            this.salyearDataGridViewTextBoxColumn.HeaderText = "Salary Year";
            this.salyearDataGridViewTextBoxColumn.Name = "salyearDataGridViewTextBoxColumn";
            this.salyearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empabsenteesDataGridViewTextBoxColumn
            // 
            this.empabsenteesDataGridViewTextBoxColumn.DataPropertyName = "emp_absentees";
            this.empabsenteesDataGridViewTextBoxColumn.HeaderText = "Absentees";
            this.empabsenteesDataGridViewTextBoxColumn.Name = "empabsenteesDataGridViewTextBoxColumn";
            this.empabsenteesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empnetsalaryDataGridViewTextBoxColumn
            // 
            this.empnetsalaryDataGridViewTextBoxColumn.DataPropertyName = "emp_netsalary";
            this.empnetsalaryDataGridViewTextBoxColumn.HeaderText = "Net Salary";
            this.empnetsalaryDataGridViewTextBoxColumn.Name = "empnetsalaryDataGridViewTextBoxColumn";
            this.empnetsalaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empdailywageDataGridViewTextBoxColumn
            // 
            this.empdailywageDataGridViewTextBoxColumn.DataPropertyName = "emp_dailywage";
            this.empdailywageDataGridViewTextBoxColumn.HeaderText = "Daily Wage";
            this.empdailywageDataGridViewTextBoxColumn.Name = "empdailywageDataGridViewTextBoxColumn";
            this.empdailywageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empfinalsalaryDataGridViewTextBoxColumn
            // 
            this.empfinalsalaryDataGridViewTextBoxColumn.DataPropertyName = "emp_finalsalary";
            this.empfinalsalaryDataGridViewTextBoxColumn.HeaderText = "Final Salary";
            this.empfinalsalaryDataGridViewTextBoxColumn.Name = "empfinalsalaryDataGridViewTextBoxColumn";
            this.empfinalsalaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_final_close);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 38);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_final_close
            // 
            this.btn_final_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_final_close.BackgroundImage")));
            this.btn_final_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_final_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_final_close.Location = new System.Drawing.Point(1102, 0);
            this.btn_final_close.Name = "btn_final_close";
            this.btn_final_close.Size = new System.Drawing.Size(31, 38);
            this.btn_final_close.TabIndex = 1;
            this.btn_final_close.UseVisualStyleBackColor = true;
            this.btn_final_close.Click += new System.EventHandler(this.Btn_final_close_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(426, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employees Final Salary Table";
            // 
            // EmployeesFinalSalaryTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeesFinalSalaryTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmployeesFinalSalaryTable";
            this.Load += new System.EventHandler(this.EmployeesFinalSalaryTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_payrollDataSetFinalSalaryTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalsalaryBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private emp_payrollDataSetFinalSalaryTable emp_payrollDataSetFinalSalaryTable;
        private System.Windows.Forms.BindingSource finalsalaryBindingSource;
        private emp_payrollDataSetFinalSalaryTableTableAdapters.finalsalaryTableAdapter finalsalaryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalsalidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empcontactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salmonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empabsenteesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnetsalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empdailywageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empfinalsalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_final_close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}