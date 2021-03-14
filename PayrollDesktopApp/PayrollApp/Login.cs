using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PayrollApp
{
    public partial class Login : Form
    {
        private string connectionString = @"Data Source=DESKTOP-KGQRUI1;Initial Catalog=PayrollSystemDB;Integrated Security=True";

        private User objRegisterUser;
        public Login()
        {
            InitializeComponent();
        }

        private void GetRoles()
        {
            //Connection Object
            SqlConnection objSqlConnection = new SqlConnection(connectionString);

            //SqlCommand Object
            SqlCommand objSqlCommand = new SqlCommand("spAllUsers", objSqlConnection);
            objSqlCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                objSqlConnection.Open();

                SqlDataReader objDataReader = objSqlCommand.ExecuteReader();

                while(objDataReader.Read())
                {
                    cmbIsRoles.Items.Add(objDataReader[3]);
                }
                objDataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e.Message);
                return;
            }
            finally
            {
                objSqlConnection.Close();
            }
        }

        private void UserData()
        {
            objRegisterUser.UserName = txtUserName.Text;
            objRegisterUser.Password = txtPassword.Text;
            objRegisterUser.Role = cmbIsRoles.Text;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            GetRoles();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            objRegisterUser = new User();
            UserData();

            try
            {
                if (objRegisterUser.AuthorizedUser())
                {
                    PayrollMDI objPayrollMDI = new PayrollMDI();
                    this.Hide();
                    objPayrollMDI.Show();
                }
                else
                {
                    MessageBox.Show("Unauthorized credential provided!!!", "Unathorized User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
           
        }
    }
}
