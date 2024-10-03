using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MrSoloDeveloperGeneralLibrary;
using System.Configuration;
using System.Data.SqlClient;

namespace EmployeePayRollManagementSystem
{
    public partial class AllowancesPercentageForm : Form
    {
        string criteria_string = ConfigurationManager.ConnectionStrings["payroll"].ConnectionString;
        public AllowancesPercentageForm()
        {
            InitializeComponent();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tb_40000_Leave(object sender, EventArgs e)
        {
            MrSoloRestrictions.setTextBoxErrorProvider(this.tb_40000, tb_40000_ep);
            long result;
            if(long.TryParse(tb_40000.Text,out result))
            {
                long gotValue = result;
                if (gotValue >= 40000)
                {
                    tb_40000_ep.Clear();
                }
                else
                {
                    tb_40000.Focus();
                    tb_40000_ep.SetError(this.tb_40000, "Please enter amount equal to or greater than 40000.");
                }
            }
            
        }

        private void Tb_30000_Leave(object sender, EventArgs e)
        {
            MrSoloRestrictions.setTextBoxErrorProvider(this.tb_30000, tb_30000_ep);
            long input;
            if(long.TryParse(tb_30000.Text,out input))
            {
                if (input >= 30000 && input < 40000)
                {
                    tb_30000_ep.Clear();
                }
                else
                {
                    tb_30000.Focus();
                    tb_30000_ep.SetError(this.tb_30000, "Please enter amount between 30000 and 40000.");
                }
            }
           
        }

        private void Tb_29000_Leave(object sender, EventArgs e)
        {
            MrSoloRestrictions.setTextBoxErrorProvider(this.tb_29000, tb_29000_ep);
            long input_result;
            if(long.TryParse(tb_29000.Text, out input_result))
            {
                if (input_result < 30000)
                {
                    tb_29000_ep.Clear();
                }
                else
                {
                    tb_29000.Focus();
                    tb_29000_ep.SetError(this.tb_29000, "Please enter amount less than 29000.");
                }
            }
            
        }

        private void Tb_40000_KeyPress(object sender, KeyPressEventArgs e)
        {
            MrSoloRestrictions.setControlInputToNumbers(this.tb_40000,e);
            //int limit = int.Parse(this.tb_40000.Text.Length.ToString());
            //if(limit==6)
            //{
            //    e.Handled = true;
            //}

        }

        private void Tb_30000_KeyPress(object sender, KeyPressEventArgs e)
        {
            MrSoloRestrictions.setControlInputToNumbers(this.tb_30000, e);
            //int limit = int.Parse(this.tb_30000.Text.Length.ToString());
            //if (limit == 5)
            //{
            //    e.Handled = true;
            //}
        }

        private void Tb_29000_KeyPress(object sender, KeyPressEventArgs e)
        {
            MrSoloRestrictions.setControlInputToNumbers(this.tb_29000, e);
            //int limit = int.Parse(this.tb_29000.Text.Length.ToString());
            //if (limit == 5)
            //{
            //    e.Handled = true;
            //}
        }

        private void Btn_save_percentage_criteria_Click(object sender, EventArgs e)
        {
            if(this.tb_40000.Text!="" && this.tb_30000.Text!="" && this.tb_29000.Text!="")
            {
                string criteria_query = "INSERT INTO emp_allowance_criteria(emp_basicsalary,emp_category,emp_conveyance_allowance,emp_medical_allowance,emp_houserent_allowance)" +
                    "VALUES(@bs1,@cat1,@con1,@med1,@hr1)," +
                    "(@bs2,@cat2,@con2,@med2,@hr2)," +
                    "(@bs3,@cat3,@con3,@med3,@hr3)";
                SqlConnection criteriaConnection = new SqlConnection(criteria_string);
                try
                {
                    criteriaConnection.Open();
                    SqlCommand criteria_command = new SqlCommand(criteria_query, criteriaConnection);
                    criteria_command.Parameters.AddWithValue("@bs1",long.Parse(this.tb_40000.Text));
                    criteria_command.Parameters.AddWithValue("@cat1",this.lbl_cat_01.Text);
                    criteria_command.Parameters.AddWithValue("@con1",int.Parse(this.nud_40000_CA.Value.ToString()));
                    criteria_command.Parameters.AddWithValue("@med1",int.Parse(this.nud_40000_MA.Value.ToString()));
                    criteria_command.Parameters.AddWithValue("@hr1",int.Parse(this.nud_40000_HRA.Value.ToString()));
                    ////////////////////////////////////////////////////////////////////////
                    criteria_command.Parameters.AddWithValue("@bs2",long.Parse(this.tb_30000.Text));
                    criteria_command.Parameters.AddWithValue("@cat2", this.lbl_cat_02.Text);
                    criteria_command.Parameters.AddWithValue("@con2", int.Parse(this.nud_30000_CA.Value.ToString()));
                    criteria_command.Parameters.AddWithValue("@med2", int.Parse(this.nud_30000_MA.Value.ToString()));
                    criteria_command.Parameters.AddWithValue("@hr2", int.Parse(this.nud_30000_HRA.Value.ToString()));
                    ///////////////////////////////////////////////////////////////////////////////
                    ///
                    criteria_command.Parameters.AddWithValue("@bs3", long.Parse(this.tb_29000.Text));
                    criteria_command.Parameters.AddWithValue("@cat3", this.lbl_cat_03.Text);
                    criteria_command.Parameters.AddWithValue("@con3", int.Parse(this.nud_29000_CA.Value.ToString()));
                    criteria_command.Parameters.AddWithValue("@med3", int.Parse(this.nud_29000_MA.Value.ToString()));
                    criteria_command.Parameters.AddWithValue("@hr3", int.Parse(this.nud_29000_HRA.Value.ToString()));
                    criteria_command.ExecuteNonQuery();
                    MessageBox.Show("Criteria saved successfully.");
                    criteriaConnection.Close();


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            else
            {

            }
        }

        private void AllowancesPercentageForm_Load(object sender, EventArgs e)
        {
            fetchCatOneData();
            fetchCatTwoData();
            fetchCatThreeData();
           
        }

        private void fetchCatThreeData()
        {
            string fetchQuery = "SELECT * FROM emp_allowance_criteria where emp_category='CAT-01'";
            SqlConnection fetch_connection = new SqlConnection(criteria_string);
            try
            {
                fetch_connection.Open();
                SqlCommand fetch_command = new SqlCommand(fetchQuery, fetch_connection);
                SqlDataReader fetch_reader = fetch_command.ExecuteReader();
                while(fetch_reader.Read())
                {
                    tb_40000.Text = fetch_reader["emp_basicsalary"].ToString();
                    nud_40000_CA.Value = decimal.Parse(fetch_reader["emp_conveyance_allowance"].ToString());
                    nud_40000_MA.Value = decimal.Parse(fetch_reader["emp_medical_allowance"].ToString());
                    nud_40000_HRA.Value =decimal.Parse(fetch_reader["emp_houserent_allowance"].ToString());
                }
                fetch_reader.Close();
                fetch_connection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
        }

        private void fetchCatTwoData()
        {
            string fetchQuery = "SELECT * FROM emp_allowance_criteria where emp_category='CAT-02'";
            SqlConnection fetch_connection = new SqlConnection(criteria_string);
            try
            {
                fetch_connection.Open();
                SqlCommand fetch_command = new SqlCommand(fetchQuery, fetch_connection);
                SqlDataReader fetch_reader = fetch_command.ExecuteReader();
                while (fetch_reader.Read())
                {
                    tb_30000.Text = fetch_reader["emp_basicsalary"].ToString();
                    nud_30000_CA.Value = decimal.Parse(fetch_reader["emp_conveyance_allowance"].ToString());
                    nud_30000_MA.Value = decimal.Parse(fetch_reader["emp_medical_allowance"].ToString());
                    nud_30000_HRA.Value = decimal.Parse(fetch_reader["emp_houserent_allowance"].ToString());
                }
                fetch_reader.Close();
                fetch_connection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void fetchCatOneData()
        {
            string fetchQuery = "SELECT * FROM emp_allowance_criteria where emp_category='CAT-03'";
            SqlConnection fetch_connection = new SqlConnection(criteria_string);
            try
            {
                fetch_connection.Open();
                SqlCommand fetch_command = new SqlCommand(fetchQuery, fetch_connection);
                SqlDataReader fetch_reader = fetch_command.ExecuteReader();
                while (fetch_reader.Read())
                {
                    tb_29000.Text = fetch_reader["emp_basicsalary"].ToString();
                    nud_29000_CA.Value = decimal.Parse(fetch_reader["emp_conveyance_allowance"].ToString());
                    nud_29000_MA.Value = decimal.Parse(fetch_reader["emp_medical_allowance"].ToString());
                    nud_29000_HRA.Value =decimal.Parse(fetch_reader["emp_houserent_allowance"].ToString());
                }
                fetch_reader.Close();
                fetch_connection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                edit_group_box.Enabled = true;
                btn_save_percentage_criteria.Enabled = false;
                tb_40000.Enabled = false;
                nud_40000_CA.Enabled = false;
                nud_40000_MA.Enabled = false;
                nud_40000_HRA.Enabled = false;
                tb_30000.Enabled = false;
                nud_30000_CA.Enabled = false;
                nud_30000_MA.Enabled = false;
                nud_30000_HRA.Enabled = false;
                tb_29000.Enabled = false;
                nud_29000_CA.Enabled = false;
                nud_29000_MA.Enabled = false;
                nud_29000_HRA.Enabled = false;
            }
            else
            {
                edit_group_box.Enabled = false;
                btn_save_percentage_criteria.Enabled = true;
                tb_40000.Enabled = true;
                nud_40000_CA.Enabled = true;
                nud_40000_MA.Enabled = true;
                nud_40000_HRA.Enabled = true;
                tb_30000.Enabled = true;
                nud_30000_CA.Enabled = true;
                nud_30000_MA.Enabled = true;
                nud_30000_HRA.Enabled = true;
                tb_29000.Enabled = true;
                nud_29000_CA.Enabled = true;
                nud_29000_MA.Enabled = true;
                nud_29000_HRA.Enabled = true;
            }
        }

        private void Btn_edit_values_Click(object sender, EventArgs e)
        {
            //string selectedValue = cb_percentage_categories.Text;
           
            if (cb_percentage_categories.SelectedIndex==0)
            {
                editSelectedCriteria(cb_percentage_categories.Text, long.Parse(this.tb_40000.Text), int.Parse(nud_40000_CA.Value.ToString()),int.Parse(nud_40000_MA.Value.ToString()),int.Parse(nud_40000_HRA.Value.ToString()));
                fetchCatOneData();
            }
            else if(cb_percentage_categories.SelectedIndex == 1)
            {
                editSelectedCriteria(cb_percentage_categories.Text, long.Parse(this.tb_30000.Text), int.Parse(this.nud_30000_CA.Value.ToString()), int.Parse(this.nud_30000_MA.Value.ToString()), int.Parse(this.nud_30000_HRA.Value.ToString()));
                fetchCatTwoData();
            }
            else if(cb_percentage_categories.SelectedIndex == 2)
            {
                editSelectedCriteria(cb_percentage_categories.Text, long.Parse(this.tb_29000.Text), int.Parse(this.nud_29000_CA.Value.ToString()), int.Parse(this.nud_29000_MA.Value.ToString()), int.Parse(this.nud_29000_HRA.Value.ToString()));
                fetchCatThreeData();
            }
        }

        private void editSelectedCriteria(string val, long sal, int con, int med, int hr)
        {
            
            string updateQuery = "update emp_allowance_criteria set emp_basicsalary=@sal,emp_conveyance_allowance=@con," +
                "emp_medical_allowance=@med, emp_houserent_allowance=@hr where emp_category='"+val+"'";
            SqlConnection update_connection = new SqlConnection(criteria_string);
            try
            {
                update_connection.Open();
                SqlCommand update_command = new SqlCommand(updateQuery, update_connection);
                update_command.Parameters.AddWithValue("@sal",sal);
                update_command.Parameters.AddWithValue("@con",con);
                update_command.Parameters.AddWithValue("@med",med);
                update_command.Parameters.AddWithValue("@hr",hr);
                update_command.ExecuteNonQuery();
                MessageBox.Show("Criteria updated!","Employees PayRoll Management System",MessageBoxButtons.OK,MessageBoxIcon.Information);
                update_connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Cb_percentage_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_percentage_categories.SelectedIndex==-1)
            {
                //all enabled 
                tb_40000.Enabled = true;
                nud_40000_CA.Enabled = true;
                nud_40000_MA.Enabled = true;
                nud_40000_HRA.Enabled = true;
                tb_30000.Enabled = true;
                nud_30000_CA.Enabled = true;
                nud_30000_MA.Enabled = true;
                nud_30000_HRA.Enabled = true;
                tb_29000.Enabled = true;
                nud_29000_CA.Enabled = true;
                nud_29000_MA.Enabled = true;
                nud_29000_HRA.Enabled = true;
            }
            else if(cb_percentage_categories.SelectedIndex == 0)
            {
                tb_40000.Enabled = true;
                nud_40000_CA.Enabled = true;
                nud_40000_MA.Enabled = true;
                nud_40000_HRA.Enabled = true;
                tb_30000.Enabled = false;
                nud_30000_CA.Enabled = false;
                nud_30000_MA.Enabled = false;
                nud_30000_HRA.Enabled = false;
                tb_29000.Enabled = false;
                nud_29000_CA.Enabled = false;
                nud_29000_MA.Enabled = false;
                nud_29000_HRA.Enabled = false;
            }
            else if (cb_percentage_categories.SelectedIndex == 1)
            {
                tb_30000.Enabled = true;
                nud_30000_CA.Enabled = true;
                nud_30000_MA.Enabled = true;
                nud_30000_HRA.Enabled = true;
                tb_40000.Enabled = false;
                nud_40000_CA.Enabled = false;
                nud_40000_MA.Enabled = false;
                nud_40000_HRA.Enabled = false;
                tb_29000.Enabled = false;
                nud_29000_CA.Enabled = false;
                nud_29000_MA.Enabled = false;
                nud_29000_HRA.Enabled = false;
            }
            else if (cb_percentage_categories.SelectedIndex == 2)
            {
                tb_29000.Enabled = true;
                nud_29000_CA.Enabled = true;
                nud_29000_MA.Enabled = true;
                nud_29000_HRA.Enabled = true;
                tb_30000.Enabled = false;
                nud_30000_CA.Enabled = false;
                nud_30000_MA.Enabled = false;
                nud_30000_HRA.Enabled = false;
                tb_40000.Enabled = false;
                nud_40000_CA.Enabled = false;
                nud_40000_MA.Enabled = false;
                nud_40000_HRA.Enabled = false;
            }
        }
    }
}
