
using EDGET.Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EDGET.Presentation
{
    public partial class FrmAddEditPerson : Form
    {
        private enum enMode { New = 0, Update = 1 }
        private enMode _Mode = enMode.New;
        private ClsPersonBusiness Person;
        private int _PersonID = -1;

        public int SavedPersonID { get; private set; }

        public Action<int> OnPersonSaved;

        public FrmAddEditPerson()
        {
            InitializeComponent();
            _Mode = enMode.New;
            Person = new ClsPersonBusiness();
        }

        public FrmAddEditPerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            Person = ClsPersonBusiness.GetPersonByID(_PersonID);
            _Mode = enMode.Update;
        }

        private void FrmAddEditPerson_Load(object sender, EventArgs e)
        {
            SetFormMode();

            if (_Mode == enMode.Update)
                UploadPersonInfo();
        }

        private void SetFormMode()
        {
            if (_Mode == enMode.New)
            {
                lblTitle.Text = "Add New Person";
                Text = "Add New Person";
                cmbSex.SelectedIndex = 0;
            }
            else
            {
                lblTitle.Text = "Update Person";
                Text = "Update Person";
            }
        }

        private void UploadPersonInfo()
        {
            if (Person == null)
            {
                MessageBox.Show("Person not found.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            txtFullName.Text = Person.FullName;
            cmbSex.SelectedItem = Person.Gender;
            txtTelegramUsername.Text = Person.TelegramUserName;

            TxtNumber.Text = Person.Phone1;
            TxtNumber2.Text = Person.Phone2;
            TxtNumber3.Text = Person.Phone3;
            TxtNumber4.Text = Person.Phone4;
        }

        private bool ValidatePhoneNumbers()
        {
            string[] numbers =
            {
                TxtNumber.Text.Trim(),
                TxtNumber2.Text.Trim(),
                TxtNumber3.Text.Trim(),
                TxtNumber4.Text.Trim()
            };

            foreach (string number in numbers)
            {
                if (string.IsNullOrWhiteSpace(number))
                    continue;

                if (!Regex.IsMatch(number, @"^(09|07)\d{8}$"))
                {
                    MessageBox.Show(
                        "Please enter a valid 10-digit Ethiopian phone number.",
                        "Invalid Phone Number",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return false;
                }
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Please correct the errors before saving.","Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidatePhoneNumbers())
                return;

            if (Person == null)
                return;

            Person.FullName = txtFullName.Text.Trim();
            Person.Gender = cmbSex.SelectedIndex == 0 ? "Male" : "Female";
            Person.TelegramUserName = txtTelegramUsername.Text.Trim();

            Person.Phone1 = TxtNumber.Text.Trim();
            Person.Phone2 = TxtNumber2.Text.Trim();
            Person.Phone3 = TxtNumber3.Text.Trim();
            Person.Phone4 = TxtNumber4.Text.Trim();

            if (Person.Save())
            {
                OnPersonSaved?.Invoke(Person.PersonID);

                SavedPersonID = Person.PersonID;

                string message = _Mode == enMode.New? "Person added successfully.": "Person updated successfully.";

                MessageBox.Show(message, "Success",MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                string message = _Mode == enMode.New? "Failed to add person.": "Failed to update person.";

                MessageBox.Show(message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFullName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFullName, "Full name is required.");
                return;
            }

            if (txtFullName.Text.Trim().Length < 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFullName, "Full name must contain at least 3 characters.");
                return;
            }

            if (txtFullName.Text.Trim().Length > 100)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFullName, "Full name cannot exceed 100 characters.");
                return;
            }

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

            e.Cancel = false;
            errorProvider1.SetError(cmbSex, "");
        }

        private void txtTelegramUsername_Validating(object sender, CancelEventArgs e)
        {
            string username = txtTelegramUsername.Text.Trim();

            if (string.IsNullOrWhiteSpace(username))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTelegramUsername, "Telegram username is required.");
                return;
            }

            if (!username.StartsWith("@"))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTelegramUsername, "Username must start with @.");
                return;
            }

            string usernameWithoutAt = username.Substring(1);

            if (usernameWithoutAt.Length < 5 || usernameWithoutAt.Length > 32)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTelegramUsername, "Username must contain 5–32 characters after @.");
                return;
            }

            foreach (char c in usernameWithoutAt)
            {
                if (!char.IsLetterOrDigit(c) && c != '_')
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtTelegramUsername,
                        "Only letters, numbers, and underscores are allowed.");
                    return;
                }
            }

            e.Cancel = false;
            errorProvider1.SetError(txtTelegramUsername, "");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
