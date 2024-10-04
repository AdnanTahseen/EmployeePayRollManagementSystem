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
using MrSoloDeveloperGeneralLibrary;
using System.IO;

namespace EmployeePayRollManagementSystem
{
    public partial class EmployeesPayRoll : Form
    {
        string allowance_string = ConfigurationManager.ConnectionStrings["payroll"].ConnectionString;
        enum months {january=1, february, march,april,may,june,july,august,september,october,november,december }
        string[] MonthsNames = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        public EmployeesPayRoll()
        {
            InitializeComponent();
            
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeesPayRoll_Load(object sender, EventArgs e)
        {

            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            foreach(int v in Enum.GetValues(typeof(months)))
            {
                if(v==month)
                {
                    tb_month.Text = MonthsNames[v-1].ToString();
                }
                tb_year.Text = year.ToString();
                
            }
            loadAttendanceTable();
            gb_month.Text = "Final Salary at last date of " + DateTime.Now.ToShortDateString();
            //gb_month.Text = "Final Salary at last date of " + year;
            // TODO: This line of code loads data into the 'emp_payrollDataSetEmployeeID.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter1.Fill(this.emp_payrollDataSetEmployeeID.employees);
            // TODO: This line of code loads data into the 'emp_payrollDataSetSalaryWithAllowances.salaryWithAllowances' table. You can move, or remove it, as needed.
            this.salaryWithAllowancesTableAdapter.Fill(this.emp_payrollDataSetSalaryWithAllowances.salaryWithAllowances);
            // TODO: This line of code loads data into the 'emp_payrollDataSetForSetAllowances.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.emp_payrollDataSetForSetAllowances.employees);

        }

        private void Cb_emp_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_save_conveyance.Clear();
            tb_save_medical.Clear();
            tb_save_house_rent.Clear();
            tb_save_gross_pay.Clear();
            tb_save_income_tax.Clear();
            tb_save_net_salary.Clear();

            string fetch_query = "SELECT * FROM employees where emp_id='"+ this.cb_emp_id.SelectedValue + "'";
            SqlConnection fetch_connection = new SqlConnection(allowance_string);
            try
            {
                fetch_connection.Open();
                SqlCommand fetch_command = new SqlCommand(fetch_query, fetch_connection);
                SqlDataReader fetch_reader = fetch_command.ExecuteReader();
                while(fetch_reader.Read())
                {
                    tb_emp_name.Text = (string)fetch_reader["emp_first_name"] + " " + (string)fetch_reader["emp_last_name"];
                    tb_emp_designation.Text = (string)fetch_reader["emp_designation"];
                    tb_emp_basic_pay.Text = (string)fetch_reader["emp_basicsalary"].ToString();
                }
                fetch_connection.Close();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(),"Employees PayRoll Management System",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            ///////////////////////////////////////
            
            if (tb_emp_basic_pay.Text != "")
            {
                int amount = (int)long.Parse(tb_emp_basic_pay.Text);
                setAllowances(amount);
                long basicsalary = long.Parse(tb_emp_basic_pay.Text); // giving error
                long annaul_amount = basicsalary * 12;
                if (annaul_amount < 600000)
                {
                    tb_save_income_tax.Text = "0";
                    tb_save_net_salary.Text = tb_save_gross_pay.Text;

                }
                else if (annaul_amount > 600000 && annaul_amount <= 1200000)
                {
                    tb_save_income_tax.Text = (basicsalary * 0.05).ToString();
                    tb_save_net_salary.Text = ((long)double.Parse(tb_save_gross_pay.Text) - (long)double.Parse(tb_save_income_tax.Text)).ToString();
                }
                else if (annaul_amount > 1200000 && annaul_amount <= 2200000)
                {
                    tb_save_income_tax.Text = (basicsalary * 0.15).ToString();
                    tb_save_net_salary.Text = ((long)double.Parse(tb_save_gross_pay.Text) - (long)double.Parse(tb_save_income_tax.Text)).ToString();
                }
                else if (annaul_amount > 2200000 && annaul_amount <= 3200000)
                {
                    tb_save_income_tax.Text = (basicsalary * 0.25).ToString();
                    tb_save_net_salary.Text = ((long)double.Parse(tb_save_gross_pay.Text) - (long)double.Parse(tb_save_income_tax.Text)).ToString();
                }
                else if (annaul_amount > 3200000 && annaul_amount <= 4100000)
                {
                    tb_save_income_tax.Text = (basicsalary * 0.30).ToString();
                    tb_save_net_salary.Text = ((long)double.Parse(tb_save_gross_pay.Text) - (long)double.Parse(tb_save_income_tax.Text)).ToString();
                }
                else if (annaul_amount > 4100000)
                {
                    tb_save_income_tax.Text = (basicsalary * 0.35).ToString();
                    tb_save_net_salary.Text = ((long)double.Parse(tb_save_gross_pay.Text) - (long)double.Parse(tb_save_income_tax.Text)).ToString();
                }
            }
            ///////////////////////////

        }

        private void setAllowances(int amount)
        {
            if(amount >=40000)
            {
                getCatOneCriteria(amount);
            }
            else if(amount <40000 && amount>=30000)
            {
                getCatTwoCriteria(amount);
            }
            else if(amount <30000 )
            {
                getCatThreeCriteria(amount);
            }
        }

        private void getCatThreeCriteria(long basicsalary)
        {
            string sql_query = "SELECT * FROM emp_allowance_criteria where emp_category='CAT-02'";
            SqlConnection criteria_connection = new SqlConnection(allowance_string);
            try
            {
                criteria_connection.Open();
                SqlCommand criteria_command = new SqlCommand(sql_query, criteria_connection);
                SqlDataReader criteria_reader = criteria_command.ExecuteReader();
                while (criteria_reader.Read())
                {
                    tb_save_conveyance.Text = ((decimal.Parse(criteria_reader["emp_conveyance_allowance"].ToString()) / 100) * basicsalary).ToString();
                    tb_save_medical.Text = ((decimal.Parse(criteria_reader["emp_medical_allowance"].ToString()) / 100) * basicsalary).ToString();
                    tb_save_house_rent.Text = ((decimal.Parse(criteria_reader["emp_houserent_allowance"].ToString()) / 100) * basicsalary).ToString();

                }
                //tb_save_gross_pay.Text = (int.Parse(tb_emp_basic_pay.Text) + int.Parse(tb_save_conveyance.Text) + int.Parse(tb_save_medical.Text) + int.Parse(tb_save_house_rent.Text)).ToString();
                int basicpay = int.Parse(tb_emp_basic_pay.Text);
                int conveyance = (int)decimal.Parse(tb_save_conveyance.Text);
                int medical = (int)decimal.Parse(tb_save_medical.Text);
                int houserent = (int)decimal.Parse(tb_save_house_rent.Text);
                tb_save_gross_pay.Text = (basicpay + conveyance + medical + houserent).ToString();
                ///////////////////////////
                ///
                //long grossPay = long.Parse(tb_save_gross_pay.Text);
                /////////////////////////////////

                criteria_connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void getCatTwoCriteria(long basicsalary)
        {
            string sql_query = "SELECT * FROM emp_allowance_criteria where emp_category='CAT-02'";
            SqlConnection criteria_connection = new SqlConnection(allowance_string);
            try
            {
                criteria_connection.Open();
                SqlCommand criteria_command = new SqlCommand(sql_query, criteria_connection);
                SqlDataReader criteria_reader = criteria_command.ExecuteReader();
                while (criteria_reader.Read())
                {
                    tb_save_conveyance.Text = ((decimal.Parse(criteria_reader["emp_conveyance_allowance"].ToString()) / 100) * basicsalary).ToString();
                    tb_save_medical.Text = ((decimal.Parse(criteria_reader["emp_medical_allowance"].ToString()) / 100) * basicsalary).ToString();
                    tb_save_house_rent.Text = ((decimal.Parse(criteria_reader["emp_houserent_allowance"].ToString()) / 100) * basicsalary).ToString();

                }
                //tb_save_gross_pay.Text = (int.Parse(tb_emp_basic_pay.Text) + int.Parse(tb_save_conveyance.Text) + int.Parse(tb_save_medical.Text) + int.Parse(tb_save_house_rent.Text)).ToString();
                int basicpay = int.Parse(tb_emp_basic_pay.Text);
                int conveyance = (int)decimal.Parse(tb_save_conveyance.Text);
                int medical = (int)decimal.Parse(tb_save_medical.Text);
                int houserent = (int)decimal.Parse(tb_save_house_rent.Text);
                tb_save_gross_pay.Text = (basicpay + conveyance + medical + houserent).ToString();

                criteria_connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void getCatOneCriteria(long basicsalary)
        {
            string sql_query = "SELECT * FROM emp_allowance_criteria where emp_category='CAT-01'";
            SqlConnection criteria_connection = new SqlConnection(allowance_string);
            try
            {
                criteria_connection.Open();
                SqlCommand criteria_command = new SqlCommand(sql_query,criteria_connection);
                SqlDataReader criteria_reader = criteria_command.ExecuteReader();
                while(criteria_reader.Read())
                {
                    tb_save_conveyance.Text = ((decimal.Parse(criteria_reader["emp_conveyance_allowance"].ToString()) / 100)* basicsalary).ToString();
                    tb_save_medical.Text = ((decimal.Parse(criteria_reader["emp_medical_allowance"].ToString()) / 100) * basicsalary).ToString();
                    tb_save_house_rent.Text = ((decimal.Parse(criteria_reader["emp_houserent_allowance"].ToString()) / 100) * basicsalary).ToString();

                }
                //tb_save_gross_pay.Text = (int.Parse(tb_emp_basic_pay.Text) + int.Parse(tb_save_conveyance.Text) + int.Parse(tb_save_medical.Text) + int.Parse(tb_save_house_rent.Text)).ToString();
                int basicpay = int.Parse(tb_emp_basic_pay.Text);
                int conveyance = (int)decimal.Parse(tb_save_conveyance.Text);
                int medical = (int)decimal.Parse(tb_save_medical.Text);
                int houserent = (int)decimal.Parse(tb_save_house_rent.Text);
                tb_save_gross_pay.Text = (basicpay + conveyance + medical + houserent).ToString();
                
                criteria_connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void Tb_save_conveyance_KeyPress(object sender, KeyPressEventArgs e)
        {
            MrSoloRestrictions.setControlInputToNumbers(tb_save_conveyance, e);
        }

        private void Tb_save_gross_pay_KeyPress(object sender, KeyPressEventArgs e)
        {
            MrSoloRestrictions.setControlInputToNumbers(tb_save_gross_pay, e);
        }

        private void Tb_save_medical_KeyPress(object sender, KeyPressEventArgs e)
        {
            MrSoloRestrictions.setControlInputToNumbers(tb_save_medical, e);
        }

        private void Tb_save_income_tax_KeyPress(object sender, KeyPressEventArgs e)
        {
            MrSoloRestrictions.setControlInputToNumbers(tb_save_income_tax, e);
        }

        private void Tb_save_house_rent_KeyPress(object sender, KeyPressEventArgs e)
        {
            MrSoloRestrictions.setControlInputToNumbers(tb_save_house_rent, e);
        }

        private void Tb_save_net_salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            //onlyNumbersAllowed(e);
            MrSoloRestrictions.setControlInputToNumbers(tb_save_net_salary, e);
        }

        private void Tb_save_conveyance_Leave(object sender, EventArgs e)
        {
            MrSoloRestrictions.setTextBoxErrorProvider(this.tb_save_conveyance, conveyance_save_errorprovider);
        }

        private void Tb_save_medical_Leave(object sender, EventArgs e)
        {
            MrSoloRestrictions.setTextBoxErrorProvider(this.tb_save_medical, conveyance_save_errorprovider);
        }

        private void Tb_save_house_rent_Leave(object sender, EventArgs e)
        {
            MrSoloRestrictions.setTextBoxErrorProvider(this.tb_save_house_rent, conveyance_save_errorprovider);
        }

        private void Btn_view_percentage_chart_Click(object sender, EventArgs e)
        {
            AllowancesPercentageForm apf = new AllowancesPercentageForm();
            apf.ShowDialog();
        }

        private void CheckBox_setAllowancesPercentage_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_setAllowancesPercentage.Checked==true)
            {
                btn_view_percentage_chart.Enabled = true;
                groupBox_Allowances.Enabled = false;
            }
            else
            {
                btn_view_percentage_chart.Enabled = false;
                groupBox_Allowances.Enabled = true;
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_set_allowances_Click(object sender, EventArgs e)
        {
            
            string sql_query = "INSERT INTO salaryWithAllowances(emp_id,emp_name,emp_designation,emp_basicpay," +
                "emp_con_allowance,emp_med_allowance,emp_hr_allowance,emp_grosspay,emp_incometax,emp_netsalary)" +
                " values(@emp_id,@emp_name,@emp_designation,@emp_basicpay,@emp_con_allowance,@emp_med_allowance," +
                "@emp_hr_allowance,@emp_grosspay,@emp_incometax,@emp_netsalary)";
            if(cb_emp_id.SelectedIndex != -1)
            {
                try
                {
                    bool checkID = checkSalaryAgainstEmpID();
                    if (checkID==false)
                    {
                        SqlConnection allowance_con = new SqlConnection(allowance_string);
                        allowance_con.Open();
                        SqlCommand allowance_command = new SqlCommand(sql_query, allowance_con);
                        allowance_command.Parameters.AddWithValue("@emp_id", int.Parse(cb_emp_id.Text));
                        allowance_command.Parameters.AddWithValue("@emp_name", tb_emp_name.Text);
                        allowance_command.Parameters.AddWithValue("@emp_designation", tb_emp_designation.Text);
                        allowance_command.Parameters.AddWithValue("@emp_basicpay", long.Parse(tb_emp_basic_pay.Text));
                        allowance_command.Parameters.AddWithValue("@emp_con_allowance", (long)double.Parse(tb_save_conveyance.Text));
                        allowance_command.Parameters.AddWithValue("@emp_med_allowance", (long)double.Parse(tb_save_medical.Text));
                        allowance_command.Parameters.AddWithValue("@emp_hr_allowance", (long)double.Parse(tb_save_house_rent.Text));
                        allowance_command.Parameters.AddWithValue("@emp_grosspay", (long)double.Parse(tb_save_gross_pay.Text));
                        allowance_command.Parameters.AddWithValue("@emp_incometax", (long)double.Parse(tb_save_income_tax.Text));
                        allowance_command.Parameters.AddWithValue("@emp_netsalary", (long)double.Parse(tb_save_net_salary.Text));
                        allowance_command.ExecuteNonQuery();
                        MessageBox.Show("Salary Saved!", "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        allowance_con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Salary of employee is already saved!", "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private bool checkSalaryAgainstEmpID()
        {
            bool answer;
            int id = int.Parse(cb_emp_id.Text);
            string sql_query = "SELECT * FROM salaryWithAllowances where emp_id='"+id+"'";
            try
            {
                SqlConnection allowance_con = new SqlConnection(allowance_string);
                allowance_con.Open();
                SqlCommand allowance_command = new SqlCommand(sql_query, allowance_con);
                SqlDataReader reader = allowance_command.ExecuteReader();
                answer=reader.HasRows;
                return answer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        private void refreshSalaryTable()
        {
            string sql_query = "SELECT * FROM salaryWithAllowances";
            try
            {
                SqlConnection allowance_con = new SqlConnection(allowance_string);
                allowance_con.Open();
                SqlCommand allowance_command = new SqlCommand(sql_query, allowance_con);
                SqlDataAdapter adapter = new SqlDataAdapter(allowance_command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgv_saved_allowances.DataSource = table;
                dgv_del_allowances.DataSource = table;
                allowance_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void Btn_setAllowances_refresh_Click(object sender, EventArgs e)
        {
            refreshSalaryTable();
        }

        private void Btn_refresh_editedInfo_table_Click(object sender, EventArgs e)
        {
            refreshSalaryTable();
        }

        private void Btn_del_allowance_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you really want to delete entry?","Employee PayRoll Management System",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(answer==DialogResult.Yes)
            {
                int val = (int)cb_del_allowances.SelectedValue;
                string del_query = "DELETE FROM salaryWithAllowances where emp_sal_id='" + val + "'";
                SqlConnection del_connection = new SqlConnection(allowance_string);
                try
                {
                    del_connection.Open();
                    SqlCommand del_command = new SqlCommand(del_query, del_connection);
                    del_command.ExecuteNonQuery();
                    MessageBox.Show("Salary of employee deleted successfully!", "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    del_connection.Close();
                    refreshSalaryTable();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            

        }

        private void Btn_save_final_salary_Click(object sender, EventArgs e)
        {
            if(cb_emp_id_final.SelectedIndex != -1)
            {
                string finalSalaryString = "INSERT INTO finalsalary(emp_id,emp_name,emp_email,emp_contact,sal_month,sal_year,emp_absentees,emp_netsalary" +
                    ",emp_dailywage,emp_finalsalary) values(@emp_id,@emp_name,@emp_email,@emp_contact,@sal_month,@sal_year,@emp_absentees," +
                    "@emp_netsalary,@emp_dailywage,@emp_finalsalary)";
                if(tb_numberOfAbsentees.Text!="" && tb_net_salary.Text!="" && tb_daily_wages.Text!="" && tb_final_salary.Text!="")
                {
                    bool checkAvailability = checkSalaryIfSaved();
                    if(checkAvailability == false)
                    {
                        SqlConnection final_connection = new SqlConnection(allowance_string);
                        try
                        {
                            final_connection.Open();
                            SqlCommand final_command = new SqlCommand(finalSalaryString, final_connection);
                            final_command.Parameters.AddWithValue("@emp_id", int.Parse(cb_emp_id_final.Text));
                            final_command.Parameters.AddWithValue("@emp_name", tb_employee_name.Text);
                            final_command.Parameters.AddWithValue("@emp_email", tb_employee_email.Text);
                            final_command.Parameters.AddWithValue("@emp_contact", long.Parse(tb_employee_contact.Text));
                            final_command.Parameters.AddWithValue("@sal_month", tb_month.Text);
                            final_command.Parameters.AddWithValue("@sal_year", int.Parse(tb_year.Text));
                            final_command.Parameters.AddWithValue("@emp_absentees", int.Parse(tb_numberOfAbsentees.Text));
                            final_command.Parameters.AddWithValue("@emp_netsalary", long.Parse(tb_net_salary.Text));
                            final_command.Parameters.AddWithValue("@emp_dailywage", long.Parse(tb_daily_wages.Text));
                            final_command.Parameters.AddWithValue("@emp_finalsalary", long.Parse(tb_final_salary.Text));
                            final_command.ExecuteNonQuery();
                            MessageBox.Show("Final salary of employee is saved!", "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            final_connection.Close();

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Final salary of employee is already saved!", "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                   
                }
                else
                {
                    MessageBox.Show("Some fields are empty!", "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Please select employee first!", "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool checkSalaryIfSaved()
        {
            bool result;
            string month = tb_month.Text;
            int year = int.Parse(tb_year.Text);
            int empID = int.Parse(cb_emp_id_final.Text);
            string check_query = "SELECT * FROM finalsalary where emp_id='"+empID+"' and sal_month='"+month+"' and sal_year='"+year+"'";
            SqlConnection final_connection = new SqlConnection(allowance_string);
            try
            {
                final_connection.Open();
                SqlCommand final_command = new SqlCommand(check_query, final_connection);
                SqlDataReader check_reader = final_command.ExecuteReader();
                result = check_reader.HasRows;
                //MessageBox.Show("Final salary of employee is saved!", "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                final_connection.Close();
                return result;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Cb_emp_id_final_SelectedIndexChanged(object sender, EventArgs e)
        {
            /////////////////////////////
            ///
            tb_numberOfAbsentees.Clear();
            tb_net_salary.Clear();
            tb_final_salary.Clear();
            tb_daily_wages.Clear();
            //////////////////////////////
            string emp_query ="SELECT * FROM employees where emp_id='"+cb_emp_id_final.SelectedValue+"'";
            if(cb_emp_id_final.SelectedIndex !=-1)
            {
                getTableOfAttendance(int.Parse(cb_emp_id_final.Text));
                getNumberOfAbsentees(int.Parse(cb_emp_id_final.Text));
                getNetSalaryOfEmployee(int.Parse(cb_emp_id_final.Text));
            }
            SqlConnection absent_connection = new SqlConnection(allowance_string);
            try
            {
                absent_connection.Open();
                SqlCommand absent_command = new SqlCommand(emp_query, absent_connection);
                SqlDataReader absent_reader = absent_command.ExecuteReader();
                while(absent_reader.Read())
                {
                    tb_employee_name.Text = (string)absent_reader["emp_first_name"] + " " + (string)absent_reader["emp_last_name"];
                    tb_employee_email.Text = (string)absent_reader["emp_email"];
                    tb_employee_contact.Text = absent_reader["emp_contact"].ToString();
                    MemoryStream emp_image = new MemoryStream((Byte[])absent_reader["emp_photo"]);
                    pb_employee.Image = Image.FromStream(emp_image);
                }
                absent_connection.Close();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void getNetSalaryOfEmployee(int selectedID)
        {
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            int numberOfDays = DateTime.DaysInMonth(year, month);
            string emp_query = "SELECT * FROM salaryWithAllowances where emp_id='" + selectedID+"'";
            SqlConnection absent_connection = new SqlConnection(allowance_string);
            try
            {
                absent_connection.Open();
                SqlCommand absent_command = new SqlCommand(emp_query, absent_connection);
                SqlDataReader absent_reader = absent_command.ExecuteReader();
                if (absent_reader.HasRows == true)
                {
                    while (absent_reader.Read())
                    {
                        tb_net_salary.Text = absent_reader["emp_netsalary"].ToString();
                    }
                }
                absent_connection.Close();
                long dailyWage = 0;
                if(tb_net_salary.Text != "")
                {
                    dailyWage = long.Parse(tb_net_salary.Text) / numberOfDays;
                    tb_daily_wages.Text = dailyWage.ToString();
                }
                else
                {
                    //tb_net_salary.Text = "0";
                    tb_daily_wages.Text = dailyWage.ToString();
                }
                
                
                long numberOfAbsentees = 0;
                if (tb_numberOfAbsentees.Text != "")
                {
                    numberOfAbsentees = long.Parse(tb_numberOfAbsentees.Text);
                }
                
                if(numberOfAbsentees != 0)
                {
                    long netSalary = long.Parse(tb_net_salary.Text);
                    long finalSalary = netSalary - (numberOfAbsentees * dailyWage);
                    tb_final_salary.Text = finalSalary.ToString();
                }
                else
                {
                    if(tb_net_salary.Text !="")
                    {
                        tb_numberOfAbsentees.Text = "0";
                    }
                    else
                    {
                        tb_numberOfAbsentees.Text = "";
                    }
                    
                    tb_final_salary.Text = tb_net_salary.Text;
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void getNumberOfAbsentees(int selectedID)
        {
            int numberOfRows = 0;
            string emp_query = "SELECT * FROM emp_attendance where emp_id='" + selectedID + "' and attend_status='Absent'";
            SqlConnection absent_connection = new SqlConnection(allowance_string);
            try
            {
                absent_connection.Open();
                SqlCommand absent_command = new SqlCommand(emp_query, absent_connection);
                SqlDataReader absent_reader = absent_command.ExecuteReader();
                if(absent_reader.HasRows == true)
                {
                    while(absent_reader.Read())
                    {
                        numberOfRows = numberOfRows + 1;
                        tb_numberOfAbsentees.Text = numberOfRows.ToString();
                    }
                }
                absent_connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void getTableOfAttendance(int selectedValue)
        {
            string emp_query = "SELECT * FROM emp_attendance where emp_id='" + selectedValue + "' and attend_status='Absent'";
            SqlConnection absent_connection = new SqlConnection(allowance_string);
            try
            {
                SqlCommand absent_command = new SqlCommand(emp_query, absent_connection);
                SqlDataAdapter absent_adapter = new SqlDataAdapter(absent_command);
                DataTable absent_table = new DataTable();
                absent_adapter.Fill(absent_table);
                dgv_attendance_table.DataSource = absent_table;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
        private void loadAttendanceTable()
        {
            string emp_query = "SELECT * FROM emp_attendance";
            SqlConnection absent_connection = new SqlConnection(allowance_string);
            try
            {
                SqlCommand absent_command = new SqlCommand(emp_query, absent_connection);
                SqlDataAdapter absent_adapter = new SqlDataAdapter(absent_command);
                DataTable absent_table = new DataTable();
                absent_adapter.Fill(absent_table);
                dgv_attendance_table.DataSource = absent_table;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Employees PayRoll Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Btn_view_final_salary_table_Click(object sender, EventArgs e)
        {
            EmployeesFinalSalaryTable efs = new EmployeesFinalSalaryTable();
            efs.ShowDialog();
        }
    }
}
