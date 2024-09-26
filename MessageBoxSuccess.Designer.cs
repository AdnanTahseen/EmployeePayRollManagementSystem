
namespace EmployeePayRollManagementSystem
{
    partial class MessageBoxSuccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxSuccess));
            this.radFormConverter1 = new Telerik.WinControls.UI.RadFormConverter();
            this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.xuiBanner1 = new XanderUI.XUIBanner();
            this.lbl_mbox = new System.Windows.Forms.Label();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.ForestGreen;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.lbl_mbox);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(11, 53);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(439, 91);
            this.bunifuCards1.TabIndex = 0;
            // 
            // xuiBanner1
            // 
            this.xuiBanner1.BackColor = System.Drawing.Color.Transparent;
            this.xuiBanner1.BannerColor = System.Drawing.Color.Green;
            this.xuiBanner1.BorderColor = System.Drawing.Color.Green;
            this.xuiBanner1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiBanner1.ForeColor = System.Drawing.Color.Ivory;
            this.xuiBanner1.Location = new System.Drawing.Point(145, 10);
            this.xuiBanner1.Name = "xuiBanner1";
            this.xuiBanner1.Size = new System.Drawing.Size(194, 37);
            this.xuiBanner1.TabIndex = 1;
            this.xuiBanner1.Text = "Success";
            // 
            // lbl_mbox
            // 
            this.lbl_mbox.AutoSize = true;
            this.lbl_mbox.ForeColor = System.Drawing.Color.White;
            this.lbl_mbox.Location = new System.Drawing.Point(18, 34);
            this.lbl_mbox.Name = "lbl_mbox";
            this.lbl_mbox.Size = new System.Drawing.Size(0, 13);
            this.lbl_mbox.TabIndex = 1;
            // 
            // MessageBoxSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(467, 167);
            this.Controls.Add(this.xuiBanner1);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageBoxSuccess";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Employee";
            this.ThemeName = "Desert";
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadFormConverter radFormConverter1;
        private Telerik.WinControls.Themes.DesertTheme desertTheme1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private XanderUI.XUIBanner xuiBanner1;
        private System.Windows.Forms.Label lbl_mbox;
    }
}
