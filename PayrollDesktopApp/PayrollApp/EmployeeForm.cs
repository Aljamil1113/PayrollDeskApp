using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void btnExitEmployee_Click(object sender, EventArgs e)
        {
            this.Close();
        }


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
    }
}
