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
using System.Text.RegularExpressions;

namespace EmployeePayRollManagementSystem
{
    public partial class Registration_PayRoll : Form
    {
        string payRoll_reg_connection = ConfigurationManager.ConnectionStrings["payroll"].ConnectionString;
        string email_regex_string = "^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";
        string password_regex_string = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
        public Registration_PayRoll()
        {
            InitializeComponent();
        }
        private void btn_reg_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_registration_Click(object sender, EventArgs e)
        {
            if(tb_fname.Text!="" && tb_lname.Text!="" && tb_email.Text!=""&& tb_contact.Text!="" && tb_address.Text!="" && tb_password.Text!="" && pb_admin.Image!=null)
            {
                insertDataIntoDatabase();
            }
            else
            {
                MessageBox.Show("One or more fields empty.", "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void insertDataIntoDatabase()
        {
            //Image admin_photo;
            string insert_query = "INSERT INTO admin(ad_first_name,ad_last_name,ad_email,ad_password,ad_repassword,ad_contact,ad_address,ad_photo)" +
               "VALUES(@fname, @lname,@email,@password,@repassword,@contact,@address,@photo) ";
            try
            {
                SqlConnection payRoll = new SqlConnection(payRoll_reg_connection);
                if (payRoll.State == ConnectionState.Closed)
                {
                    payRoll.Open();
                    SqlCommand payCommand = new SqlCommand(insert_query, payRoll);
                    payCommand.Parameters.AddWithValue("@fname", tb_fname.Text);
                    payCommand.Parameters.AddWithValue("@lname", tb_lname.Text);
                    payCommand.Parameters.AddWithValue("@email", tb_email.Text);
                    payCommand.Parameters.AddWithValue("@password", tb_password.Text);
                    payCommand.Parameters.AddWithValue("@repassword", tb_repassword.Text);
                    payCommand.Parameters.AddWithValue("@contact", tb_contact.Text);
                    payCommand.Parameters.AddWithValue("@address", tb_address.Text);
                    payCommand.Parameters.AddWithValue("@photo", changePicIntoBytes());
                    payCommand.ExecuteNonQuery();
                    MessageBox.Show("Information saved successfully!","Employees PayRoll Management System",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    payRoll.Close();
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_browse_Click(object sender, EventArgs e)
        {
          
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Select picture (*.jpg;*.jpeg;*.png;)|*.jpg;*.jpeg;*.png;";
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                pb_admin.Image = Image.FromFile(ofd.FileName); //Image class belongs to System.Drawing; It is abstract class.
                
            }
           
        }
        private byte[] changePicIntoBytes()
        {
            MemoryStream ms = new MemoryStream(); //belongs to System.IO;
            pb_admin.Image.Save(ms, pb_admin.Image.RawFormat); //pb_admin is picture box
            return ms.GetBuffer();
        }

        private void Tb_email_MouseLeave(object sender, EventArgs e)
        {
            //if(string.IsNullOrEmpty(tb_email.Text)!=true)
            //{
            //    if(Regex.IsMatch(tb_email.Text, email_regex_string)==false)
            //    {
            //        emailErrorProvider.SetError(tb_email, "Enter proper email address!");
            //        tb_email.Focus();
            //    }
            //    else
            //    {
            //        emailErrorProvider.Clear();
            //    }
            //}
        }

        private void Tb_email_Leave(object sender, EventArgs e)
        {
                if (Regex.IsMatch(tb_email.Text, email_regex_string)==true)
                {
                    emailErrorProvider.Clear();
                    
                }
                else
                {
                    emailErrorProvider.SetError(tb_email, "Enter proper email address!");
                    tb_email.Focus();
                }
        }

        private void Tb_password_Leave(object sender, EventArgs e)
        {
                if(Regex.IsMatch(tb_password.Text,password_regex_string) == true)
                {
                    passwordErrorProvider.Clear();
                }
                else
                {
                    tb_password.Focus();
                    passwordErrorProvider.SetError(this.tb_password,"Password should contain Uppercase alphabet, number and special character!");
                }
        }

        private void Tb_repassword_Leave(object sender, EventArgs e)
        {
                if (tb_repassword.Text == tb_password.Text)
                {
                    repasswordErrorProvider.Clear();
                }
                else
                {
                    tb_repassword.Focus();
                    repasswordErrorProvider.SetError(this.tb_repassword, "Passwords should be same!");
                }
        }

        private void Tb_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            char numKey = e.KeyChar;
            if(char.IsNumber(numKey)==true)
            {
                e.Handled = false;
            }
            else if(numKey==8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
          
        }
    }
}
