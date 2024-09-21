using System;
using System.Windows.Forms;

namespace EmployeePayRollManagementSystem
{
    public partial class NewEmployees : Form
    {
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
            if (this.tb_save_fname.Text != "" && this.tb_save_lname.Text != "" && this.tb_save_email.Text != "" && this.tb_save_contact.Text != "" &&
            this.cb_save_qualification.Text != "" && this.nud_save_age.Value.ToString() != "" && this.cb_save_city.Text != "" && this.cb_save_province.Text != "" &&
            this.cb_save_country.Text != "" && this.dtp_save_applied_date.Text != "" && this.tb_save_cnic.Text != "" && this.tb_save_designation.Text != "" &&
            this.cb_save_blood_group.Text != "" && this.tb_save_basic_salary.Text != "" && this.tb_save_address.Text != "" && this.pb_save_emp_photo.Image != null)
            {
                NewEmployeesInformation saveEmp = new NewEmployeesInformation(
                    this.tb_save_fname.Text, this.tb_save_lname.Text, this.tb_save_email.Text, int.Parse(this.tb_save_contact.Text),
                    this.cb_save_qualification.Text, (int)this.nud_save_age.Value, this.cb_save_city.Text, this.cb_save_province.Text,
                    this.cb_save_country.Text, this.dtp_save_applied_date.Text, int.Parse(this.tb_save_cnic.Text), this.tb_save_designation.Text,
                    this.cb_save_blood_group.Text, int.Parse(this.tb_save_basic_salary.Text), this.tb_save_address.Text, this.pb_save_emp_photo);

                saveEmp.saveNewEmployeeInformation();
            }
        }
    }
}