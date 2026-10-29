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
    }
}
