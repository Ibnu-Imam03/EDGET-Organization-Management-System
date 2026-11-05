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
    public partial class frmShowFamily : Form
    {
        public frmShowFamily(int PersoinID)
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
            uC_PersonInfo2.LoadPersonInfo(Member.PersonID);

            // Display Member information.
            lblAddress.Text = Member.Department;
            lblJoinDate.Text = Member.JoinDate.ToString("dd/MM/yyyy");
            lblFamilyName.Text = Member.StudentID;
            lblStudyYear.Text = Member.YearOfStudy.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void frmShowFamily_Load(object sender, EventArgs e)
        {

        }

        private void frmShowFamily_Load_1(object sender, EventArgs e)
        {

        }
    }
}
