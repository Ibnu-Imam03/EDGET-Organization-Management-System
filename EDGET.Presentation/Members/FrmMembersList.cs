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

namespace EDGET.Presentation.Members
{
    public partial class FrmMembersList : Form
    {
        public FrmMembersList()
        {
            InitializeComponent();
            
        }

        private void FrmMembersList_Load(object sender, EventArgs e)
        {
            dgvMembers.DataSource = ClsMemberBusiness.GetAllMembers();

            if (dgvMembers.Columns["MemberID"] != null)
                dgvMembers.Columns["MemberID"].HeaderText = "Member ID";

            if (dgvMembers.Columns["PersonID"] != null)
                dgvMembers.Columns["PersonID"].Visible = false;

            if (dgvMembers.Columns["YearOfStudy"] != null)
                dgvMembers.Columns["YearOfStudy"].HeaderText = "Year of Study";

            if (dgvMembers.Columns["TelegramUserName"] != null)
                dgvMembers.Columns["TelegramUserName"].HeaderText = "Telegram Username";
        }

        private void addNewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddEditMember frm = new FrmAddEditMember();
            frm.Show();
        }

        private void updateMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int memberID = Convert.ToInt32(dgvMembers.CurrentRow.Cells["MemberID"].Value);

            using (FrmAddEditMember frm = new FrmAddEditMember(memberID))
            {
                frm.ShowDialog();
            }
        }

        private void deleteMemeberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow == null) { MessageBox.Show("Please select a member first."); return; }

            int memberID = Convert.ToInt32(dgvMembers.CurrentRow.Cells["MemberID"].Value);

            if (MessageBox.Show("Are you sure you want to delete this member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ClsMemberBusiness member = ClsMemberBusiness.GetMemberByID(memberID);

                if (member != null && member.DeleteMember(memberID))
                {
                    MessageBox.Show("Member deleted successfully!");
                }
                else MessageBox.Show("Failed to delete member.");
            }

            FrmMembersList_Load(null, null);
        }
    }
}
