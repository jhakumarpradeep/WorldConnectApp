namespace OneWordConnectApp
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLoginImage = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbConference = new System.Windows.Forms.ComboBox();
            this.btnStopSynchUp = new System.Windows.Forms.Button();
            this.btnStartSynchUp = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pbxLoginCompanyLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoginCompanyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 417);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlLoginImage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(911, 417);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlLoginImage
            // 
            this.pnlLoginImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlLoginImage.BackgroundImage = global::OneWordConnectApp.Properties.Resources.Logo;
            this.pnlLoginImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLoginImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoginImage.Location = new System.Drawing.Point(4, 4);
            this.pnlLoginImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLoginImage.Name = "pnlLoginImage";
            this.pnlLoginImage.Size = new System.Drawing.Size(447, 409);
            this.pnlLoginImage.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.cmbConference);
            this.panel3.Controls.Add(this.btnStopSynchUp);
            this.panel3.Controls.Add(this.btnStartSynchUp);
            this.panel3.Controls.Add(this.btnLogin);
            this.panel3.Controls.Add(this.pbxLoginCompanyLogo);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Controls.Add(this.txtuser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(459, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(448, 409);
            this.panel3.TabIndex = 1;
            // 
            // cmbConference
            // 
            this.cmbConference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbConference.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConference.FormattingEnabled = true;
            this.cmbConference.Location = new System.Drawing.Point(80, 206);
            this.cmbConference.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbConference.Name = "cmbConference";
            this.cmbConference.Size = new System.Drawing.Size(248, 24);
            this.cmbConference.TabIndex = 15;
            // 
            // btnStopSynchUp
            // 
            this.btnStopSynchUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStopSynchUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnStopSynchUp.FlatAppearance.BorderSize = 0;
            this.btnStopSynchUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopSynchUp.Location = new System.Drawing.Point(248, 347);
            this.btnStopSynchUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStopSynchUp.Name = "btnStopSynchUp";
            this.btnStopSynchUp.Size = new System.Drawing.Size(196, 31);
            this.btnStopSynchUp.TabIndex = 14;
            this.btnStopSynchUp.Text = "Stop Data SynchUp";
            this.btnStopSynchUp.UseVisualStyleBackColor = false;
            this.btnStopSynchUp.Click += new System.EventHandler(this.btnStopSynchUp_Click);
            // 
            // btnStartSynchUp
            // 
            this.btnStartSynchUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStartSynchUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnStartSynchUp.FlatAppearance.BorderSize = 0;
            this.btnStartSynchUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartSynchUp.Location = new System.Drawing.Point(16, 349);
            this.btnStartSynchUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStartSynchUp.Name = "btnStartSynchUp";
            this.btnStartSynchUp.Size = new System.Drawing.Size(196, 31);
            this.btnStartSynchUp.TabIndex = 13;
            this.btnStartSynchUp.Text = "Start Data SynchUp";
            this.btnStartSynchUp.UseVisualStyleBackColor = false;
            this.btnStartSynchUp.Click += new System.EventHandler(this.btnStartSynchUp_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(160, 289);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(81, 31);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pbxLoginCompanyLogo
            // 
            this.pbxLoginCompanyLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxLoginCompanyLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLoginCompanyLogo.Image")));
            this.pbxLoginCompanyLogo.Location = new System.Drawing.Point(81, 80);
            this.pbxLoginCompanyLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxLoginCompanyLogo.Name = "pbxLoginCompanyLogo";
            this.pbxLoginCompanyLogo.Size = new System.Drawing.Size(248, 84);
            this.pbxLoginCompanyLogo.TabIndex = 11;
            this.pbxLoginCompanyLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(83, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Conference";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPassword.Location = new System.Drawing.Point(81, 257);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(247, 22);
            this.txtPassword.TabIndex = 8;
            // 
            // txtuser
            // 
            this.txtuser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtuser.Location = new System.Drawing.Point(81, 206);
            this.txtuser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(247, 22);
            this.txtuser.TabIndex = 7;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 417);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(925, 425);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoginCompanyLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlLoginImage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pbxLoginCompanyLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button btnStopSynchUp;
        private System.Windows.Forms.Button btnStartSynchUp;
        private System.Windows.Forms.ComboBox cmbConference;
    }
}