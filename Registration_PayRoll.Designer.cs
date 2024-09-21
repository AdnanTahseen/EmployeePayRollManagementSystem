
namespace EmployeePayRollManagementSystem
{
    partial class Registration_PayRoll
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration_PayRoll));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reg_close = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_save_registration = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_browse = new System.Windows.Forms.Button();
            this.pb_admin = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_contact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_repassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_lname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_fname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.emailErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.passwordErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.repasswordErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_reg_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_admin)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repasswordErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.btn_reg_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 41);
            this.panel1.TabIndex = 0;
            // 
            // btn_reg_close
            // 
            this.btn_reg_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_reg_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_reg_close.BackgroundImage")));
            this.btn_reg_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reg_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_reg_close.Location = new System.Drawing.Point(986, 0);
            this.btn_reg_close.Name = "btn_reg_close";
            this.btn_reg_close.Size = new System.Drawing.Size(38, 41);
            this.btn_reg_close.TabIndex = 8;
            this.btn_reg_close.Click += new System.EventHandler(this.btn_reg_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(297, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employees PayRoll Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btn_save_registration);
            this.groupBox1.Controls.Add(this.btn_browse);
            this.groupBox1.Controls.Add(this.pb_admin);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb_address);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_contact);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_repassword);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tb_password);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_email);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_lname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_fname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(338, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 532);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btn_save_registration
            // 
            this.btn_save_registration.AllowAnimations = true;
            this.btn_save_registration.AllowMouseEffects = true;
            this.btn_save_registration.AllowToggling = false;
            this.btn_save_registration.AnimationSpeed = 200;
            this.btn_save_registration.AutoGenerateColors = false;
            this.btn_save_registration.AutoRoundBorders = true;
            this.btn_save_registration.AutoSizeLeftIcon = true;
            this.btn_save_registration.AutoSizeRightIcon = true;
            this.btn_save_registration.BackColor = System.Drawing.Color.Transparent;
            this.btn_save_registration.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_save_registration.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save_registration.BackgroundImage")));
            this.btn_save_registration.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_save_registration.ButtonText = "Save Information";
            this.btn_save_registration.ButtonTextMarginLeft = 0;
            this.btn_save_registration.ColorContrastOnClick = 45;
            this.btn_save_registration.ColorContrastOnHover = 45;
            this.btn_save_registration.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_save_registration.CustomizableEdges = borderEdges1;
            this.btn_save_registration.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_save_registration.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_save_registration.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_save_registration.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_save_registration.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_save_registration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_registration.ForeColor = System.Drawing.Color.White;
            this.btn_save_registration.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save_registration.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_save_registration.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_save_registration.IconMarginLeft = 11;
            this.btn_save_registration.IconPadding = 10;
            this.btn_save_registration.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save_registration.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_save_registration.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_save_registration.IconSize = 25;
            this.btn_save_registration.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_save_registration.IdleBorderRadius = 32;
            this.btn_save_registration.IdleBorderThickness = 1;
            this.btn_save_registration.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_save_registration.IdleIconLeftImage = null;
            this.btn_save_registration.IdleIconRightImage = null;
            this.btn_save_registration.IndicateFocus = false;
            this.btn_save_registration.Location = new System.Drawing.Point(122, 489);
            this.btn_save_registration.Name = "btn_save_registration";
            this.btn_save_registration.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_save_registration.OnDisabledState.BorderRadius = 30;
            this.btn_save_registration.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_save_registration.OnDisabledState.BorderThickness = 1;
            this.btn_save_registration.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_save_registration.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_save_registration.OnDisabledState.IconLeftImage = null;
            this.btn_save_registration.OnDisabledState.IconRightImage = null;
            this.btn_save_registration.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_save_registration.onHoverState.BorderRadius = 30;
            this.btn_save_registration.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_save_registration.onHoverState.BorderThickness = 1;
            this.btn_save_registration.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_save_registration.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_save_registration.onHoverState.IconLeftImage = null;
            this.btn_save_registration.onHoverState.IconRightImage = null;
            this.btn_save_registration.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_save_registration.OnIdleState.BorderRadius = 30;
            this.btn_save_registration.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_save_registration.OnIdleState.BorderThickness = 1;
            this.btn_save_registration.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_save_registration.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_save_registration.OnIdleState.IconLeftImage = null;
            this.btn_save_registration.OnIdleState.IconRightImage = null;
            this.btn_save_registration.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_save_registration.OnPressedState.BorderRadius = 30;
            this.btn_save_registration.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_save_registration.OnPressedState.BorderThickness = 1;
            this.btn_save_registration.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_save_registration.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_save_registration.OnPressedState.IconLeftImage = null;
            this.btn_save_registration.OnPressedState.IconRightImage = null;
            this.btn_save_registration.Size = new System.Drawing.Size(150, 34);
            this.btn_save_registration.TabIndex = 8;
            this.btn_save_registration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save_registration.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_save_registration.TextMarginLeft = 0;
            this.btn_save_registration.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_save_registration.UseDefaultRadiusAndThickness = true;
            this.btn_save_registration.Click += new System.EventHandler(this.btn_save_registration_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.ForeColor = System.Drawing.Color.White;
            this.btn_browse.Location = new System.Drawing.Point(244, 434);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(92, 32);
            this.btn_browse.TabIndex = 7;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.Btn_browse_Click);
            // 
            // pb_admin
            // 
            this.pb_admin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_admin.Location = new System.Drawing.Point(154, 351);
            this.pb_admin.Name = "pb_admin";
            this.pb_admin.Size = new System.Drawing.Size(182, 70);
            this.pb_admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_admin.TabIndex = 3;
            this.pb_admin.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(34, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 60;
            this.label9.Text = "Image:";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(154, 295);
            this.tb_address.Multiline = true;
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(182, 43);
            this.tb_address.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(34, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 80;
            this.label8.Text = "Address:";
            // 
            // tb_contact
            // 
            this.passwordErrorProvider.SetIconPadding(this.tb_contact, 10);
            this.emailErrorProvider.SetIconPadding(this.tb_contact, 10);
            this.tb_contact.Location = new System.Drawing.Point(154, 262);
            this.tb_contact.Name = "tb_contact";
            this.tb_contact.Size = new System.Drawing.Size(182, 20);
            this.tb_contact.TabIndex = 5;
            this.tb_contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_contact_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(34, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 90;
            this.label7.Text = "Contact:";
            // 
            // tb_repassword
            // 
            this.tb_repassword.Location = new System.Drawing.Point(154, 229);
            this.tb_repassword.Name = "tb_repassword";
            this.tb_repassword.Size = new System.Drawing.Size(182, 20);
            this.tb_repassword.TabIndex = 4;
            this.tb_repassword.UseSystemPasswordChar = true;
            this.tb_repassword.Leave += new System.EventHandler(this.Tb_repassword_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(34, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 20);
            this.label10.TabIndex = 100;
            this.label10.Text = "Re-Password:";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(154, 196);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(182, 20);
            this.tb_password.TabIndex = 3;
            this.tb_password.UseSystemPasswordChar = true;
            this.tb_password.Leave += new System.EventHandler(this.Tb_password_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(34, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 100;
            this.label6.Text = "Password:";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(154, 163);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(182, 20);
            this.tb_email.TabIndex = 2;
            this.tb_email.Leave += new System.EventHandler(this.Tb_email_Leave);
            this.tb_email.MouseLeave += new System.EventHandler(this.Tb_email_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 110;
            this.label5.Text = "Email:";
            // 
            // tb_lname
            // 
            this.tb_lname.Location = new System.Drawing.Point(154, 130);
            this.tb_lname.Name = "tb_lname";
            this.tb_lname.Size = new System.Drawing.Size(182, 20);
            this.tb_lname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 120;
            this.label4.Text = "Last Name:";
            // 
            // tb_fname
            // 
            this.tb_fname.Location = new System.Drawing.Point(154, 97);
            this.tb_fname.Name = "tb_fname";
            this.tb_fname.Size = new System.Drawing.Size(182, 20);
            this.tb_fname.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 130;
            this.label3.Text = "First Name:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 88);
            this.panel2.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(83, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registration";
            // 
            // emailErrorProvider
            // 
            this.emailErrorProvider.ContainerControl = this;
            // 
            // passwordErrorProvider
            // 
            this.passwordErrorProvider.ContainerControl = this;
            // 
            // repasswordErrorProvider
            // 
            this.repasswordErrorProvider.ContainerControl = this;
            // 
            // Registration_PayRoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 625);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 625);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 625);
            this.Name = "Registration_PayRoll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registration_PayRoll";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_reg_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_admin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repasswordErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadButton btn_reg_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_save_registration;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.PictureBox pb_admin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_contact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_lname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_fname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider emailErrorProvider;
        private System.Windows.Forms.ErrorProvider passwordErrorProvider;
        private System.Windows.Forms.TextBox tb_repassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider repasswordErrorProvider;
    }
}