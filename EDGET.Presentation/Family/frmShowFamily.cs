using EDGET.Business;
using System;
using System.Windows.Forms;

namespace EDGET.Presentation.Family
{
    public partial class frmShowFamily : Form
    {
        public frmShowFamily(int FamilyID)
        {
            InitializeComponent();
            LoadFamily(FamilyID);
        }

        private void LoadFamily(int FamilyID)
        {
            ClsFamilyBusiness Family =ClsFamilyBusiness.GetFamilyByID(FamilyID);

            if (Family == null)
            {
                MessageBox.Show("Family not found!","Not Found",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                this.Close();
                return;
            }

            // Load associated Person information.
            uC_PersonInfo1.LoadPersonInfo(Family.PersonID);

            // Display Family information.
            lblFamilyName.Text = Family.FamilyName;
            lblAddress.Text = Family.Address;
            lblSituation.Text = Family.Situation;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uC_PersonInfo1_Load(object sender, EventArgs e)
        {

        }

        private void lblFamilyName_Click(object sender, EventArgs e)
        {

        }

        private void lblSituation_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void frmShowFamily_Load(object sender, EventArgs e)
        {

        }
    }
}