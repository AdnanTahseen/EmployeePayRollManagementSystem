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
using System.Text.RegularExpressions;


namespace EmployeePayRollManagementSystem
{
    public partial class Login_PayRoll : Form
    {
        string login_connection_string = ConfigurationManager.ConnectionStrings["payroll"].ConnectionString;
        string login_email_regex = "^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";
        string login_password_regex = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
        public Login_PayRoll()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LinkLabel_Registration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration_PayRoll reg_pr = new Registration_PayRoll();
            reg_pr.ShowDialog();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            if(tb_username.Text!="" && tb_password.Text!="")
            {
                string sqlQuery = "SELECT * FROM admin where ad_email='" + tb_username.Text + "' and ad_password ='" + tb_password.Text + "'";
                try
                {
                    SqlConnection login_connection = new SqlConnection(login_connection_string);
                    if (login_connection.State == ConnectionState.Closed)
                    {
                        login_connection.Open();
                        SqlCommand login_command = new SqlCommand(sqlQuery, login_connection);
                        SqlDataReader login_reader = login_command.ExecuteReader();
                        if (login_reader.HasRows == true)
                        {
                            Dashboard_PayRoll dashboard = new Dashboard_PayRoll(tb_username.Text);
                            this.Hide();
                            dashboard.Show();
                        }
                        else
                        {
                            MessageBox.Show("Login Failed! Credentials not found.", "Employee PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        login_connection.Close();
                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Please fill in the fields!", "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Login_PayRoll_VisibleChanged(object sender, EventArgs e)
        {
            tb_username.Clear();
            tb_password.Clear();
            tb_username.Focus();
        }

        private void Tb_username_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tb_username.Text)==false)
            {
                if(Regex.IsMatch(tb_username.Text,login_email_regex)==true)
                {
                    emailErrorProvider.Clear();
                }
                else
                {
                    tb_username.Focus();
                    emailErrorProvider.SetError(this.tb_username, "Invalid email address");
                }
            }
        }

        private void Tb_password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_password.Text) == false)
            {
                if (Regex.IsMatch(tb_password.Text, login_password_regex) == true)
                {
                    passwordErrorProvider.Clear();
                }
                else
                {
                    tb_password.Focus();
                    passwordErrorProvider.SetError(this.tb_password, "Password should contain uppercase alphabet, number and special character");
                }
            }
        }
    }
}
