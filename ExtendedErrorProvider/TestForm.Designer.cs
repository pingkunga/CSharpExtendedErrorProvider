namespace TestProjectExtendedErrorProvider
{
    partial class TestForm
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
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtEmergencyContact = new System.Windows.Forms.TextBox();
            this.chkAge = new System.Windows.Forms.CheckBox();
            this.cmdSubmit = new System.Windows.Forms.Button();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtStudentAge = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(10, 191);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(128, 16);
            this.Label5.TabIndex = 23;
            this.Label5.Text = "Emergency Contact :";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(34, 55);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(104, 16);
            this.Label4.TabIndex = 22;
            this.Label4.Text = "Age :";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(34, 87);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(104, 16);
            this.Label3.TabIndex = 21;
            this.Label3.Text = "Address 1 :";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(34, 119);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(104, 16);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "Address 2 :";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(34, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(104, 16);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "Student Full name :";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmergencyContact
            // 
            this.txtEmergencyContact.Location = new System.Drawing.Point(138, 191);
            this.txtEmergencyContact.Name = "txtEmergencyContact";
            this.txtEmergencyContact.Size = new System.Drawing.Size(184, 20);
            this.txtEmergencyContact.TabIndex = 18;
            // 
            // chkAge
            // 
            this.chkAge.Location = new System.Drawing.Point(138, 159);
            this.chkAge.Name = "chkAge";
            this.chkAge.Size = new System.Drawing.Size(184, 24);
            this.chkAge.TabIndex = 17;
            this.chkAge.Text = "Student\'s age is less than 10";
            this.chkAge.CheckedChanged += new System.EventHandler(this.chkAge_CheckedChanged);
            // 
            // cmdSubmit
            // 
            this.cmdSubmit.Location = new System.Drawing.Point(138, 223);
            this.cmdSubmit.Name = "cmdSubmit";
            this.cmdSubmit.Size = new System.Drawing.Size(112, 24);
            this.cmdSubmit.TabIndex = 16;
            this.cmdSubmit.Text = "Submit";
            this.cmdSubmit.Click += new System.EventHandler(this.cmdSubmit_Click);
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(138, 119);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(208, 20);
            this.txtAddress2.TabIndex = 15;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(138, 87);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(208, 20);
            this.txtAddress1.TabIndex = 14;
            // 
            // txtStudentAge
            // 
            this.txtStudentAge.Location = new System.Drawing.Point(138, 55);
            this.txtStudentAge.Name = "txtStudentAge";
            this.txtStudentAge.Size = new System.Drawing.Size(208, 20);
            this.txtStudentAge.TabIndex = 13;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(138, 23);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(208, 20);
            this.txtStudentName.TabIndex = 12;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 274);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtEmergencyContact);
            this.Controls.Add(this.chkAge);
            this.Controls.Add(this.cmdSubmit);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.txtStudentAge);
            this.Controls.Add(this.txtStudentName);
            this.Name = "TestForm";
            this.Text = "Test Project";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtEmergencyContact;
        internal System.Windows.Forms.CheckBox chkAge;
        internal System.Windows.Forms.Button cmdSubmit;
        internal System.Windows.Forms.TextBox txtAddress2;
        internal System.Windows.Forms.TextBox txtAddress1;
        internal System.Windows.Forms.TextBox txtStudentAge;
        internal System.Windows.Forms.TextBox txtStudentName;
    }
}

