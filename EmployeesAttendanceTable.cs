using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace EmployeePayRollManagementSystem
{
    public partial class EmployeesAttendanceTable : Form
    {
        string search_string = ConfigurationManager.ConnectionStrings["payroll"].ConnectionString;
        public EmployeesAttendanceTable()
        {
            InitializeComponent();
        }

        private void EmployeesAttendanceTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emp_payrollDataSetAttendance.emp_attendance' table. You can move, or remove it, as needed.
            this.emp_attendanceTableAdapter.Fill(this.emp_payrollDataSetAttendance.emp_attendance);

        }

        private void Btn_search_employee_Click(object sender, EventArgs e)
        {
            string search_query = "SELECT * FROM emp_attendance where emp_name like '"+tb_search_employee.Text+"%'";
            SqlConnection search_connection = new SqlConnection(search_string);
            try
            {
                SqlCommand search_command = new SqlCommand(search_query, search_connection);
                //SqlDataReader dr= search_command.ExecuteReader();
                DataTable search_table = new DataTable();
                SqlDataAdapter search_adapter = new SqlDataAdapter(search_command);
                search_adapter.Fill(search_table);
                dgv_attendance.DataSource = search_table;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(),"Employees PayRoll Management System",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void loadTable()
        {
            string search_query = "SELECT * FROM emp_attendance";
            SqlConnection search_connection = new SqlConnection(search_string);
            try
            {
                SqlCommand search_command = new SqlCommand(search_query, search_connection);
                DataTable search_table = new DataTable();
                SqlDataAdapter search_adapter = new SqlDataAdapter(search_command);
                search_adapter.Fill(search_table);
                dgv_attendance.DataSource = search_table;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tb_search_employee_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key_removed = e.KeyChar;
            if(key_removed==8)
            {
                loadTable();
            }
        }
    }
}
