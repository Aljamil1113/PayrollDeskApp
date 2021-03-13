
namespace PayrollApp
{
    partial class RegisterUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbRegisterUser = new System.Windows.Forms.GroupBox();
            this.grpRegisterUserButtons = new System.Windows.Forms.GroupBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnResetUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnRegisterUser = new System.Windows.Forms.Button();
            this.grpOutputRegisterUser = new System.Windows.Forms.GroupBox();
            this.grbInputRegisterUser = new System.Windows.Forms.GroupBox();
            this.txtRegisterUsername = new System.Windows.Forms.TextBox();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.txtRegisterRole = new System.Windows.Forms.TextBox();
            this.txtRegisterRoleDescription = new System.Windows.Forms.TextBox();
            this.lblRegisterUsername = new System.Windows.Forms.Label();
            this.lblRegisterPassword = new System.Windows.Forms.Label();
            this.lblRegisterRole = new System.Windows.Forms.Label();
            this.lblRegisterRoleDescription = new System.Windows.Forms.Label();
            this.lblRegisterConfirmPassword = new System.Windows.Forms.Label();
            this.txtRegisterConfirmPassword = new System.Windows.Forms.TextBox();
            this.grbRegisterUser.SuspendLayout();
            this.grpRegisterUserButtons.SuspendLayout();
            this.grbInputRegisterUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbRegisterUser
            // 
            this.grbRegisterUser.Controls.Add(this.grpRegisterUserButtons);
            this.grbRegisterUser.Controls.Add(this.grpOutputRegisterUser);
            this.grbRegisterUser.Controls.Add(this.grbInputRegisterUser);
            this.grbRegisterUser.Location = new System.Drawing.Point(13, 13);
            this.grbRegisterUser.Name = "grbRegisterUser";
            this.grbRegisterUser.Size = new System.Drawing.Size(1018, 499);
            this.grbRegisterUser.TabIndex = 0;
            this.grbRegisterUser.TabStop = false;
            // 
            // grpRegisterUserButtons
            // 
            this.grpRegisterUserButtons.Controls.Add(this.btnDeleteUser);
            this.grpRegisterUserButtons.Controls.Add(this.btnResetUser);
            this.grpRegisterUserButtons.Controls.Add(this.btnUpdateUser);
            this.grpRegisterUserButtons.Controls.Add(this.btnRegisterUser);
            this.grpRegisterUserButtons.Location = new System.Drawing.Point(24, 415);
            this.grpRegisterUserButtons.Name = "grpRegisterUserButtons";
            this.grpRegisterUserButtons.Size = new System.Drawing.Size(975, 78);
            this.grpRegisterUserButtons.TabIndex = 2;
            this.grpRegisterUserButtons.TabStop = false;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.Black;
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(743, 26);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(217, 29);
            this.btnDeleteUser.TabIndex = 3;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnResetUser
            // 
            this.btnResetUser.BackColor = System.Drawing.Color.Black;
            this.btnResetUser.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResetUser.ForeColor = System.Drawing.Color.White;
            this.btnResetUser.Location = new System.Drawing.Point(499, 26);
            this.btnResetUser.Name = "btnResetUser";
            this.btnResetUser.Size = new System.Drawing.Size(217, 29);
            this.btnResetUser.TabIndex = 2;
            this.btnResetUser.Text = "Reset";
            this.btnResetUser.UseVisualStyleBackColor = false;
            this.btnResetUser.Click += new System.EventHandler(this.btnResetUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.Black;
            this.btnUpdateUser.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.Location = new System.Drawing.Point(252, 26);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(217, 29);
            this.btnUpdateUser.TabIndex = 1;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.BackColor = System.Drawing.Color.Black;
            this.btnRegisterUser.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegisterUser.ForeColor = System.Drawing.Color.White;
            this.btnRegisterUser.Location = new System.Drawing.Point(20, 27);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(204, 29);
            this.btnRegisterUser.TabIndex = 0;
            this.btnRegisterUser.Text = "Register User";
            this.btnRegisterUser.UseVisualStyleBackColor = false;
            this.btnRegisterUser.Click += new System.EventHandler(this.btnRegisterUser_Click);
            // 
            // grpOutputRegisterUser
            // 
            this.grpOutputRegisterUser.Location = new System.Drawing.Point(435, 37);
            this.grpOutputRegisterUser.Name = "grpOutputRegisterUser";
            this.grpOutputRegisterUser.Size = new System.Drawing.Size(564, 372);
            this.grpOutputRegisterUser.TabIndex = 1;
            this.grpOutputRegisterUser.TabStop = false;
            this.grpOutputRegisterUser.Text = "Register Users";
            // 
            // grbInputRegisterUser
            // 
            this.grbInputRegisterUser.Controls.Add(this.lblRegisterConfirmPassword);
            this.grbInputRegisterUser.Controls.Add(this.txtRegisterConfirmPassword);
            this.grbInputRegisterUser.Controls.Add(this.lblRegisterRoleDescription);
            this.grbInputRegisterUser.Controls.Add(this.lblRegisterRole);
            this.grbInputRegisterUser.Controls.Add(this.lblRegisterPassword);
            this.grbInputRegisterUser.Controls.Add(this.lblRegisterUsername);
            this.grbInputRegisterUser.Controls.Add(this.txtRegisterRoleDescription);
            this.grbInputRegisterUser.Controls.Add(this.txtRegisterRole);
            this.grbInputRegisterUser.Controls.Add(this.txtRegisterPassword);
            this.grbInputRegisterUser.Controls.Add(this.txtRegisterUsername);
            this.grbInputRegisterUser.Location = new System.Drawing.Point(6, 27);
            this.grbInputRegisterUser.Name = "grbInputRegisterUser";
            this.grbInputRegisterUser.Size = new System.Drawing.Size(403, 382);
            this.grbInputRegisterUser.TabIndex = 0;
            this.grbInputRegisterUser.TabStop = false;
            this.grbInputRegisterUser.Text = "Register User";
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.Location = new System.Drawing.Point(175, 57);
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.Size = new System.Drawing.Size(211, 27);
            this.txtRegisterUsername.TabIndex = 0;
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Location = new System.Drawing.Point(175, 116);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Size = new System.Drawing.Size(211, 27);
            this.txtRegisterPassword.TabIndex = 1;
            // 
            // txtRegisterRole
            // 
            this.txtRegisterRole.Location = new System.Drawing.Point(175, 204);
            this.txtRegisterRole.Name = "txtRegisterRole";
            this.txtRegisterRole.Size = new System.Drawing.Size(211, 27);
            this.txtRegisterRole.TabIndex = 2;
            // 
            // txtRegisterRoleDescription
            // 
            this.txtRegisterRoleDescription.Location = new System.Drawing.Point(175, 260);
            this.txtRegisterRoleDescription.Multiline = true;
            this.txtRegisterRoleDescription.Name = "txtRegisterRoleDescription";
            this.txtRegisterRoleDescription.Size = new System.Drawing.Size(211, 96);
            this.txtRegisterRoleDescription.TabIndex = 3;
            // 
            // lblRegisterUsername
            // 
            this.lblRegisterUsername.AutoSize = true;
            this.lblRegisterUsername.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterUsername.Location = new System.Drawing.Point(10, 58);
            this.lblRegisterUsername.Name = "lblRegisterUsername";
            this.lblRegisterUsername.Size = new System.Drawing.Size(94, 23);
            this.lblRegisterUsername.TabIndex = 4;
            this.lblRegisterUsername.Text = "Username:";
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.AutoSize = true;
            this.lblRegisterPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterPassword.Location = new System.Drawing.Point(10, 116);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(90, 23);
            this.lblRegisterPassword.TabIndex = 5;
            this.lblRegisterPassword.Text = "Password:";
            // 
            // lblRegisterRole
            // 
            this.lblRegisterRole.AutoSize = true;
            this.lblRegisterRole.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterRole.Location = new System.Drawing.Point(10, 204);
            this.lblRegisterRole.Name = "lblRegisterRole";
            this.lblRegisterRole.Size = new System.Drawing.Size(50, 23);
            this.lblRegisterRole.TabIndex = 6;
            this.lblRegisterRole.Text = "Role:";
            // 
            // lblRegisterRoleDescription
            // 
            this.lblRegisterRoleDescription.AutoSize = true;
            this.lblRegisterRoleDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterRoleDescription.Location = new System.Drawing.Point(10, 260);
            this.lblRegisterRoleDescription.Name = "lblRegisterRoleDescription";
            this.lblRegisterRoleDescription.Size = new System.Drawing.Size(147, 23);
            this.lblRegisterRoleDescription.TabIndex = 7;
            this.lblRegisterRoleDescription.Text = "Role Description:";
            // 
            // lblRegisterConfirmPassword
            // 
            this.lblRegisterConfirmPassword.AutoSize = true;
            this.lblRegisterConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterConfirmPassword.Location = new System.Drawing.Point(10, 159);
            this.lblRegisterConfirmPassword.Name = "lblRegisterConfirmPassword";
            this.lblRegisterConfirmPassword.Size = new System.Drawing.Size(161, 23);
            this.lblRegisterConfirmPassword.TabIndex = 9;
            this.lblRegisterConfirmPassword.Text = "Confirm Password:";
            // 
            // txtRegisterConfirmPassword
            // 
            this.txtRegisterConfirmPassword.Location = new System.Drawing.Point(175, 159);
            this.txtRegisterConfirmPassword.Name = "txtRegisterConfirmPassword";
            this.txtRegisterConfirmPassword.Size = new System.Drawing.Size(211, 27);
            this.txtRegisterConfirmPassword.TabIndex = 8;
            // 
            // RegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1043, 524);
            this.Controls.Add(this.grbRegisterUser);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "RegisterUser";
            this.Text = "RegisterUser";
            this.grbRegisterUser.ResumeLayout(false);
            this.grpRegisterUserButtons.ResumeLayout(false);
            this.grbInputRegisterUser.ResumeLayout(false);
            this.grbInputRegisterUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbRegisterUser;
        private System.Windows.Forms.GroupBox grpOutputRegisterUser;
        private System.Windows.Forms.GroupBox grbInputRegisterUser;
        private System.Windows.Forms.GroupBox grpRegisterUserButtons;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnResetUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnRegisterUser;
        private System.Windows.Forms.Label lblRegisterRoleDescription;
        private System.Windows.Forms.Label lblRegisterRole;
        private System.Windows.Forms.Label lblRegisterPassword;
        private System.Windows.Forms.Label lblRegisterUsername;
        private System.Windows.Forms.TextBox txtRegisterRoleDescription;
        private System.Windows.Forms.TextBox txtRegisterRole;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.TextBox txtRegisterUsername;
        private System.Windows.Forms.Label lblRegisterConfirmPassword;
        private System.Windows.Forms.TextBox txtRegisterConfirmPassword;
    }
}