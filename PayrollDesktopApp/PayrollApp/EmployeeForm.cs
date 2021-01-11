using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            LoadData();
        }

        #region ACTION BUTTONS
        private void btnExitEmployee_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearControls()
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
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if(isControlValid())
            {
                CheckedItems();
                string connectionString = @"Data Source=DESKTOP-KGQRUI1;Initial Catalog=PayrollSystemDB;Integrated Security=True";
                SqlConnection sqlCon = new SqlConnection(connectionString);

                try
                {
                    sqlCon.Open();

                    string insertCommand = "INSERT INTO tblEmployee VALUES ("+ Convert.ToInt32(txtEmployeeID.Text)+ ",'" + txtFirstname.Text + "', '" + txtLastName.Text
                        + "','" + Gender + "','" + txtNatInsurance.Text + "','" + dtDateOfBirth.Value.ToString("MM/dd/yyyy") + "','" + MaritalStatus 
                        + "','" + isMember + "','" + txtAddress.Text + "','" + txtCity.Text + "','" + txtPostCode.Text + "','" + cmbCountry.SelectedItem.ToString() + 
                        "','" + txtPhoneNumber.Text + "','" + txtEmailAddress.Text + "','" + txtNotes.Text + "')";

                    SqlCommand objCommand = new SqlCommand(insertCommand, sqlCon);
                    objCommand.ExecuteNonQuery();

                    LoadData();

                    MessageBox.Show("Employee with ID " + txtEmployeeID.Text + " " + " has been added Successfully!", 
                        "Insertion Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearControls();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("The following error occurred : " + ex.Message, "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlCon.Close();
                }
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (isControlValid())
            {
                CheckedItems();
                string connectionString = @"Data Source=DESKTOP-KGQRUI1;Initial Catalog=PayrollSystemDB;Integrated Security=True";
                SqlConnection sqlCon = new SqlConnection(connectionString);

                try
                {
                    sqlCon.Open();

                    string updateCommand = "UPDATE tblEmployee SET FirstName = '"+ this.txtFirstname.Text + "', LastName = '" 
                        + this.txtLastName.Text + "', Gender = '" + this.Gender + "', NINumber = '" + this.txtNatInsurance.Text + "',DateOfBirth ='" + 
                        this.dtDateOfBirth.Value.ToString("MM/dd/yyyy") + "', MaritalStatus='" + this.MaritalStatus + "', IsMember='" + this.isMember + 
                        "', Address='" + this.txtAddress.Text + "', City = '" + this.txtCity.Text + "', PostCode= '" + this.txtPostCode.Text + 
                        "', Country = '" + this.cmbCountry.SelectedItem.ToString() + "', PhoneNumber = '" + this.txtPhoneNumber.Text + "', Email= '" +
                        this.txtEmailAddress.Text + "', Notes='" + this.txtNotes.Text + "' WHERE EmployeeID = " + txtEmployeeID.Text + "";

                    SqlCommand objCommand = new SqlCommand(updateCommand, sqlCon);
                    objCommand.ExecuteNonQuery();

                    LoadData();

                    MessageBox.Show("Employee with ID " + txtEmployeeID.Text + " " + " has been Update Successfully!",
                        "Update Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearControls();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The following error occurred : " + ex.Message, "Update Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlCon.Close();
                }
            }
        }

        private void btnResetEmployee_Click(object sender, EventArgs e)
        {
            ClearControls();
        }


        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            DialogResult objDialogResult = MessageBox.Show("Are you sure you want to permanently delete this Employee's record? ", "Confirm Record Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (objDialogResult == DialogResult.Yes)
            {
                CheckedItems();
                string connectionString = @"Data Source=DESKTOP-KGQRUI1;Initial Catalog=PayrollSystemDB;Integrated Security=True";
                SqlConnection sqlCon = new SqlConnection(connectionString);

                try
                {
                    sqlCon.Open();

                    string deleteCommand = "DELETE from tblEmployee WHERE EmployeeID = " + txtEmployeeID.Text + ""; 

                    SqlCommand objCommand = new SqlCommand(deleteCommand, sqlCon);
                    objCommand.ExecuteNonQuery();

                    LoadData();

                    MessageBox.Show("Employee with ID " + txtEmployeeID.Text + " " + " has been Deleted Successfully!",
                        "Delete Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearControls();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The following error occurred : " + ex.Message, "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlCon.Close();
                }

            }
        }

        private void employeesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmployeeID.Text = employeesGrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtFirstname.Text = employeesGrid.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtLastName.Text = employeesGrid.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            Gender = employeesGrid.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            txtNatInsurance.Text = employeesGrid.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            dtDateOfBirth.Text = employeesGrid.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            MaritalStatus = employeesGrid.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
            isMember = Convert.ToBoolean(employeesGrid.Rows[e.RowIndex].Cells[7].FormattedValue.ToString());
            txtAddress.Text = employeesGrid.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
            txtCity.Text = employeesGrid.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
            txtPostCode.Text = employeesGrid.Rows[e.RowIndex].Cells[10].FormattedValue.ToString();
            cmbCountry.Text = employeesGrid.Rows[e.RowIndex].Cells[11].FormattedValue.ToString();
            txtPhoneNumber.Text = employeesGrid.Rows[e.RowIndex].Cells[12].FormattedValue.ToString();
            txtEmailAddress.Text = employeesGrid.Rows[e.RowIndex].Cells[13].FormattedValue.ToString();
            txtNotes.Text = employeesGrid.Rows[e.RowIndex].Cells[14].FormattedValue.ToString();

            //Gender
            if(Gender == "Male")
            {
                rdMale.Checked = true;
                rdFemale.Checked = false;
            }
            else
            {
                rdMale.Checked = false;
                rdFemale.Checked = true;
            }

            //Marital Status
            if(MaritalStatus == "Married")
            {
                rdMarried.Checked = true;
                rdSingle.Checked = false;
            }
            else
            {
                rdMarried.Checked = false;
                rdSingle.Checked = true;
            }

            //Union Member
            if(isMember == true)
            {
                chkIsMember.Checked = true;
            }
            else
            {
                chkIsMember.Checked = false;
            }
        }
        #endregion

        #region PREVIEW
        string Gender, MaritalStatus;
        bool isMember;

        private void CheckedItems()
        {
            //Check Gender
            if (rdMale.Checked)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }

            //Check Marital Status
            if (rdMarried.Checked)
            {
                MaritalStatus = "Married";
            }
            else
            {
                MaritalStatus = "Single";
            }

            //Check UnionMember
            if (chkIsMember.Checked)
            {
                isMember = true;
            }
            else
            {
                isMember = false;
            }
        }

        private void btnPreviewEmployee_Click(object sender, EventArgs e)
        {
            PreviewEmployeeForm previewObj = new PreviewEmployeeForm();
            
            CheckedItems();
            previewObj.PreviewEmployeeData(Convert.ToInt32(txtEmployeeID.Text), txtFirstname.Text, txtLastName.Text, Gender,
                txtNatInsurance.Text, dtDateOfBirth.Text, MaritalStatus, isMember, txtAddress.Text, txtCity.Text, txtPostCode.Text,
                cmbCountry.SelectedItem.ToString(), txtPhoneNumber.Text, txtEmailAddress.Text, txtNotes.Text);

            previewObj.ShowDialog();
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

        #region DATA
        public void LoadData()
        {
            string connectionString = @"Data Source=DESKTOP-KGQRUI1;Initial Catalog=PayrollSystemDB;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from tblEmployee", connectionString);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            employeesGrid.DataSource = dataSet.Tables[0].DefaultView;

            sqlCon.Close();

        }
        #endregion



    }
}
