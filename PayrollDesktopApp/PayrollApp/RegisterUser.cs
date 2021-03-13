using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PayrollApp
{
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void ClearControls()
        {
            txtRegisterUsername.Text = "";
            txtRegisterPassword.Text = "";
            txtRegisterRole.Text = "";
            txtRegisterRoleDescription.Text = "";
        }

        #region CHECK VALID PASSWORD
        private int CheckNumeric(string strPassword)
        {
            int numberOfDigits = 0;

            foreach (char ch in strPassword)
            {
                if (char.IsDigit(ch))
                    numberOfDigits++;
            }

            return numberOfDigits;
        }

        private int CheckLowerCase(string strPassword)
        {
            int numOfLowercase = 0;

            foreach (char cd in strPassword)
            {
                if (char.IsLower(cd))
                    numOfLowercase++;
            }
            return numOfLowercase;
        }

        private int checkUpperCase(string strPassword)
        {
            int numOfUppercase = 0;
            foreach (var ch in strPassword)
            {
                if (char.IsUpper(ch))
                    numOfUppercase++;
            }

            return numOfUppercase;
        }
        #endregion

        private bool isRegisterControlValid()
        {
            if(txtRegisterUsername.Text.Length == 0)
            {
                MessageBox.Show("Please enter username.", "Data Enter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterUsername.Focus();
                return false;
            }

            //Password must be a minimum of 8 characters long
            //Password must contain at least one uppercase letter
            //Password must contain at least one lowercase letter
            //Password must contain at least one numeric digit

            if (txtRegisterPassword.Text.Length == 0)
            {
                MessageBox.Show("Please enter password.", "Data Enter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterPassword.Focus();
                return false;
            }
            else
            {
                if(txtRegisterPassword.Text.Length < 8 || CheckNumeric(txtRegisterPassword.Text) < 1 ||
                    CheckLowerCase(txtRegisterPassword.Text) < 1 || checkUpperCase(txtRegisterPassword.Text) < 1)
                {
                    MessageBox.Show("Please enter a valid password. \n\nHint: \n\tPassword must be a minimum of 8 characters long. \n\t" +
                        "Password must contain at least one uppercase letter. \n\t" + "Password must contain at least one lowercase letter. \n\t" +
                        "Password must contain at least one numeric digit.", 
                        "Data Enter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRegisterPassword.Focus();
                    return false;
                }
            }

            if (txtRegisterConfirmPassword.Text.Length == 0)
            {
                MessageBox.Show("Please enter confirm password.", "Data Enter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterConfirmPassword.Focus();
                return false;
            }
            else
            {
                if (txtRegisterConfirmPassword.Text != txtRegisterPassword.Text)
                {
                    MessageBox.Show("Both password do not match, please try again!.", "Data Enter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRegisterConfirmPassword.Focus();
                    return false;
                }
            }

            if (txtRegisterRole.Text.Length == 0)
            {
                MessageBox.Show("Please enter role.", "Data Enter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterRole.Focus();
                return false;
            }
            


            return true;
        }
        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            if(isRegisterControlValid())
            {
                MessageBox.Show("VALID DATA");
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {

        }

        private void btnResetUser_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

        }
    }
}
