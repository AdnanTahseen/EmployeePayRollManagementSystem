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
    public partial class EmployeesAttendance : Form
    {
        static bool result;
        string attendance_string = ConfigurationManager.ConnectionStrings["payroll"].ConnectionString;
        public EmployeesAttendance()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeesAttendance_Load(object sender, EventArgs e)
        {
            string attendance_query = "SELECT emp_id from employees";
            SqlConnection attendance_connection = new SqlConnection(attendance_string);
            try
            {
                attendance_connection.Open();
                SqlCommand attendance_command = new SqlCommand(attendance_query, attendance_connection);
                SqlDataReader attendance_reader = attendance_command.ExecuteReader();
                while(attendance_reader.Read())
                {
                    cb_emp_id.Items.Add(attendance_reader[0]);
                }
                attendance_connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(),"Employees PayRoll Management System",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void Cb_emp_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            int emp_id = int.Parse(cb_emp_id.Text);
            string data_query = "SELECT emp_first_name, emp_last_name,emp_email,emp_photo from employees where emp_id=@empID";
            SqlConnection data_connection = new SqlConnection(attendance_string);
            try
            {
                data_connection.Open();
                SqlCommand data_command = new SqlCommand(data_query,data_connection);
                data_command.Parameters.AddWithValue("@empID",emp_id);
                SqlDataReader data_reader = data_command.ExecuteReader();
                while(data_reader.Read())
                {
                    lbl_name.Text = data_reader[0].ToString() +" "+data_reader[1].ToString();
                    lbl_email.Text = data_reader[2].ToString();
                    MemoryStream emp_photo = new MemoryStream((Byte[])data_reader[3]);
                    pb_emp_photo.Image = Image.FromStream(emp_photo);
                }
                data_connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(),"Employees PayRoll Management System",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Btn_save_attendance_Click(object sender, EventArgs e)
        {
            bool checkAvailability;
            string attendance_query = "INSERT INTO emp_attendance(emp_id,emp_name,emp_email,attend_status,attend_date)" +
                "values(@emp_id,@emp_name,@emp_email,@attend_status,@attend_date)";
            SqlConnection attendConnection = new SqlConnection(attendance_string);
            if (this.cb_emp_id.Text != "" && this.lbl_name.Text!="" && this.lbl_email.Text!="" && this.cb_attend_status.Text!="" && this.dtp_emp_attendance.Text!="")
            {
                checkAvailability = checkAttendanceIfSaved(int.Parse(this.cb_emp_id.Text),this.dtp_emp_attendance.Text);
                if(checkAvailability==true)
                {
                    MessageBox.Show("Employee's attendance is already saved","Employees PayRoll Management System",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    attendConnection.Open();
                    SqlCommand attend_command = new SqlCommand(attendance_query, attendConnection);
                    attend_command.Parameters.AddWithValue("@emp_id", int.Parse(this.cb_emp_id.Text));
                    attend_command.Parameters.AddWithValue("@emp_name", this.lbl_name.Text);
                    attend_command.Parameters.AddWithValue("@emp_email", this.lbl_email.Text);
                    attend_command.Parameters.AddWithValue("@attend_status", this.cb_attend_status.Text);
                    attend_command.Parameters.AddWithValue("@attend_date", this.dtp_emp_attendance.Text);
                    attend_command.ExecuteNonQuery();
                    MessageBox.Show("Attendance saved successfully", "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    attendConnection.Close();
                }
                
            }
            else
            {
                MessageBox.Show("One or more fields empty!","Employees PayRoll Management System",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private bool checkAttendanceIfSaved(int v, string date)
        {
            
            string check_query = "SELECT * FROM emp_attendance where emp_id=@empID and attend_date=@attendDate";
            SqlConnection checkDataConnection = new SqlConnection(attendance_string);
            try
            {

                checkDataConnection.Open();
                SqlCommand checkCommand = new SqlCommand(check_query,checkDataConnection);
                checkCommand.Parameters.AddWithValue("@empID",v);
                checkCommand.Parameters.AddWithValue("@attendDate",date);
                //checkCommand.Parameters.AddWithValue("@attendStatus", status);
                SqlDataReader checkReader = checkCommand.ExecuteReader();
                if(checkReader.HasRows==true)
                {
                    result= true;
                }
                else
                {
                    result = false;
                }
                checkDataConnection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            return result;
        }

        private void Btn_show_attendance_table_Click(object sender, EventArgs e)
        {
            EmployeesAttendanceTable eat = new EmployeesAttendanceTable();
            eat.ShowDialog();
        }
    }
}
