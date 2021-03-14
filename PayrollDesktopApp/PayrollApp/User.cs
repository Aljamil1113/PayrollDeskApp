using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PayrollApp
{
    class User
    {
        private string userName;
        private string password;
        private string role;
        private string description;
        private string connectionString = @"Data Source=DESKTOP-KGQRUI1;Initial Catalog=PayrollSystemDB;Integrated Security=True"; 

        //Default Constructor
        public User(){}

        public User(string username, string password, string role, string description)
        {
            this.userName = username;
            this.password = password;
            this.role = role;
            this.description = description;
        }

        //PROPERTIES
        public string UserName 
        { 
            get { return userName; } 
            set { userName = value; } 
        }

        public string Password 
        {
            get { return password;  }
            set { password = value; } 
        }

        public string Role 
        {
            get { return role; }
            set { role = value; } 
        }

        public string Description 
        {
            get { return description; }
            set { description = value; } 
        }

        //METHODS

        public void AddUser() 
        {
            //Connection Object
            SqlConnection objSqlConnection = new SqlConnection(connectionString);

            //SqlCommand Object
            SqlCommand objSqlCommand = new SqlCommand("spInsertUser", objSqlConnection);
            objSqlCommand.CommandType = CommandType.StoredProcedure;
            objSqlCommand.Parameters.AddWithValue("@UserName", UserName);
            objSqlCommand.Parameters.AddWithValue("@Password", Password);
            objSqlCommand.Parameters.AddWithValue("@Roles", Role);
            objSqlCommand.Parameters.AddWithValue("@Description", Description);

            try
            {
                objSqlConnection.Open();
                objSqlCommand.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error:" + e.Message, "SQL Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                objSqlConnection.Close();
            }
            MessageBox.Show("New User Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void UpdateUser() 
        {
            //Connection Object
            SqlConnection objSqlConnection = new SqlConnection(connectionString);

            //SqlCommand Object
            SqlCommand objSqlCommand = new SqlCommand("spUpdateUser", objSqlConnection);
            objSqlCommand.CommandType = CommandType.StoredProcedure;
            objSqlCommand.Parameters.AddWithValue("@UserName", UserName);
            objSqlCommand.Parameters.AddWithValue("@Password", Password);
            objSqlCommand.Parameters.AddWithValue("@Roles", Role);
            objSqlCommand.Parameters.AddWithValue("@Description", Description);

            try
            {
                objSqlConnection.Open();
                objSqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e.Message, "SQL Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                objSqlConnection.Close();
            }
            MessageBox.Show("User Update Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DeleteUser() 
        {
            //Connection Object
            SqlConnection objSqlConnection = new SqlConnection(connectionString);

            //SqlCommand Object
            SqlCommand objSqlCommand = new SqlCommand("spDeleteUser", objSqlConnection);
            objSqlCommand.CommandType = CommandType.StoredProcedure;
            objSqlCommand.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                objSqlConnection.Open();
                objSqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e.Message, "SQLDelete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                objSqlConnection.Close();
            }
            MessageBox.Show("User Delete Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool AuthorizedUser()
        {
            bool isUserAuthorized = false;
            SqlConnection objSqlConnection = new SqlConnection(connectionString);

            //SqlCommand Object
            SqlCommand objSqlCommand = new SqlCommand("spIsUserDetailsValid", objSqlConnection);
            objSqlCommand.CommandType = CommandType.StoredProcedure;
            objSqlCommand.Parameters.AddWithValue("@UserName", UserName);
            objSqlCommand.Parameters.AddWithValue("@Password", Password);
            objSqlCommand.Parameters.AddWithValue("@Roles", Role);

            try
            {
                objSqlConnection.Open();
                isUserAuthorized = (bool)objSqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "User Authentication Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }

            return isUserAuthorized; 
        }
    }
}
