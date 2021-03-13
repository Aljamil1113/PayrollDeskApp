using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollApp
{
    class User
    {
        private string userName;
        private string password;
        private string role;
        private string description;

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

        public void AddUser() { }

        public void UpdateUser() { }

        public void DeleteUser() { }

        public bool AuthorizedUser()
        { return true; }
    }
}
