namespace LabAss3
{
    partial class frmCustomerPreview
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lblHobby = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(31, 54);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(98, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Customer Name";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(141, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nabil";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(31, 113);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(91, 13);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Country Name";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(141, 113);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(77, 13);
            this.lblCountry.TabIndex = 3;
            this.lblCountry.Text = "Bangladesh";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(31, 171);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(28, 13);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "Sex";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(141, 171);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(35, 13);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Male";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(31, 236);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(56, 13);
            this.lbl7.TabIndex = 6;
            this.lbl7.Text = "Hobbies";
            // 
            // lblHobby
            // 
            this.lblHobby.AutoSize = true;
            this.lblHobby.Location = new System.Drawing.Point(141, 236);
            this.lblHobby.Name = "lblHobby";
            this.lblHobby.Size = new System.Drawing.Size(56, 13);
            this.lblHobby.TabIndex = 7;
            this.lblHobby.Text = "Reading";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(31, 304);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(49, 13);
            this.lbl9.TabIndex = 8;
            this.lbl9.Text = "Status";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(141, 304);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(70, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Unmarried";
            // 
            // frmCustomerPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lblHobby);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lbl1);
            this.Name = "frmCustomerPreview";
            this.Text = "Preview Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lblHobby;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lblStatus;
    }
}