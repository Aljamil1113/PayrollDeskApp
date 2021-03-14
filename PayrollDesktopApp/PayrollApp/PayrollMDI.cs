using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PayrollApp
{
    public partial class PayrollMDI : Form
    {
        EmployeeForm objEmployeeForm = null;
        PayrollCalculator objPayrollCalculator = null;
        AboutPayrollSystem objAboutPayrollSystem = null;
        RegisterUser objRegisterUser = null;
        public PayrollMDI()
        {
            InitializeComponent();
        }

        private void manageEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if(objEmployeeForm == null)
            {
                objEmployeeForm = new EmployeeForm();
                objEmployeeForm.MdiParent = this;
                objEmployeeForm.FormClosed += objEmployeeForm_FormClosed;
                objEmployeeForm.Show();
            }
            else
            {
                objEmployeeForm.Activate();
            }
        }

        

        private void payrollCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(objPayrollCalculator == null)
            {
                objPayrollCalculator = new PayrollCalculator();
                objPayrollCalculator.MdiParent = this;
                objPayrollCalculator.FormClosed += objPayrollCalculator_FormClosed;
                objPayrollCalculator.Visible = true;
            }
            else
            {
                objPayrollCalculator.Activate();
            }
        }

        private void registerUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(objRegisterUser == null)
            {
                objRegisterUser = new RegisterUser();
                objRegisterUser.MdiParent = this;
                objRegisterUser.FormClosed += objRegisterUser_FormClosed;
                objRegisterUser.Show();
            }
            else
            {
                objRegisterUser.Activate();
            }
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manageEmployeeMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objEmployeeForm == null)
            {
                objEmployeeForm = new EmployeeForm();
                objEmployeeForm.MdiParent = this;
                objEmployeeForm.FormClosed += objEmployeeForm_FormClosed;
                objEmployeeForm.Show();
            }
            else
            {
                objEmployeeForm.Activate();
            }
        }

        private void payrollCalculatorMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objPayrollCalculator == null)
            {
                objPayrollCalculator = new PayrollCalculator();
                objPayrollCalculator.MdiParent = this;
                objPayrollCalculator.FormClosed += objPayrollCalculator_FormClosed;
                objPayrollCalculator.Visible = true;
            }
            else
            {
                objPayrollCalculator.Activate();
            }
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void arrangeIconToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void aboutPayrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(objAboutPayrollSystem == null)
            {
                objAboutPayrollSystem = new AboutPayrollSystem();
                objAboutPayrollSystem.MdiParent = this;
                objAboutPayrollSystem.FormClosed += objAboutPayrollSystem_FormClosed;
                objAboutPayrollSystem.Show();
            }
            else
            {
                objAboutPayrollSystem.Activate();
            }
           
        }

        #region SET NULL AGAIN IF THE WINDOW CLOSED
        private void objPayrollCalculator_FormClosed(object sender, FormClosedEventArgs e)
        {
            objPayrollCalculator = null;
        }

        private void objEmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            objEmployeeForm = null;
        }

        private void objAboutPayrollSystem_FormClosed(object sender, FormClosedEventArgs e)
        {
            objAboutPayrollSystem = null;
        }

        private void objRegisterUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            objRegisterUser = null;
        }
        #endregion

        private void PayrollMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult objDialogResult = MessageBox.Show("Are you sure you want to exit this application", "Form Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
            
            if(objDialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                Login objLogIn = new Login();
                objLogIn.Visible = true;
            }
        }
    }
}
