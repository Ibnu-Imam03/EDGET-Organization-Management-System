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
    public partial class frmShowMember : Form
    {
        public frmShowMember(int PersoinID)
        {
            InitializeComponent();
            LoadMembers(PersoinID );
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmShowMember_Load(object sender, EventArgs e)
        {

        }

        private void LoadMembers(int MemberID)
        {
            ClsMemberBusiness Member = ClsMemberBusiness.GetMemberByID(MemberID);

            if (Member == null)
            {
                MessageBox.Show("Member not found!","Not Found",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                return;
            }

            // Load the associated Person information.
            uC_PersonInfo1.LoadPersonInfo(Member.PersonID);

            // Display Member information.
            lblDepartmet.Text = Member.Department;
            lblJoinDate.Text = Member.JoinDate.ToString("dd/MM/yyyy");
            lblStudentID.Text = Member.StudentID;
            lblStudyYear.Text = Member.YearOfStudy.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
