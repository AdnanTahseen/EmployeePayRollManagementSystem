using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeePayRollManagementSystem
{
    class Practice
    {
        string conn_string = ConfigurationManager.ConnectionStrings["payroll"].ConnectionString;
        public Practice()
        {

        }
        public void insertInformation(string fname, string lname,string email, long contact,string qualification,int age, string city,string province, string country,
            string applieddate, long cnic, string designation, string bloodgroup, int basicsalary, string address, PictureBox photo)
        {
            string practice_query = "insert into emp_practice(emp_first_name,emp_last_name,emp_email,emp_contact," +
                "emp_qualification,emp_age,emp_city,emp_province,emp_country,emp_applieddate,emp_cnic,emp_designation,emp_bloodgroup,emp_basicsalary," +
                "emp_address,emp_photo)" +
                " values(@fname,@lname,@email,@contact,@qualification,@age,@city,@province,@country,@applieddate,@cnic,@designation,@bloodgroup," +
                "@basicsalary,@address,@photo)";
            try
            {
                SqlConnection insert_connection = new SqlConnection(conn_string);
                insert_connection.Open();
                SqlCommand insert_command = new SqlCommand(practice_query, insert_connection);
                insert_command.Parameters.AddWithValue("@fname", fname);
                insert_command.Parameters.AddWithValue("@lname", lname);
                insert_command.Parameters.AddWithValue("@email", email);
                insert_command.Parameters.AddWithValue("@contact", contact);
                insert_command.Parameters.AddWithValue("@qualification", qualification);
                insert_command.Parameters.AddWithValue("@age", age);
                insert_command.Parameters.AddWithValue("@city", city);
                insert_command.Parameters.AddWithValue("@province", province);
                insert_command.Parameters.AddWithValue("@country", country);
                insert_command.Parameters.AddWithValue("@applieddate", applieddate);
                insert_command.Parameters.AddWithValue("@cnic", cnic);
                insert_command.Parameters.AddWithValue("@designation", designation);
                insert_command.Parameters.AddWithValue("@bloodgroup", bloodgroup);
                insert_command.Parameters.AddWithValue("@basicsalary", basicsalary);
                insert_command.Parameters.AddWithValue("@address", address);
                insert_command.Parameters.AddWithValue("@photo", changeImageIntoBytes(photo));
                insert_command.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Data inserted successfully.");
                insert_connection.Close();
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }

        }

        private Byte[] changeImageIntoBytes(PictureBox photo)
        {
            MemoryStream ms = new MemoryStream();
            photo.Image.Save(ms, photo.Image.RawFormat);
            return ms.GetBuffer();
        }
    }
}
