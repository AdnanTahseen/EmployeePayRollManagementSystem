using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EmployeePayRollManagementSystem
{
    public partial class NewEmployees : Form
    {
        private string connection_string = ConfigurationManager.ConnectionStrings["payroll"].ConnectionString;
        private string email_save_regex = "^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";

        public NewEmployees()
        {
            InitializeComponent();
        }

        private void Btn_form_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveEmpBtn_Click(object sender, EventArgs e)
        {
            bool result;
            if (this.tb_save_fname.Text != "" && this.tb_save_lname.Text != "" && this.tb_save_email.Text != "" && this.tb_save_contact.Text != "" &&
            this.cb_save_qualification.Text != "" && this.nud_save_age.Value.ToString() != "" && this.cb_save_city.Text != "" && this.cb_save_province.Text != "" &&
            this.cb_save_country.Text != "" && this.dtp_save_applied_date.Text != "" && this.tb_save_cnic.Text != "" && this.tb_save_designation.Text != "" &&
            this.cb_save_blood_group.Text != "" && this.tb_save_basic_salary.Text != "" && this.tb_save_address.Text != "" && this.pb_save_emp_photo.Image != null)
            {
                if (nud_save_age.Value >= 18)
                {
                    NewEmployeeSaveInformation saveEmp = new NewEmployeeSaveInformation();

                    result = saveEmp.saveNewEmployeeInformation(
                    this.tb_save_fname.Text, this.tb_save_lname.Text, this.tb_save_email.Text, long.Parse(this.tb_save_contact.Text),
                    this.cb_save_qualification.Text, (int)this.nud_save_age.Value, this.cb_save_city.Text, this.cb_save_province.Text,
                    this.cb_save_country.Text, this.dtp_save_applied_date.Text, long.Parse(this.tb_save_cnic.Text), this.tb_save_designation.Text,
                    this.cb_save_blood_group.Text, int.Parse(this.tb_save_basic_salary.Text), this.tb_save_address.Text, this.pb_save_emp_photo);
                    if (result == true)
                    {
                        this.tb_save_fname.Clear();
                        this.tb_save_lname.Clear();
                        this.tb_save_email.Clear();
                        this.tb_save_contact.Clear();
                        this.cb_save_qualification.SelectedIndex = -1;
                        this.nud_save_age.Value = 0;
                        this.cb_save_city.SelectedIndex = -1;
                        this.cb_save_province.SelectedIndex = -1;
                        this.cb_save_country.SelectedIndex = -1;
                        this.tb_save_cnic.Clear();
                        this.tb_save_designation.Clear();
                        this.cb_save_blood_group.SelectedIndex = -1;
                        this.tb_save_basic_salary.Clear();
                        this.tb_save_address.Clear();
                        this.pb_save_emp_photo.Image = Properties.Resources.No_image;
                    }
                }
                else
                {
                    MessageBox.Show("You can't employ a under age person!", "Employee PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("All fields are required!", "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //if(this.tb_save_fname.Text != "" && this.tb_save_lname.Text != "")
            //{
            //    Practice pr = new Practice();
            //    pr.insertInformation(this.tb_save_fname.Text, this.tb_save_lname.Text, this.tb_save_email.Text,long.Parse(this.tb_save_contact.Text),
            //        this.cb_save_qualification.Text,int.Parse(this.nud_save_age.Text), this.cb_save_city.Text, this.cb_save_province.Text,this.cb_save_country.Text,
            //        this.dtp_save_applied_date.Text,long.Parse(this.tb_save_cnic.Text),this.tb_save_designation.Text,this.cb_save_blood_group.Text,
            //        int.Parse(this.tb_save_basic_salary.Text),this.tb_save_address.Text,this.pb_save_emp_photo);
            //}
        }

        private void Tb_save_email_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tb_save_email.Text, email_save_regex) == true)
            {
                emailErrorProviderNewEmp.Clear();
            }
            else
            {
                tb_save_email.Focus();
                emailErrorProviderNewEmp.SetError(this.tb_save_email, "Invalid email address");
            }
        }

        private void Pb_save_emp_photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog profile_dialog = new OpenFileDialog();
            profile_dialog.Filter = "Select employee photo(*.jpg;*.jpeg;*.png;) | *.jpg;*.jpeg;*.png;";
            //profile_dialog.ShowDialog();
            if (profile_dialog.ShowDialog() == DialogResult.OK)
            {
                pb_save_emp_photo.Image = Image.FromFile(profile_dialog.FileName);
            }
        }

        private void Tb_save_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            char contact_key = e.KeyChar;
            if (char.IsNumber(contact_key) == true)
            {
                e.Handled = false;
            }
            else if (contact_key == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void NewEmployees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emp_payrollDataSet_Del.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter1.Fill(this.emp_payrollDataSet_Del.employees);
            // TODO: This line of code loads data into the 'emp_payrollDataSet1.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.emp_payrollDataSet1.employees);
            // TODO: This line of code loads data into the 'emp_payrollDataSet.cities_pk' table. You can move, or remove it, as needed.
            this.cities_pkTableAdapter.Fill(this.emp_payrollDataSet.cities_pk);
            this.tb_save_fname.Focus();
        }

        private void Tb_save_basic_salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            char salary_char = e.KeyChar;
            if (char.IsNumber(salary_char) == true)
            {
                e.Handled = false;
            }
            else if (salary_char == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Cb_update_Emp_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT * from employees where emp_id='" + this.cb_update_Emp_ID.SelectedValue + "'";
            SqlConnection id_connection = new SqlConnection(connection_string);
            try
            {
                id_connection.Open();
                SqlCommand id_command = new SqlCommand(sqlQuery, id_connection);
                //DataTable id_dt = new DataTable();
                SqlDataReader id_reader = id_command.ExecuteReader();
                while (id_reader.Read())
                {
                    this.tb_update_fname.Text = id_reader[1].ToString();
                    this.tb_update_lname.Text = id_reader[2].ToString();
                    this.tb_update_email.Text = id_reader[3].ToString();
                    this.tb_update_contact.Text = id_reader[4].ToString();
                    this.cb_update_qualification.Text = id_reader[5].ToString();
                    this.nud_update_age.Value = int.Parse(id_reader[6].ToString());
                    this.cb_update_city.Text = id_reader[7].ToString();
                    this.cb_update_province.Text = id_reader[8].ToString();
                    this.cb_update_country.Text = id_reader[9].ToString();
                    this.dtp_update_applied_date.Text = id_reader[10].ToString();
                    this.tb_update_cnic.Text = id_reader[11].ToString();
                    this.tb_update_designation.Text = id_reader[12].ToString();
                    this.cb_update_blood_group.Text = id_reader[13].ToString();
                    this.tb_update_basic_salary.Text = id_reader[14].ToString();
                    this.tb_update_address.Text = id_reader[15].ToString();
                    MemoryStream ms = new MemoryStream((Byte[])id_reader[16]);
                    this.pb_update_emp_photo.Image = Image.FromStream(ms);
                }
                id_connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Employee PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cb_update_Emp_ID_Click(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Fill(this.emp_payrollDataSet1.employees);
        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeesTableAdapter.FillBy(this.emp_payrollDataSet1.employees);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void Btn_emp_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Employee PayRoll Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cb_emp_delete.Text != "")
            {
                if (dr == DialogResult.Yes)
                {
                    sendIDForDelete(int.Parse(this.cb_emp_delete.Text));
                }
            }
            else
            {
                MessageBox.Show("Please select Employee ID!", "Employee PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sendIDForDelete(int selectedValue)
        {
            string del_query = "DELETE FROM employees where emp_id=@del_id";
            SqlConnection del_connection = new SqlConnection(connection_string);
            try
            {
                del_connection.Open();
                SqlCommand del_command = new SqlCommand(del_query, del_connection);
                del_command.Parameters.AddWithValue("@del_id", selectedValue);
                del_command.ExecuteNonQuery();
                MessageBox.Show("Employee information deleted successfully.", "Employee PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                del_connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateEmpBtn_Click(object sender, EventArgs e)
        {
            bool result;
            if (this.tb_update_fname.Text != "" && this.tb_update_lname.Text != "" && this.tb_update_email.Text != "" && this.tb_update_contact.Text != "" &&
            this.cb_update_qualification.Text != "" && this.nud_update_age.Value.ToString() != "" && this.cb_update_city.Text != "" && this.cb_update_province.Text != "" &&
            this.cb_update_country.Text != "" && this.dtp_update_applied_date.Text != "" && this.tb_update_cnic.Text != "" && this.tb_update_designation.Text != "" &&
            this.cb_update_blood_group.Text != "" && this.tb_update_basic_salary.Text != "" && this.tb_update_address.Text != "" && this.pb_update_emp_photo.Image != null)
            {
                if (nud_update_age.Value >= 18)
                {
                    UpdateEmployeeInformation updateObj = new UpdateEmployeeInformation();

                    result = updateObj.updateEmployeeInformation(
                    int.Parse(this.cb_update_Emp_ID.Text), this.tb_update_fname.Text, this.tb_update_lname.Text, this.tb_update_email.Text, long.Parse(this.tb_update_contact.Text),
                    this.cb_update_qualification.Text, (int)this.nud_update_age.Value, this.cb_update_city.Text, this.cb_update_province.Text,
                    this.cb_update_country.Text, this.dtp_update_applied_date.Text, long.Parse(this.tb_update_cnic.Text), this.tb_update_designation.Text,
                    this.cb_update_blood_group.Text, int.Parse(this.tb_update_basic_salary.Text), this.tb_update_address.Text, this.pb_update_emp_photo);
                    if (result == true)
                    {
                        this.tb_update_fname.Clear();
                        this.tb_update_lname.Clear();
                        this.tb_update_email.Clear();
                        this.tb_update_contact.Clear();
                        this.cb_update_qualification.SelectedIndex = -1;
                        this.nud_update_age.Value = 0;
                        this.cb_update_city.SelectedIndex = -1;
                        this.cb_update_province.SelectedIndex = -1;
                        this.cb_update_country.SelectedIndex = -1;
                        this.tb_update_cnic.Clear();
                        this.tb_update_designation.Clear();
                        this.cb_update_blood_group.SelectedIndex = -1;
                        this.tb_update_basic_salary.Clear();
                        this.tb_update_address.Clear();
                        this.pb_update_emp_photo.Image = Properties.Resources.No_image;
                    }
                }
                else
                {
                    MessageBox.Show("You can't employ a under age person!", "Employee PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Cb_emp_delete_Click(object sender, EventArgs e)
        {
            this.employeesTableAdapter1.Fill(this.emp_payrollDataSet_Del.employees);
        }

        private void Btn_show_emp_table_Click(object sender, EventArgs e)
        {
            Program.emp_table.ShowDialog();
        }
    }
}