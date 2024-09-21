using System;
using System.Data;
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
    class NewEmployeesInformation
    {
        string newEmpString = ConfigurationManager.ConnectionStrings["payroll"].ConnectionString;
        string first_name, last_name,email, qualification, city, province, country, applieddate, designation, bloodgroup,address;
        int contact,age, cnic,basicsalary;
        PictureBox pb;
       

        public NewEmployeesInformation(string fname, string lname, string email, int contact, string qualification , int age, string city,
            string province,string country, string applieddate,int cnic, string designation, string bloodgroup,int basicsalary, string address,
            PictureBox pb)
        {
            this.first_name = fname;
            this.last_name = lname;
            this.email = email;
            this.qualification = qualification;
            this.city = city;
            this.province = province;
            this.country = country;
            this.applieddate = applieddate;
            this.designation = designation;
            this.bloodgroup = bloodgroup;
            this.address = address;
            this.contact = contact;
            this.age = age;
            this.cnic = cnic;
            this.basicsalary = basicsalary;
            this.pb = pb;
        }
        public void saveNewEmployeeInformation()
        {
            string emp_insert_query = "INSERT INTO employees(emp_fame,emp_lname,emp_email,emp_contact,emp_qualification," +
                "emp_age,emp_city,emp_province,emp_country,emp_applieddate,emp_cnic,emp_designation,emp_bloodgroup," +
                "emp_basicsalary,emp_address,emp_photo) VALUES(@fname,@lname,@email,@contact,@qualification,@age," +
                "@city,@province,@country,@applieddate,@cnic,@designation,@bloodgroup,@basicsalary,@address,@photo)";
            SqlConnection newEmpConnection = new SqlConnection(newEmpString);
            try
            {
                if(newEmpConnection.State==ConnectionState.Closed)
                {
                    newEmpConnection.Open();
                    SqlCommand empCommand = new SqlCommand(emp_insert_query, newEmpConnection);
                    empCommand.Parameters.AddWithValue("@fname",this.first_name);
                    empCommand.Parameters.AddWithValue("@lname",this.last_name);
                    empCommand.Parameters.AddWithValue("@email",this.email);
                    empCommand.Parameters.AddWithValue("@contact",this.qualification);
                    empCommand.Parameters.AddWithValue("@qualification",this.city);
                    empCommand.Parameters.AddWithValue("@age",this.province);
                    empCommand.Parameters.AddWithValue("@city",this.country);
                    empCommand.Parameters.AddWithValue("@province",this.applieddate);
                    empCommand.Parameters.AddWithValue("@country",this.designation);
                    empCommand.Parameters.AddWithValue("@applieddate",this.bloodgroup);
                    empCommand.Parameters.AddWithValue("@cnic",this.address);
                    empCommand.Parameters.AddWithValue("@designation",this.contact);
                    empCommand.Parameters.AddWithValue("@bloodgroup",this.age);
                    empCommand.Parameters.AddWithValue("@basicsalary",this.cnic);
                    empCommand.Parameters.AddWithValue("@address",this.basicsalary);
                    empCommand.Parameters.AddWithValue("@photo", changeImageIntoBytes());
                    empCommand.ExecuteNonQuery();
                    MessageBox.Show("Saved information successfully!", "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    newEmpConnection.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private Byte[] changeImageIntoBytes()
        {
            MemoryStream newEmpStream = new MemoryStream();
            this.pb.Image.Save(newEmpStream, this.pb.Image.RawFormat);
            return newEmpStream.GetBuffer();
        }
    }
}
