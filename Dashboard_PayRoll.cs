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
using System.IO;

namespace EmployeePayRollManagementSystem
{
    public partial class Dashboard_PayRoll : Form
    {
        string admin_email;
        string dashboard_string = ConfigurationManager.ConnectionStrings["payroll"].ConnectionString;
        public Dashboard_PayRoll(string admin_email)
        {
            this.admin_email = admin_email;
            InitializeComponent();
        }
        
        private void SfButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.log_pr.Show();
        }

        private void Btn_new_employee_Click(object sender, EventArgs e)
        {
            NewEmployees newEmp = new NewEmployees();
            newEmp.ShowDialog();
        }

        private void Btn_attendance_Click(object sender, EventArgs e)
        {
            EmployeesAttendance empAttendance = new EmployeesAttendance();
            empAttendance.ShowDialog();
        }

        private void Btn_payroll_Click(object sender, EventArgs e)
        {
            EmployeesPayRoll empPayRoll = new EmployeesPayRoll();
            empPayRoll.ShowDialog();
        }

        private void Btn_emp_record_Click(object sender, EventArgs e)
        {
            //EmployeesRecord empRecord = new EmployeesRecord();
            //empRecord.ShowDialog();
            if(panel_employees_record.Visible==false)
            {
                panel_employees_record.Visible = true;
            }
            else
            {
                panel_employees_record.Visible = false;
            }
        }

        private void Btn_author_Click(object sender, EventArgs e)
        {
            AboutAuthor adnan = new AboutAuthor();
            adnan.ShowDialog();
        }

        private void Dashboard_PayRoll_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emp_payrollDataSetEmployeesInformationTable.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.emp_payrollDataSetEmployeesInformationTable.employees);
            string image_query ="SELECT ad_email, ad_photo from admin where ad_email='"+admin_email+"'";
            SqlConnection dash_connection = new SqlConnection(dashboard_string);
            try
            {
                if(dash_connection.State==ConnectionState.Closed)
                {
                    dash_connection.Open();
                    SqlCommand dashCommand = new SqlCommand(image_query, dash_connection);
                    SqlDataReader reader = dashCommand.ExecuteReader();
                    if(reader.HasRows==true)
                    {
                        while(reader.Read())
                        {
                            lbl_admin_email.Text = "Admin Email: " + reader[0]; // label Text to display admin email
                            MemoryStream img = new MemoryStream((Byte[])reader[1]); // reading the bytes and passing those bytes to MemoryStream
                            pb_dashboard_admin.Image = Image.FromStream(img); // picture box to show the picture of admin
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
