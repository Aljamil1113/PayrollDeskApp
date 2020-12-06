namespace PayrollApp
{
    partial class EmployeeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.chkIsMember = new System.Windows.Forms.CheckBox();
            this.lblUnionMembership = new System.Windows.Forms.Label();
            this.grpMaritalStatus = new System.Windows.Forms.GroupBox();
            this.rdMarried = new System.Windows.Forms.RadioButton();
            this.rdSingle = new System.Windows.Forms.RadioButton();
            this.dtDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtNatInsurance = new System.Windows.Forms.TextBox();
            this.lblNatInsurance = new System.Windows.Forms.Label();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.grpEmployeeContact = new System.Windows.Forms.GroupBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnResetEmployee = new System.Windows.Forms.Button();
            this.btnPreviewEmployee = new System.Windows.Forms.Button();
            this.btnExitEmployee = new System.Windows.Forms.Button();
            this.grpEmployee.SuspendLayout();
            this.grpMaritalStatus.SuspendLayout();
            this.grpGender.SuspendLayout();
            this.grpEmployeeContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEmployee
            // 
            this.grpEmployee.Controls.Add(this.chkIsMember);
            this.grpEmployee.Controls.Add(this.lblUnionMembership);
            this.grpEmployee.Controls.Add(this.grpMaritalStatus);
            this.grpEmployee.Controls.Add(this.dtDateOfBirth);
            this.grpEmployee.Controls.Add(this.lblDateOfBirth);
            this.grpEmployee.Controls.Add(this.txtNatInsurance);
            this.grpEmployee.Controls.Add(this.lblNatInsurance);
            this.grpEmployee.Controls.Add(this.grpGender);
            this.grpEmployee.Controls.Add(this.lblLastName);
            this.grpEmployee.Controls.Add(this.lblFirstName);
            this.grpEmployee.Controls.Add(this.lblEmployeeID);
            this.grpEmployee.Controls.Add(this.txtLastName);
            this.grpEmployee.Controls.Add(this.txtFirstname);
            this.grpEmployee.Controls.Add(this.txtEmployeeID);
            this.grpEmployee.Location = new System.Drawing.Point(37, 12);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.Size = new System.Drawing.Size(528, 460);
            this.grpEmployee.TabIndex = 0;
            this.grpEmployee.TabStop = false;
            this.grpEmployee.Text = "Employee Information";
            // 
            // chkIsMember
            // 
            this.chkIsMember.AutoSize = true;
            this.chkIsMember.Location = new System.Drawing.Point(304, 393);
            this.chkIsMember.Name = "chkIsMember";
            this.chkIsMember.Size = new System.Drawing.Size(101, 24);
            this.chkIsMember.TabIndex = 11;
            this.chkIsMember.Text = "Is Member";
            this.chkIsMember.UseVisualStyleBackColor = true;
            // 
            // lblUnionMembership
            // 
            this.lblUnionMembership.AutoSize = true;
            this.lblUnionMembership.Location = new System.Drawing.Point(55, 394);
            this.lblUnionMembership.Name = "lblUnionMembership";
            this.lblUnionMembership.Size = new System.Drawing.Size(135, 20);
            this.lblUnionMembership.TabIndex = 14;
            this.lblUnionMembership.Text = "Union Membership";
            // 
            // grpMaritalStatus
            // 
            this.grpMaritalStatus.Controls.Add(this.rdMarried);
            this.grpMaritalStatus.Controls.Add(this.rdSingle);
            this.grpMaritalStatus.Location = new System.Drawing.Point(55, 325);
            this.grpMaritalStatus.Name = "grpMaritalStatus";
            this.grpMaritalStatus.Size = new System.Drawing.Size(374, 53);
            this.grpMaritalStatus.TabIndex = 8;
            this.grpMaritalStatus.TabStop = false;
            this.grpMaritalStatus.Text = "Marital Status";
            // 
            // rdMarried
            // 
            this.rdMarried.AutoSize = true;
            this.rdMarried.Location = new System.Drawing.Point(198, 23);
            this.rdMarried.Name = "rdMarried";
            this.rdMarried.Size = new System.Drawing.Size(82, 24);
            this.rdMarried.TabIndex = 10;
            this.rdMarried.TabStop = true;
            this.rdMarried.Text = "Married";
            this.rdMarried.UseVisualStyleBackColor = true;
            // 
            // rdSingle
            // 
            this.rdSingle.AutoSize = true;
            this.rdSingle.Location = new System.Drawing.Point(48, 23);
            this.rdSingle.Name = "rdSingle";
            this.rdSingle.Size = new System.Drawing.Size(71, 24);
            this.rdSingle.TabIndex = 9;
            this.rdSingle.TabStop = true;
            this.rdSingle.Text = "Single";
            this.rdSingle.UseVisualStyleBackColor = true;
            // 
            // dtDateOfBirth
            // 
            this.dtDateOfBirth.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateOfBirth.Location = new System.Drawing.Point(304, 280);
            this.dtDateOfBirth.Name = "dtDateOfBirth";
            this.dtDateOfBirth.Size = new System.Drawing.Size(147, 27);
            this.dtDateOfBirth.TabIndex = 7;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(55, 285);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(97, 20);
            this.lblDateOfBirth.TabIndex = 11;
            this.lblDateOfBirth.Text = "Date of Birth:";
            // 
            // txtNatInsurance
            // 
            this.txtNatInsurance.Location = new System.Drawing.Point(304, 245);
            this.txtNatInsurance.Name = "txtNatInsurance";
            this.txtNatInsurance.Size = new System.Drawing.Size(125, 27);
            this.txtNatInsurance.TabIndex = 6;
            // 
            // lblNatInsurance
            // 
            this.lblNatInsurance.AutoSize = true;
            this.lblNatInsurance.Location = new System.Drawing.Point(55, 242);
            this.lblNatInsurance.Name = "lblNatInsurance";
            this.lblNatInsurance.Size = new System.Drawing.Size(162, 20);
            this.lblNatInsurance.TabIndex = 9;
            this.lblNatInsurance.Text = "National Insurance No.:";
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdMale);
            this.grpGender.Controls.Add(this.rdFemale);
            this.grpGender.Location = new System.Drawing.Point(55, 160);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(374, 79);
            this.grpGender.TabIndex = 3;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(48, 40);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(63, 24);
            this.rdMale.TabIndex = 4;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(198, 40);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(78, 24);
            this.rdFemale.TabIndex = 5;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(55, 130);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 20);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(55, 97);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 20);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(55, 61);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(97, 20);
            this.lblEmployeeID.TabIndex = 5;
            this.lblEmployeeID.Text = "Employee ID:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(304, 127);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(147, 27);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(304, 94);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(147, 27);
            this.txtFirstname.TabIndex = 1;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(304, 61);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(147, 27);
            this.txtEmployeeID.TabIndex = 0;
            this.txtEmployeeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeID_KeyPress);
            // 
            // grpEmployeeContact
            // 
            this.grpEmployeeContact.Controls.Add(this.cmbCountry);
            this.grpEmployeeContact.Controls.Add(this.lblCountry);
            this.grpEmployeeContact.Controls.Add(this.txtPhoneNumber);
            this.grpEmployeeContact.Controls.Add(this.lblNotes);
            this.grpEmployeeContact.Controls.Add(this.txtNotes);
            this.grpEmployeeContact.Controls.Add(this.lblPhoneNumber);
            this.grpEmployeeContact.Controls.Add(this.lblEmailAddress);
            this.grpEmployeeContact.Controls.Add(this.txtEmailAddress);
            this.grpEmployeeContact.Controls.Add(this.txtAddress);
            this.grpEmployeeContact.Controls.Add(this.lblPostCode);
            this.grpEmployeeContact.Controls.Add(this.txtPostCode);
            this.grpEmployeeContact.Controls.Add(this.lblAddress);
            this.grpEmployeeContact.Controls.Add(this.lblCity);
            this.grpEmployeeContact.Controls.Add(this.txtCity);
            this.grpEmployeeContact.Location = new System.Drawing.Point(612, 12);
            this.grpEmployeeContact.Name = "grpEmployeeContact";
            this.grpEmployeeContact.Size = new System.Drawing.Size(511, 460);
            this.grpEmployeeContact.TabIndex = 1;
            this.grpEmployeeContact.TabStop = false;
            this.grpEmployeeContact.Text = "Employee Contact Details";
            // 
            // cmbCountry
            // 
            this.cmbCountry.AllowDrop = true;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "Select a Country ...",
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "The Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo, Democratic Republic of the",
            "Congo, Republic of the",
            "Costa Rica",
            "Côte d’Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor (Timor-Leste)",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Eswatini",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "The Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea, North",
            "Korea, South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia, Federated States of",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar (Burma)",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Macedonia",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Sudan, South",
            "Suriname",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.cmbCountry.Location = new System.Drawing.Point(299, 184);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(196, 28);
            this.cmbCountry.TabIndex = 15;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(50, 184);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(63, 20);
            this.lblCountry.TabIndex = 8;
            this.lblCountry.Text = "Country:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(299, 245);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(196, 27);
            this.txtPhoneNumber.TabIndex = 16;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(50, 314);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(48, 20);
            this.lblNotes.TabIndex = 7;
            this.lblNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(299, 311);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(196, 49);
            this.txtNotes.TabIndex = 18;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(50, 245);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(111, 20);
            this.lblPhoneNumber.TabIndex = 5;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(50, 281);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(106, 20);
            this.lblEmailAddress.TabIndex = 6;
            this.lblEmailAddress.Text = "Email Address:";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(299, 278);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(196, 27);
            this.txtEmailAddress.TabIndex = 17;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(299, 61);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(196, 27);
            this.txtAddress.TabIndex = 12;
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(50, 130);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(78, 20);
            this.lblPostCode.TabIndex = 7;
            this.lblPostCode.Text = "Post Code:";
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(299, 127);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(196, 27);
            this.txtPostCode.TabIndex = 14;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(50, 61);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 20);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(50, 97);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(37, 20);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(299, 94);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(196, 27);
            this.txtCity.TabIndex = 13;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAddEmployee.Location = new System.Drawing.Point(37, 495);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(149, 40);
            this.btnAddEmployee.TabIndex = 2;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.BackColor = System.Drawing.Color.SpringGreen;
            this.btnUpdateEmployee.Location = new System.Drawing.Point(228, 495);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(144, 40);
            this.btnUpdateEmployee.TabIndex = 3;
            this.btnUpdateEmployee.Text = "Update Employee";
            this.btnUpdateEmployee.UseVisualStyleBackColor = false;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BackColor = System.Drawing.Color.SpringGreen;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(417, 495);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(148, 40);
            this.btnDeleteEmployee.TabIndex = 4;
            this.btnDeleteEmployee.Text = "Delete Employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            // 
            // btnResetEmployee
            // 
            this.btnResetEmployee.BackColor = System.Drawing.Color.SpringGreen;
            this.btnResetEmployee.Location = new System.Drawing.Point(612, 495);
            this.btnResetEmployee.Name = "btnResetEmployee";
            this.btnResetEmployee.Size = new System.Drawing.Size(128, 40);
            this.btnResetEmployee.TabIndex = 5;
            this.btnResetEmployee.Text = "Reset";
            this.btnResetEmployee.UseVisualStyleBackColor = false;
            this.btnResetEmployee.Click += new System.EventHandler(this.btnResetEmployee_Click);
            // 
            // btnPreviewEmployee
            // 
            this.btnPreviewEmployee.BackColor = System.Drawing.Color.SpringGreen;
            this.btnPreviewEmployee.Location = new System.Drawing.Point(797, 495);
            this.btnPreviewEmployee.Name = "btnPreviewEmployee";
            this.btnPreviewEmployee.Size = new System.Drawing.Size(132, 40);
            this.btnPreviewEmployee.TabIndex = 6;
            this.btnPreviewEmployee.Text = "Preview";
            this.btnPreviewEmployee.UseVisualStyleBackColor = false;
            // 
            // btnExitEmployee
            // 
            this.btnExitEmployee.BackColor = System.Drawing.Color.SpringGreen;
            this.btnExitEmployee.Location = new System.Drawing.Point(1000, 495);
            this.btnExitEmployee.Name = "btnExitEmployee";
            this.btnExitEmployee.Size = new System.Drawing.Size(123, 40);
            this.btnExitEmployee.TabIndex = 7;
            this.btnExitEmployee.Text = "Exit";
            this.btnExitEmployee.UseVisualStyleBackColor = false;
            this.btnExitEmployee.Click += new System.EventHandler(this.btnExitEmployee_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1170, 547);
            this.Controls.Add(this.btnExitEmployee);
            this.Controls.Add(this.btnPreviewEmployee);
            this.Controls.Add(this.btnResetEmployee);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnUpdateEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.grpEmployeeContact);
            this.Controls.Add(this.grpEmployee);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Employee";
            this.grpEmployee.ResumeLayout(false);
            this.grpEmployee.PerformLayout();
            this.grpMaritalStatus.ResumeLayout(false);
            this.grpMaritalStatus.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.grpEmployeeContact.ResumeLayout(false);
            this.grpEmployeeContact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmployee;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.GroupBox grpEmployeeContact;
        private System.Windows.Forms.CheckBox chkIsMember;
        private System.Windows.Forms.Label lblUnionMembership;
        private System.Windows.Forms.GroupBox grpMaritalStatus;
        private System.Windows.Forms.RadioButton rdMarried;
        private System.Windows.Forms.RadioButton rdSingle;
        private System.Windows.Forms.DateTimePicker dtDateOfBirth;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtNatInsurance;
        private System.Windows.Forms.Label lblNatInsurance;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnResetEmployee;
        private System.Windows.Forms.Button btnPreviewEmployee;
        private System.Windows.Forms.Button btnExitEmployee;
        private System.Windows.Forms.ComboBox cmbCountry;
    }
}

