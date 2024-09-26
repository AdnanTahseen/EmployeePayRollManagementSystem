using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeePayRollManagementSystem
{
    public partial class EmployeesInformationTable : Form
    {
        public EmployeesInformationTable()
        {
            InitializeComponent();
        }

        private void EmployeesInformationTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emp_payrollDataSetInformationTable.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.emp_payrollDataSetInformationTable.employees);
            DataGridViewImageColumn emp_image_col = new DataGridViewImageColumn();
            emp_image_col = (DataGridViewImageColumn)dataGridView1.Columns[16];
            emp_image_col.ImageLayout = DataGridViewImageCellLayout.Zoom;

        }
    }
}
