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
    public partial class EmployeesFinalSalaryTable : Form
    {
        public EmployeesFinalSalaryTable()
        {
            InitializeComponent();
        }

        private void EmployeesFinalSalaryTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emp_payrollDataSetFinalSalaryTable.finalsalary' table. You can move, or remove it, as needed.
            this.finalsalaryTableAdapter.Fill(this.emp_payrollDataSetFinalSalaryTable.finalsalary);

        }

        private void Btn_final_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
