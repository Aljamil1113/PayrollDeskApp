using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollApp
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        #region ACTION BUTTONS
        private void btnExitEmployee_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if(isControlValid())
            {
                MessageBox.Show("New Employee Added!");
            }
        }

        private void btnResetEmployee_Click(object sender, EventArgs e)
        {
            txtEmployeeID.Clear();
            txtFirstname.Clear();
            txtLastName.Text = "";
            rdMale.Checked = false;
            rdFemale.Checked = false;
            txtNatInsurance.Text = "";
            dtDateOfBirth.Value = new DateTime(DateTime.Now.Ticks);
            rdMarried.Checked = false;
            rdFemale.Checked = false;
            chkIsMember.Checked = false;
            txtAddress.Text = "";
            txtCity.Text = "";
            txtPostCode.Text = "";
            cmbCountry.SelectedIndex = 0;
            txtPhoneNumber.Text = "";
            txtEmailAddress.Text = "";
            txtNotes.Text = "";
        }
        #endregion

        #region IMPLICIT VALIDATIONS
        //IMPLICIT VALIDATION TO INPUT NUMBERS ONLY
        bool IsNumberOrBackSpace;
        private void txtEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsNumberOrBackSpace = false;

            if(char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                IsNumberOrBackSpace = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsNumberOrBackSpace = false;

            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                IsNumberOrBackSpace = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        #endregion

        #region EXPLICIT VALIDATIONS
        private bool isControlValid()
        {
            Regex objEmployeeID = new Regex("^[0-9]{3,4}$");
            Regex objFirstName = new Regex("^[A-Z][a-zA-Z]*$");
            Regex objLastName = new Regex("^[A-Z][a-zA-Z]*$");
            Regex objIN = new Regex(@"[A-CEGHJ-PR-TW-Z]{1}[A-CEGHJ-NPR-TW-Z]{1}[0-9]{6}[A-D\s]$");
            Regex objEmail = new Regex(@"[a-zA-Z0-9]{1,30}@[a-zA-Z0-9]{1,30}.[a-zA-Z]{2,3}");
            //EMPLOYEEID
            if (Convert.ToInt32(txtEmployeeID.Text.Length) < 1)
            {
                MessageBox.Show("Please, Enter Employee ID", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeID.Focus();
                txtEmployeeID.BackColor = Color.Silver;
                return false;
            }
            else if(!objEmployeeID.IsMatch(txtEmployeeID.Text))
            {
                MessageBox.Show("Please, Enter valid Employee ID", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeID.Focus();
                txtEmployeeID.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtEmployeeID.BackColor = Color.White;
            }

            //FIRSTNAME
            if (string.IsNullOrEmpty(txtFirstname.Text))
            {
                MessageBox.Show("Please enter First Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstname.Focus();
                txtFirstname.BackColor = Color.Silver;
                return false;
            }
            else if(!objFirstName.IsMatch(txtFirstname.Text))
            {
                MessageBox.Show("Please, Enter valid First Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeID.Focus();
                txtEmployeeID.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtFirstname.BackColor = Color.White;
            }

            //LAST NAME
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Please Enter Last Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                txtLastName.BackColor = Color.Silver;
                return false;
            }
            else if(!objLastName.IsMatch(txtLastName.Text))
            {
                MessageBox.Show("Please, Enter valid Last Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeID.Focus();
                txtEmployeeID.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtLastName.BackColor = Color.White;
            }

            // GENDER
            if (rdFemale.Checked == false && rdMale.Checked == false)
            {
                MessageBox.Show("Please Enter checked either Male or Female", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grpGender.Focus();
                rdMale.BackColor = Color.Silver;
                rdFemale.BackColor = Color.Silver;
                return false;
            }
            else
            {
                rdMale.BackColor = Color.CornflowerBlue;
                rdFemale.BackColor = Color.CornflowerBlue;
            }

            //National Insurance
            if (string.IsNullOrEmpty(txtNatInsurance.Text))
            {
                MessageBox.Show("Please Enter national Insurance No.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNatInsurance.Focus();
                txtNatInsurance.BackColor = Color.Silver;
                return false;
            }
            else if(!objIN.IsMatch(txtNatInsurance.Text))
            {
                MessageBox.Show("Please, Enter valid Insurance No.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeID.Focus();
                txtEmployeeID.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtNatInsurance.BackColor = Color.White;
            }

            //Marital Status
            if (rdMarried.Checked == false && rdSingle.Checked == false)
            {
                MessageBox.Show("Please Enter checked either Single or Married", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grpMaritalStatus.Focus();
                rdSingle.BackColor = Color.Silver;
                rdMarried.BackColor = Color.Silver;
                return false;
            }
            else
            {
                rdSingle.BackColor = Color.CornflowerBlue;
                rdMarried.BackColor = Color.CornflowerBlue;
            }

            //Address
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please Enter Address", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                txtAddress.BackColor = Color.Silver;
                return false;
            }

            else
            {
                txtAddress.BackColor = Color.White;
            }

            //CITY
            if (string.IsNullOrEmpty(txtCity.Text))
            {
                MessageBox.Show("Please Enter City", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCity.Focus();
                txtCity.BackColor = Color.Silver;
                return false;
            }

            else
            {
                txtCity.BackColor = Color.White;
            }

            //POST CODE
            if (string.IsNullOrEmpty(txtPostCode.Text))
            {
                MessageBox.Show("Please Enter Post Code", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPostCode.Focus();
                txtPostCode.BackColor = Color.Silver;
                return false;
            }

            else
            {
                txtPostCode.BackColor = Color.White;
            }


            //COUNTRY
            if (cmbCountry.SelectedIndex == 0 || cmbCountry.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a country?", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCountry.Focus();
                cmbCountry.BackColor = Color.Silver;
                return false;
            }
            else
            {
                cmbCountry.BackColor = Color.White;
            }


            //PHONENUMBER
            if (Convert.ToInt32(txtPhoneNumber.Text.Length) < 1)
            {
                MessageBox.Show("Please, Enter Phone Number", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumber.Focus();
                txtPhoneNumber.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtPhoneNumber.BackColor = Color.White;
            }


            //EMAIL ADDRESS
            if (string.IsNullOrEmpty(txtEmailAddress.Text))
            {
                MessageBox.Show("Please Enter Email Address", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailAddress.Focus();
                txtEmailAddress.BackColor = Color.Silver;
                return false;
            }
            //else if(!objEmail.IsMatch(txtEmailAddress.Text))
            //{
            //    MessageBox.Show("Please, Enter valid Email Address", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtEmployeeID.Focus();
            //    txtEmployeeID.BackColor = Color.Silver;
            //    return false;
            //}
            else if(txtEmailAddress.Text.Length >= 1)
            {
                try
                {
                    MailAddress objMail= new MailAddress(txtEmailAddress.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmployeeID.Focus();
                    txtEmployeeID.BackColor = Color.Silver;
                    return false;
                }
            }
            else
            {
                txtEmailAddress.BackColor = Color.White;
            }

            //NOTES
            if (txtNotes.Text.Length > 30)
            {
                MessageBox.Show("Too much text! Please enter fewer text", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNotes.Focus();
                txtNotes.BackColor = Color.Silver;
                return false;
            }

            else
            {
                txtNotes.BackColor = Color.White;
            }

            return true;


        }
        #endregion
    }
}
