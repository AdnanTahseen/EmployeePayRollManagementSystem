using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EmployeePayRollManagementSystem
{
    static class Program
    {
        public static Login_PayRoll log_pr;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            log_pr = new Login_PayRoll();
            //Application.Run(log_pr);
            //Application.Run(new Registration_PayRoll());
            Application.Run(new NewEmployees());
        }
    }
}
