using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

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

            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
