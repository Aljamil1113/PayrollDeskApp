using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PayrollApp
{
    public partial class PreviewEmployeeForm : Form
    {
        public PreviewEmployeeForm()
        {
            InitializeComponent();
        }

        public void PreviewEmployeeData(int EmployeeID, string FirstName, string LastName, string Gender,
                                        string NationalInsurance, string DateOfBirth, string MaritalStatus,
                                        bool IsMember, string Address, string City, string PostCode, string Country,
                                        string PhoneNumber, string Email, string Notes)
        {
            _lblEmployeeID.Text = Convert.ToString(EmployeeID);
            _lblFirstName.Text = FirstName;
            _lblLastName.Text = LastName;
            _lblGender.Text = Gender;
            _lblNatInsurance.Text = NationalInsurance;
            _lblDateOfBirth.Text = DateOfBirth;
            _lblMaritalStatus.Text = MaritalStatus;
            _lblUnionMembership.Text = IsMember.ToString();
            _lblAddress.Text = Address;
            _lblCity.Text = City;
            _lblPostCode.Text = PostCode;
            _lblCountry.Text = Country;
            _lblPhoneNumber.Text = PhoneNumber;
            _lblEmailAddress.Text = Email;
            _lblNotes.Text = Notes;
        }
    }
}
