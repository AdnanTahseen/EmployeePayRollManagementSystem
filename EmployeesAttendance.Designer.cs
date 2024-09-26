
namespace EmployeePayRollManagementSystem
{
    partial class EmployeesAttendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesAttendance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pb_emp_photo = new System.Windows.Forms.PictureBox();
            this.cb_emp_id = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.btn_save_attendance = new Syncfusion.WinForms.Controls.SfButton();
            this.btn_show_attendance_table = new XanderUI.XUIButton();
            this.dtp_emp_attendance = new System.Windows.Forms.DateTimePicker();
            this.cb_attend_status = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_emp_photo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1, -30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 101);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(249, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employees Attendance";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(723, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 47);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_email);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pb_emp_photo);
            this.groupBox1.Controls.Add(this.cb_emp_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(102, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 185);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Employee ID";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(145, 127);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(0, 16);
            this.lbl_email.TabIndex = 5;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(145, 92);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 16);
            this.lbl_name.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(86, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(86, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // pb_emp_photo
            // 
            this.pb_emp_photo.Image = ((System.Drawing.Image)(resources.GetObject("pb_emp_photo.Image")));
            this.pb_emp_photo.Location = new System.Drawing.Point(340, 25);
            this.pb_emp_photo.Name = "pb_emp_photo";
            this.pb_emp_photo.Size = new System.Drawing.Size(157, 132);
            this.pb_emp_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_emp_photo.TabIndex = 3;
            this.pb_emp_photo.TabStop = false;
            // 
            // cb_emp_id
            // 
            this.cb_emp_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_emp_id.FormattingEnabled = true;
            this.cb_emp_id.Location = new System.Drawing.Point(188, 32);
            this.cb_emp_id.Name = "cb_emp_id";
            this.cb_emp_id.Size = new System.Drawing.Size(109, 24);
            this.cb_emp_id.TabIndex = 0;
            this.cb_emp_id.SelectedIndexChanged += new System.EventHandler(this.Cb_emp_id_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bunifuSeparator1);
            this.groupBox2.Controls.Add(this.btn_save_attendance);
            this.groupBox2.Controls.Add(this.btn_show_attendance_table);
            this.groupBox2.Controls.Add(this.dtp_emp_attendance);
            this.groupBox2.Controls.Add(this.cb_attend_status);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(102, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 300);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attendance";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(8, 206);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(511, 15);
            this.bunifuSeparator1.TabIndex = 7;
            // 
            // btn_save_attendance
            // 
            this.btn_save_attendance.BackColor = System.Drawing.Color.MediumOrchid;
            this.btn_save_attendance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_save_attendance.ForeColor = System.Drawing.Color.White;
            this.btn_save_attendance.Location = new System.Drawing.Point(188, 126);
            this.btn_save_attendance.Name = "btn_save_attendance";
            this.btn_save_attendance.Size = new System.Drawing.Size(162, 50);
            this.btn_save_attendance.Style.BackColor = System.Drawing.Color.MediumOrchid;
            this.btn_save_attendance.Style.ForeColor = System.Drawing.Color.White;
            this.btn_save_attendance.TabIndex = 5;
            this.btn_save_attendance.Text = "Save Attendance";
            this.btn_save_attendance.UseVisualStyleBackColor = false;
            this.btn_save_attendance.Click += new System.EventHandler(this.Btn_save_attendance_Click);
            // 
            // btn_show_attendance_table
            // 
            this.btn_show_attendance_table.BackgroundColor = System.Drawing.Color.Coral;
            this.btn_show_attendance_table.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_show_attendance_table.ButtonImage")));
            this.btn_show_attendance_table.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_show_attendance_table.ButtonText = "View Attendance Record";
            this.btn_show_attendance_table.ClickBackColor = System.Drawing.Color.White;
            this.btn_show_attendance_table.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_show_attendance_table.CornerRadius = 5;
            this.btn_show_attendance_table.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_show_attendance_table.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_show_attendance_table.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_show_attendance_table.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_show_attendance_table.Location = new System.Drawing.Point(133, 229);
            this.btn_show_attendance_table.Name = "btn_show_attendance_table";
            this.btn_show_attendance_table.Size = new System.Drawing.Size(289, 66);
            this.btn_show_attendance_table.TabIndex = 1;
            this.btn_show_attendance_table.TextColor = System.Drawing.Color.Azure;
            this.btn_show_attendance_table.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_show_attendance_table.Click += new System.EventHandler(this.Btn_show_attendance_table_Click);
            // 
            // dtp_emp_attendance
            // 
            this.dtp_emp_attendance.CustomFormat = "";
            this.dtp_emp_attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_emp_attendance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_emp_attendance.Location = new System.Drawing.Point(335, 40);
            this.dtp_emp_attendance.Name = "dtp_emp_attendance";
            this.dtp_emp_attendance.Size = new System.Drawing.Size(162, 26);
            this.dtp_emp_attendance.TabIndex = 3;
            this.dtp_emp_attendance.Value = new System.DateTime(2024, 9, 25, 22, 36, 3, 0);
            // 
            // cb_attend_status
            // 
            this.cb_attend_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_attend_status.FormattingEnabled = true;
            this.cb_attend_status.Items.AddRange(new object[] {
            "Present",
            "Absent"});
            this.cb_attend_status.Location = new System.Drawing.Point(102, 42);
            this.cb_attend_status.Name = "cb_attend_status";
            this.cb_attend_status.Size = new System.Drawing.Size(121, 28);
            this.cb_attend_status.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(266, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Status:";
            // 
            // EmployeesAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(763, 655);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(763, 655);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(763, 655);
            this.Name = "EmployeesAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmployeesAttendance";
            this.Load += new System.EventHandler(this.EmployeesAttendance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_emp_photo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private XanderUI.XUIButton btn_show_attendance_table;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb_emp_photo;
        private System.Windows.Forms.ComboBox cb_emp_id;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_attend_status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Syncfusion.WinForms.Controls.SfButton btn_save_attendance;
        private System.Windows.Forms.DateTimePicker dtp_emp_attendance;
    }
}