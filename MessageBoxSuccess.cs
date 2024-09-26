using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeePayRollManagementSystem
{
    public partial class MessageBoxSuccess : Telerik.WinControls.UI.RadForm
    {
        public MessageBoxSuccess(string message)
        {
            InitializeComponent();
            lbl_mbox.Text = message;
        }
    }
}
