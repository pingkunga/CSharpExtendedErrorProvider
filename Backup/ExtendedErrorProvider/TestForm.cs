using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestProjectExtendedErrorProvider
{
    public partial class TestForm : Form
    {
        ErrorProviderExtended MyErrorProvider=new ErrorProviderExtended();
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            // Add controls one by one in error provider.
            MyErrorProvider.Controls.Add( (object)txtStudentName, "Student Full Name");
            MyErrorProvider.Controls.Add((object)txtStudentAge, "Age");
            MyErrorProvider.Controls.Add( (object)txtEmergencyContact, "Emergency Contact Number");
            // Initially make emergency contact field as non mandatory
            MyErrorProvider.Controls[txtEmergencyContact].Validate = false;
            MyErrorProvider.SummaryMessage = "Following fields are mandatory,";
        }

        private void cmdSubmit_Click(object sender, EventArgs e)
        {
            // Following function checks all empty fields and returns TRUE if all fields are entered.
            // If any mandotary field is empty this function displays a message and returns FALSE.
            if ((MyErrorProvider.CheckAndShowSummaryErrorMessage() == true))
            {
                MessageBox.Show("Data submited successfully.");
            }
        }

        private void chkAge_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAge.Checked)
            {
                // if student's age is less than 10, emergency contact is mandatory
                MyErrorProvider.Controls[txtEmergencyContact].Validate = true;
            }
            else
            {
                // if student's age is greater than 10, emergency contact is not mandatory
                MyErrorProvider.Controls[txtEmergencyContact].Validate = false;
            }
        }
    }
}