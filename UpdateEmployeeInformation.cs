using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace EmployeePayRollManagementSystem
{
    class UpdateEmployeeInformation
    {
        string update_string = ConfigurationManager.ConnectionStrings["payroll"].ConnectionString;
        public bool updateEmployeeInformation(int emp_id,string emp_first_name,string emp_last_name, string emp_email,
            long emp_contact, string emp_qualification, int emp_age, string emp_city, string emp_province, string emp_country,
            string emp_applieddate, long emp_cnic, string emp_designation, string emp_bloodgroup, int emp_basicsalary, string emp_address,
            PictureBox emp_pb)
        {
            string update_query = "UPDATE employees set emp_first_name=@fname, emp_last_name=@lname, emp_email=@email,emp_contact=@contact," +
                "emp_qualification=@qualification, emp_age=@age,emp_city=@city,emp_province=@province,emp_country=@country,emp_applieddate=@applieddate," +
                "emp_cnic=@cnic, emp_designation=@designation,emp_bloodgroup=@bloodgroup,emp_basicsalary=@basicsalary,emp_address=@address,emp_photo=@photo " +
                "where emp_id=@id";
            try
            {
                SqlConnection update_connection = new SqlConnection(update_string);
                SqlCommand update_command = new SqlCommand(update_query, update_connection);
                update_connection.Open();
                update_command.Parameters.AddWithValue("@fname",emp_first_name);
                update_command.Parameters.AddWithValue("@lname",emp_last_name);
                update_command.Parameters.AddWithValue("@email",emp_email);
                update_command.Parameters.AddWithValue("@contact",emp_contact);
                update_command.Parameters.AddWithValue("@qualification",emp_qualification);
                update_command.Parameters.AddWithValue("@age",emp_age);
                update_command.Parameters.AddWithValue("@city",emp_city);
                update_command.Parameters.AddWithValue("@province",emp_province);
                update_command.Parameters.AddWithValue("@country",emp_country);
                update_command.Parameters.AddWithValue("@applieddate",emp_applieddate);
                update_command.Parameters.AddWithValue("@cnic",emp_cnic);
                update_command.Parameters.AddWithValue("@designation",emp_designation);
                update_command.Parameters.AddWithValue("@bloodgroup",emp_bloodgroup);
                update_command.Parameters.AddWithValue("@basicsalary",emp_basicsalary);
                MemoryStream imageToBytes = new MemoryStream();
                emp_pb.Image.Save(imageToBytes, emp_pb.Image.RawFormat);
                Byte[] imgBytes = imageToBytes.GetBuffer();
                update_command.Parameters.AddWithValue("@photo",imgBytes);
                update_command.ExecuteNonQuery();
                MessageBox.Show("Information update successfully.","Employee PayRoll Management System",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Employees PayRoll Management System",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
