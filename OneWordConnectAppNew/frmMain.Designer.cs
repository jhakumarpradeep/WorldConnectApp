﻿namespace OneWordConnectApp
{
    partial class frmMain
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
            this.btnUserSetting = new System.Windows.Forms.Button();
            this.btnSessionStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbTimeSelection = new System.Windows.Forms.ComboBox();
            this.cmbDateSelection = new System.Windows.Forms.ComboBox();
            this.lblLogeedInUser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSessionSelection = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRoomSelection = new System.Windows.Forms.ComboBox();
            this.pbxMainCompnyLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMainCompnyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUserSetting
            // 
            this.btnUserSetting.BackColor = System.Drawing.Color.Lavender;
            this.btnUserSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserSetting.Location = new System.Drawing.Point(1, 107);
            this.btnUserSetting.Name = "btnUserSetting";
            this.btnUserSetting.Size = new System.Drawing.Size(75, 25);
            this.btnUserSetting.TabIndex = 8;
            this.btnUserSetting.Text = "User Setting";
            this.btnUserSetting.UseVisualStyleBackColor = false;
            this.btnUserSetting.Click += new System.EventHandler(this.btnUserSetting_Click);
            // 
            // btnSessionStart
            // 
            this.btnSessionStart.BackColor = System.Drawing.Color.Lavender;
            this.btnSessionStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSessionStart.Location = new System.Drawing.Point(75, 107);
            this.btnSessionStart.Name = "btnSessionStart";
            this.btnSessionStart.Size = new System.Drawing.Size(83, 25);
            this.btnSessionStart.TabIndex = 9;
            this.btnSessionStart.Text = "Go to Session";
            this.btnSessionStart.UseVisualStyleBackColor = false;
            this.btnSessionStart.Click += new System.EventHandler(this.btnSessionStart_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(157, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "Log Out";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.cmbTimeSelection);
            this.panel1.Controls.Add(this.cmbDateSelection);
            this.panel1.Controls.Add(this.lblLogeedInUser);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbSessionSelection);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbRoomSelection);
            this.panel1.Location = new System.Drawing.Point(4, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 42);
            this.panel1.TabIndex = 19;
            // 
            // cmbTimeSelection
            // 
            this.cmbTimeSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeSelection.FormattingEnabled = true;
            this.cmbTimeSelection.Location = new System.Drawing.Point(168, 10);
            this.cmbTimeSelection.Name = "cmbTimeSelection";
            this.cmbTimeSelection.Size = new System.Drawing.Size(69, 21);
            this.cmbTimeSelection.TabIndex = 28;
            this.cmbTimeSelection.SelectedIndexChanged += new System.EventHandler(this.cmbTimeSelection_SelectedIndexChanged);
            // 
            // cmbDateSelection
            // 
            this.cmbDateSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDateSelection.FormattingEnabled = true;
            this.cmbDateSelection.Location = new System.Drawing.Point(43, 9);
            this.cmbDateSelection.Name = "cmbDateSelection";
            this.cmbDateSelection.Size = new System.Drawing.Size(86, 21);
            this.cmbDateSelection.TabIndex = 27;
            // 
            // lblLogeedInUser
            // 
            this.lblLogeedInUser.AutoSize = true;
            this.lblLogeedInUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogeedInUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblLogeedInUser.Location = new System.Drawing.Point(1212, 14);
            this.lblLogeedInUser.Name = "lblLogeedInUser";
            this.lblLogeedInUser.Size = new System.Drawing.Size(41, 13);
            this.lblLogeedInUser.TabIndex = 21;
            this.lblLogeedInUser.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Session";
            // 
            // cmbSessionSelection
            // 
            this.cmbSessionSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSessionSelection.FormattingEnabled = true;
            this.cmbSessionSelection.Location = new System.Drawing.Point(426, 9);
            this.cmbSessionSelection.Name = "cmbSessionSelection";
            this.cmbSessionSelection.Size = new System.Drawing.Size(753, 21);
            this.cmbSessionSelection.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Date";
            // 
            // cmbRoomSelection
            // 
            this.cmbRoomSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomSelection.FormattingEnabled = true;
            this.cmbRoomSelection.Location = new System.Drawing.Point(284, 9);
            this.cmbRoomSelection.Name = "cmbRoomSelection";
            this.cmbRoomSelection.Size = new System.Drawing.Size(86, 21);
            this.cmbRoomSelection.TabIndex = 20;
            this.cmbRoomSelection.SelectedIndexChanged += new System.EventHandler(this.cmbRoomSelection_SelectedIndexChanged);
            // 
            // pbxMainCompnyLogo
            // 
            this.pbxMainCompnyLogo.BackColor = System.Drawing.SystemColors.Window;
            this.pbxMainCompnyLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbxMainCompnyLogo.Image = global::OneWordConnectApp.Properties.Resources.companyLogo;
            this.pbxMainCompnyLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxMainCompnyLogo.Name = "pbxMainCompnyLogo";
            this.pbxMainCompnyLogo.Size = new System.Drawing.Size(1217, 65);
            this.pbxMainCompnyLogo.TabIndex = 6;
            this.pbxMainCompnyLogo.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1217, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSessionStart);
            this.Controls.Add(this.btnUserSetting);
            this.Controls.Add(this.pbxMainCompnyLogo);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMainCompnyLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUserSetting;
        private System.Windows.Forms.Button btnSessionStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSessionSelection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRoomSelection;
        private System.Windows.Forms.PictureBox pbxMainCompnyLogo;
        private System.Windows.Forms.Label lblLogeedInUser;
        private System.Windows.Forms.ComboBox cmbTimeSelection;
        private System.Windows.Forms.ComboBox cmbDateSelection;
    }
}