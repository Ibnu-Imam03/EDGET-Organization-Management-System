using EDGET.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDGET.Presentation
{
    public partial class FrmAddEditPerson : Form
    {
        private enum enMode { New = 0 , Update = 1 }
        private enMode _Mode = enMode.New;
        ClsPersonBusiness Person;

        private int _PersonID = -1; 
        public FrmAddEditPerson()
        {
            InitializeComponent();
            _Mode = enMode.New;
            SetFormMode();
            Person = new ClsPersonBusiness();



        }
        public FrmAddEditPerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _Mode = enMode.Update;
            SetFormMode();

        }
        private void SetFormMode()
        {
            if (_Mode == enMode.New)
            {
                lblTitle.Text = "Add New Person";
                Text = "Add New Person";
            }
            else
            {
                lblTitle.Text = "Update Person";
                Text = "Update Person";
            }
        }
        private void UploadPersonInfo()
        {
             Person = ClsPersonBusiness.IsPersonExist(_PersonID);

            if (Person == null)
                return;

            txtFullName.Text = Person.FullName;
            cmbSex.SelectedItem = Person.Gender;
            txtTelegramUsername.Text = Person.TelegramUserName;
        }
        private void FrmAddEditPerson_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                UploadPersonInfo();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Person.FullName = txtFullName.Text.Trim();
            Person.Gender = cmbSex.SelectedIndex == 0 ? "Male" : "Female";
            Person.TelegramUserName = txtTelegramUsername.Text.Trim();

            if (_Mode == enMode.Update)
                Person.PersonID = _PersonID;

            if (Person.Save())
            {
                string message = _Mode == enMode.New ? "Person added successfully." : "Person updated successfully.";
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                string message = _Mode == enMode.New ? "Failed to add person." : "Failed to update person.";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtFullName_Validating(object sender, CancelEventArgs e)
        {
            // Required field
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFullName, "Full name is required.");
                return;
            }

            // Minimum length
            if (txtFullName.Text.Trim().Length < 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFullName, "Full name must contain at least 3 characters.");
                return;
            }

            // Maximum length
            if (txtFullName.Text.Trim().Length > 100)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFullName, "Full name cannot exceed 100 characters.");
                return;
            }

            // Valid input
            e.Cancel = false;
            errorProvider1.SetError(txtFullName, "");
        }

        private void cmbSex_Validating(object sender, CancelEventArgs e)
        {
            if (cmbSex.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(cmbSex, "Please select a sex.");
                return;
            }

            // Clear the error if the selection is valid
            e.Cancel = false;
            errorProvider1.SetError(cmbSex, "");
        }

        private void txtTelegramUsername_Validating(object sender, CancelEventArgs e)
        {
            string username = txtTelegramUsername.Text.Trim();

            // Check if empty
            if (string.IsNullOrWhiteSpace(username))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTelegramUsername, "Telegram username is required.");
                return;
            }

            // Check if it starts with @
            if (!username.StartsWith("@"))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTelegramUsername, "Username must start with @.");
                return;
            }

            // Check username length (excluding @)
            string usernameWithoutAt = username.Substring(1);

            if (usernameWithoutAt.Length < 5 || usernameWithoutAt.Length > 32)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTelegramUsername, "Username must contain 5–32 characters after @.");
                return;
            }

            // Check allowed characters
            foreach (char c in usernameWithoutAt)
            {
                if (!char.IsLetterOrDigit(c) && c != '_')
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtTelegramUsername, "Only letters, numbers, and underscores are allowed.");
                    return;
                }
            }

            // Input is valid
            e.Cancel = false;
            errorProvider1.SetError(txtTelegramUsername, "");
        }




    }
}
