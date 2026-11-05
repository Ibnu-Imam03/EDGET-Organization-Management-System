using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDGET.Business;

namespace EDGET.Presentation.Family
{
    public partial class FrmListFamilies : Form
    {
        public FrmListFamilies()
        {
            InitializeComponent();
        }

        private void FrmListFamilies_Load(object sender, EventArgs e)
        {
            LoadFamilies();
        }

        private void LoadFamilies()
        {
            DataTable dt = ClsFamilyBusiness.GetAllFamilies();

            if (dt == null)
            {
                MessageBox.Show("Error loading families.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            dgvFamilies.DataSource = dt;
        }

        private void showMembersInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvFamilies.CurrentRow == null)
            {
                MessageBox.Show("Please select a family first.");
                return;
            }

            int FamilyID = Convert.ToInt32(dgvFamilies.CurrentRow.Cells["FamilyID"].Value);

            frmShowFamily frm = new frmShowFamily(FamilyID);

            frm.ShowDialog();
        }

        private void addNewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditFamily frm = new frmAddEditFamily();
            frm.ShowDialog();
            FrmListFamilies_Load(null,null);
        }

        private void updateMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvFamilies.CurrentRow == null)
            {
                MessageBox.Show("Please select a Family first!","Select Family", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            int FamilyID = Convert.ToInt32(dgvFamilies.CurrentRow.Cells["FamilyID"].Value);

            frmAddEditFamily frm = new frmAddEditFamily(FamilyID);
            frm.ShowDialog();

            FrmListFamilies_Load(null,null);
        }

        private void deleteMemeberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvFamilies.CurrentRow == null)
            {
                MessageBox.Show("Please select a Family first!","Select Family", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            int FamilyID = Convert.ToInt32(dgvFamilies.CurrentRow.Cells["FamilyID"].Value);

            if (MessageBox.Show("Are you sure you want to delete this Family?","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ClsFamilyBusiness.DeleteFamily(FamilyID))
                {
                    MessageBox.Show("Family deleted successfully!","Deleted", MessageBoxButtons.OK,MessageBoxIcon.Information);

                    LoadFamilies();
                }
                else
                {
                    MessageBox.Show(
                        "Failed to delete Family. It may have associated Child records.","Delete Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}
