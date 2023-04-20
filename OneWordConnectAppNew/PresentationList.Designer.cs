namespace OneWordConnectApp
{
    partial class PresentationList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPresenterName = new System.Windows.Forms.Label();
            this.lnkPresentationName = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblPresenterName
            // 
            this.lblPresenterName.AutoSize = true;
            this.lblPresenterName.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresenterName.Location = new System.Drawing.Point(15, 26);
            this.lblPresenterName.Name = "lblPresenterName";
            this.lblPresenterName.Size = new System.Drawing.Size(123, 16);
            this.lblPresenterName.TabIndex = 0;
            this.lblPresenterName.Text = "Automated LOI Testing";
            // 
            // lnkPresentationName
            // 
            this.lnkPresentationName.AutoEllipsis = true;
            this.lnkPresentationName.AutoSize = true;
            this.lnkPresentationName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkPresentationName.Location = new System.Drawing.Point(12, 10);
            this.lnkPresentationName.Name = "lnkPresentationName";
            this.lnkPresentationName.Size = new System.Drawing.Size(115, 14);
            this.lnkPresentationName.TabIndex = 1;
            this.lnkPresentationName.TabStop = true;
            this.lnkPresentationName.Text = "Automated LOI Testing";
            this.lnkPresentationName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPresentationName_LinkClicked);
            this.lnkPresentationName.Click += new System.EventHandler(this.lnkPresentationName_Click);
            // 
            // PresentationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lnkPresentationName);
            this.Controls.Add(this.lblPresenterName);
            this.Name = "PresentationList";
            this.Size = new System.Drawing.Size(875, 50);
            this.Load += new System.EventHandler(this.PresentationList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPresenterName;
        private System.Windows.Forms.LinkLabel lnkPresentationName;
    }
}
