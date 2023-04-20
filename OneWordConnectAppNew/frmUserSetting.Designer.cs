namespace OneWordConnectApp
{
    partial class frmUserSetting
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SelectImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtLogoSelection = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBackgroundShow = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLoginImageSelection = new System.Windows.Forms.TextBox();
            this.bnBrowseLogo = new System.Windows.Forms.Button();
            this.btnBrowseShow = new System.Windows.Forms.Button();
            this.btnBrowseLogin = new System.Windows.Forms.Button();
            this.selectedBackGroundImage = new System.Windows.Forms.OpenFileDialog();
            this.selectedLoginImage = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(77, 173);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(101, 25);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // SelectImageFileDialog
            // 
            this.SelectImageFileDialog.FileName = "openFileDialog1";
            // 
            // txtLogoSelection
            // 
            this.txtLogoSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtLogoSelection.Location = new System.Drawing.Point(77, 43);
            this.txtLogoSelection.Name = "txtLogoSelection";
            this.txtLogoSelection.ReadOnly = true;
            this.txtLogoSelection.Size = new System.Drawing.Size(278, 20);
            this.txtLogoSelection.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Logo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Background Show";
            // 
            // txtBackgroundShow
            // 
            this.txtBackgroundShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBackgroundShow.Location = new System.Drawing.Point(77, 87);
            this.txtBackgroundShow.Name = "txtBackgroundShow";
            this.txtBackgroundShow.ReadOnly = true;
            this.txtBackgroundShow.Size = new System.Drawing.Size(281, 20);
            this.txtBackgroundShow.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Background Login";
            // 
            // txtLoginImageSelection
            // 
            this.txtLoginImageSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtLoginImageSelection.Location = new System.Drawing.Point(77, 134);
            this.txtLoginImageSelection.Name = "txtLoginImageSelection";
            this.txtLoginImageSelection.ReadOnly = true;
            this.txtLoginImageSelection.Size = new System.Drawing.Size(282, 20);
            this.txtLoginImageSelection.TabIndex = 15;
            // 
            // bnBrowseLogo
            // 
            this.bnBrowseLogo.Location = new System.Drawing.Point(352, 42);
            this.bnBrowseLogo.Name = "bnBrowseLogo";
            this.bnBrowseLogo.Size = new System.Drawing.Size(75, 23);
            this.bnBrowseLogo.TabIndex = 17;
            this.bnBrowseLogo.Text = "Browse";
            this.bnBrowseLogo.UseVisualStyleBackColor = true;
            this.bnBrowseLogo.Click += new System.EventHandler(this.bnBrowseLogo_Click);
            // 
            // btnBrowseShow
            // 
            this.btnBrowseShow.Location = new System.Drawing.Point(354, 86);
            this.btnBrowseShow.Name = "btnBrowseShow";
            this.btnBrowseShow.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseShow.TabIndex = 18;
            this.btnBrowseShow.Text = "Browse";
            this.btnBrowseShow.UseVisualStyleBackColor = true;
            this.btnBrowseShow.Click += new System.EventHandler(this.btnBrowseShow_Click);
            // 
            // btnBrowseLogin
            // 
            this.btnBrowseLogin.Location = new System.Drawing.Point(353, 133);
            this.btnBrowseLogin.Name = "btnBrowseLogin";
            this.btnBrowseLogin.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseLogin.TabIndex = 19;
            this.btnBrowseLogin.Text = "Browse";
            this.btnBrowseLogin.UseVisualStyleBackColor = true;
            this.btnBrowseLogin.Click += new System.EventHandler(this.btnBrowseLogin_Click);
            // 
            // selectedBackGroundImage
            // 
            this.selectedBackGroundImage.FileName = "openFileDialog1";
            // 
            // selectedLoginImage
            // 
            this.selectedLoginImage.FileName = "openFileDialog2";
            // 
            // frmUserSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(536, 282);
            this.Controls.Add(this.btnBrowseLogin);
            this.Controls.Add(this.btnBrowseShow);
            this.Controls.Add(this.bnBrowseLogo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLoginImageSelection);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBackgroundShow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLogoSelection);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserSetting";
            this.ShowInTaskbar = false;
            this.Text = "User Setting";
            this.Load += new System.EventHandler(this.frmUserSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.OpenFileDialog SelectImageFileDialog;
        private System.Windows.Forms.TextBox txtLogoSelection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBackgroundShow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLoginImageSelection;
        private System.Windows.Forms.Button bnBrowseLogo;
        private System.Windows.Forms.Button btnBrowseShow;
        private System.Windows.Forms.Button btnBrowseLogin;
        private System.Windows.Forms.OpenFileDialog selectedBackGroundImage;
        private System.Windows.Forms.OpenFileDialog selectedLoginImage;
    }
}