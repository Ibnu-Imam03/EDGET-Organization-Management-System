
using System;
using System.Windows.Forms;
using EDGET.Business;

namespace EDGET.Presentation
{
    public partial class FrmAddEditMember : Form
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;

        private int _MemberID = -1;
        private ClsMemberBusiness _Member;
        private ClsPersonBusiness _Person;

        // Constructor: Add New Member
        public FrmAddEditMember()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        // Constructor: Update Member
        public FrmAddEditMember(int memberID)
        {
            InitializeComponent();

            _MemberID = memberID;
            _Mode = enMode.Update;
        }

        private void FrmAddEditMember_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                _Member = new ClsMemberBusiness();

                lblTitle.Text = "Add New Member";
                txtPersonID.Clear();

                return;
            }

            _Member = ClsMemberBusiness.GetMemberByID(_MemberID);

            if (_Member == null)
            {
                MessageBox.Show("Member not found!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Close();
                return;
            }

            LoadMemberData();
        }

       

        // Load existing member information
        private void LoadMemberData()
        {
            lblTitle.Text = "Update Member";

            txtPersonID.Text = _Member.PersonID.ToString();
            txtStudentID.Text = _Member.StudentID;
            txtDepartment.Text = _Member.Department;

            dtpJoinDate.Value = _Member.JoinDate;
            nbYearOfStudy.Value = _Member.YearOfStudy;
            chkStatus.Checked = _Member.Status;

            // Load associated person
            ///?//_Person = ClsPersonBusiness.GetPersonByID(_Member.PersonID);
        }

        // Validate form inputs
        private bool ValidateInputs()
        {
            if (!int.TryParse(txtPersonID.Text.Trim(), out int personID))
            {
                MessageBox.Show("Please enter a valid Person ID.");
                txtPersonID.Focus();
                return false;
            }

            // Verify that the person exists
            _Person = ClsPersonBusiness.GetPersonByID(personID);

            if (_Person == null)
            {
                MessageBox.Show("Person does not exist. Please find a valid person.");
                txtPersonID.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show("Please enter Student ID.");
                txtStudentID.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDepartment.Text))
            {
                MessageBox.Show("Please enter Department.");
                txtDepartment.Focus();
                return false;
            }

            return true;
        }

       

        // Close Form
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            int personID;

            if (!int.TryParse(txtPersonID.Text.Trim(), out personID))
            {
                MessageBox.Show("Please enter a valid Person ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtPersonID.Focus();
                return;
            }

            _Person = ClsPersonBusiness.GetPersonByID(personID);

            if (_Person == null)
            {
                MessageBox.Show("Person not found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtPersonID.Focus();
                return;
            }

            MessageBox.Show("Person Found Successfully!\n\n" + "Person ID: " + _Person.PersonID + "\n" + "Full Name: " + _Person.FullName + "\n" + "Gender: "
                + _Person.Gender, "Person Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddNew_Click_1(object sender, EventArgs e)
        {
            using (FrmAddEditPerson frm = new FrmAddEditPerson())
            {
                frm.ShowDialog();
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            _Member.PersonID = _Person.PersonID;
            _Member.StudentID = txtStudentID.Text.Trim();
            _Member.Department = txtDepartment.Text.Trim();
            _Member.YearOfStudy = Convert.ToInt32(nbYearOfStudy.Value);
            _Member.JoinDate = dtpJoinDate.Value;
            _Member.Status = chkStatus.Checked;

            if (_Member.Save())
            {
                MessageBox.Show("Member saved successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Failed to save member!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
