using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace EmployeePayRollManagementSystem
{
    internal class SaveNewEmployeeInformation
    {
        private string newEmpString = ConfigurationManager.ConnectionStrings["payroll"].ConnectionString;

        public bool saveNewEmployeeInformation(string fname, string lname, string email, long contact, string qualification, int age, string city,
            string province, string country, string applieddate, long cnic, string designation, string bloodgroup, int basicsalary, string address,
            PictureBox pb)
        {
            string emp_insert_query = "INSERT INTO employees(emp_first_name,emp_last_name,emp_email,emp_contact,emp_qualification," +
                "emp_age,emp_city,emp_province,emp_country,emp_applieddate,emp_cnic,emp_designation,emp_bloodgroup," +
                "emp_basicsalary,emp_address,emp_photo) VALUES(@fname,@lname,@email,@contact,@qualification,@age," +
                "@city,@province,@country,@applieddate,@cnic,@designation,@bloodgroup,@basicsalary,@address,@photo)";
            SqlConnection newEmpConnection = new SqlConnection(newEmpString);
            try
            {
                if (newEmpConnection.State == ConnectionState.Closed)
                {
                    newEmpConnection.Open();
                    SqlCommand empCommand = new SqlCommand(emp_insert_query, newEmpConnection);
                    empCommand.Parameters.AddWithValue("@fname", fname);
                    empCommand.Parameters.AddWithValue("@lname", lname);
                    empCommand.Parameters.AddWithValue("@email", email);
                    empCommand.Parameters.AddWithValue("@contact", contact);
                    empCommand.Parameters.AddWithValue("@qualification", qualification);
                    empCommand.Parameters.AddWithValue("@age", age);
                    empCommand.Parameters.AddWithValue("@city", city);
                    empCommand.Parameters.AddWithValue("@province", province);
                    empCommand.Parameters.AddWithValue("@country", country);
                    empCommand.Parameters.AddWithValue("@applieddate", applieddate);
                    empCommand.Parameters.AddWithValue("@cnic", cnic);
                    empCommand.Parameters.AddWithValue("@designation", designation);
                    empCommand.Parameters.AddWithValue("@bloodgroup", bloodgroup);
                    empCommand.Parameters.AddWithValue("@basicsalary", basicsalary);
                    empCommand.Parameters.AddWithValue("@address", address);
                    Byte[] img_bytes = changeImageIntoBytes(pb);
                    empCommand.Parameters.AddWithValue("@photo", img_bytes);
                    empCommand.ExecuteNonQuery();
                    MessageBox.Show("Saved information successfully!", "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    newEmpConnection.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Byte[] changeImageIntoBytes(PictureBox pb)
        {
            MemoryStream newEmpStream = new MemoryStream();
            pb.Image.Save(newEmpStream, pb.Image.RawFormat);
            return newEmpStream.GetBuffer();
        }
    }
}