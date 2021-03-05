using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace PayrollApp
{
    public partial class PayrollCalculator : Form
    {
        private string fullName = String.Empty;
        public PayrollCalculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ListOfMonths()
        {
            string[] months = { "Select a month...." ,"January" ,"February" ,"March" ,"April" ,"May" ,"June"
                              ,"July" ,"August" ,"September" ,"October" ,"November" ,"December" };

            foreach (var month in months)
            {
                cmbCurrentMonth.Items.Add(month);
                cmbCurrentMonth.SelectedIndex = 0;
            }

            foreach (var month in months)
            {
                cmbSearchPayMonth.Items.Add(month);
                cmbSearchPayMonth.SelectedIndex = 0;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-KGQRUI1;Initial Catalog=PayrollSystemDB;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            string selectCommand = "SELECT FirstName, LastName, NINumber FROM tblEmployee Where EmployeeID = '" + txtEmployeeID.Text + "'";
            SqlCommand objSqlCommand = new SqlCommand(selectCommand, sqlCon);

            try
            {
                SqlDataReader dataReader = objSqlCommand.ExecuteReader();
                if(dataReader.Read())
                {
                    txtFirstName.Text = dataReader[0].ToString();
                    txtLastName.Text = dataReader[1].ToString();
                    txtNINumber.Text = dataReader[2].ToString();
                    lblEmployeeFullName.Text = txtLastName.Text + ", " + txtFirstName.Text;
                }
                else
                {
                    MessageBox.Show("No Records where found with " + txtEmployeeID.Text, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dataReader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error Message");
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void PayrollCalculator_Load(object sender, EventArgs e)
        {
            ListOfMonths();
        }
    }
}
