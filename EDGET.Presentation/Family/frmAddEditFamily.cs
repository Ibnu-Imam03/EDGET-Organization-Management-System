using EDGET.Business;
using System;
using System.Windows.Forms;

namespace EDGET.Presentation.Family
{
    public partial class frmAddEditFamily : Form
    {
        private ClsFamilyBusiness _Family;
        private ClsPersonBusiness _Person;


        public frmAddEditFamily()
        {
            InitializeComponent();

            _Family = new ClsFamilyBusiness();
            _Person = null;
        }

        // Edit existing Family
        public frmAddEditFamily(int FamilyID)
        {
            InitializeComponent();

            LoadFamily(FamilyID);
        }

        private void LoadFamily(int FamilyID)
        {
            _Family = ClsFamilyBusiness.GetFamilyByID(FamilyID);

            if (_Family == null)
            {
                MessageBox.Show("Family not found!","Not Found", MessageBoxButtons.OK,MessageBoxIcon.Warning);

                this.Close();
                return;
            }

            _Person = ClsPersonBusiness.GetPersonByID(_Family.PersonID);

            txtPersonID.Text = _Family.PersonID.ToString();
            txtFamilyName.Text = _Family.FamilyName;
            txtAddress.Text = _Family.Address;
            txtSituation.Text = _Family.Situation;
        }

        private void txtPersonID_TextChanged(object sender, EventArgs e)
        {

        }

        // Find existing Person
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPersonID.Text, out int PersonID))
            {
                MessageBox.Show("Please enter a valid Person ID.","Invalid ID", MessageBoxButtons.OK,MessageBoxIcon.Warning);

                return;
            }

            _Person = ClsPersonBusiness.GetPersonByID(PersonID);

            if (_Person == null)
            {
                MessageBox.Show("Person not found!","Not Found", MessageBoxButtons.OK,MessageBoxIcon.Warning);

                return;
            }

            MessageBox.Show("Person found: " + _Person.FullName,"Found", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        // Add New Person
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FrmAddEditPerson frm = new FrmAddEditPerson();

            frm.OnPersonSaved = AddNewPerson_OnPersonSaved;

            frm.ShowDialog();
        }

        private void AddNewPerson_OnPersonSaved(int PersonID)
        {
            txtPersonID.Text = PersonID.ToString();

            _Person = ClsPersonBusiness.GetPersonByID(PersonID);
        }

        private void txtFamilyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAddEditFamily_Load(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSituation_TextChanged(object sender, EventArgs e)
        {

        }

        // Save Family
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Person == null)
            {
                MessageBox.Show("Please find or add a Person first.",
                    "Person Required", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(txtFamilyName.Text))
            {
                MessageBox.Show("Please enter the Family Name.",
                    "Required Field", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtFamilyName.Focus();
                return;
            }

            if (ClsMemberBusiness.IsPersonEsitedInMembere(_Person.PersonID))
            {
                MessageBox.Show("This Person is already registered as a Member and cannot be registered as a Family.","Person Already Exists",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                return;
            }

            _Family.PersonID = _Person.PersonID;
            _Family.FamilyName = txtFamilyName.Text.Trim();
            _Family.Address = txtAddress.Text.Trim();
            _Family.Situation = txtSituation.Text.Trim();

            if (_Family.Save())
            {
                MessageBox.Show("Family saved successfully!",
                    "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to save Family.",
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}