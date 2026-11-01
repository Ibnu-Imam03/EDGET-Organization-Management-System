using EDGET.Business;
using EDGET.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDGET.Presentation
{
    public partial class UC_PersonInfo : UserControl
    {
        public UC_PersonInfo()
        {
            InitializeComponent();
        }

        private void kryptonLabel4_Click(object sender, EventArgs e)
        {

        }


        public void LoadPersonInfo(int personID)
        {
            ClsPersonBusiness person =ClsPersonBusiness.GetPersonByID(personID);

            if (person == null)
            {
                ClearPersonInfo();
                MessageBox.Show("Person not found.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtPersonID.Text = person.PersonID.ToString();
            txtFullName.Text = person.FullName;
            txtSex.Text = person.Gender;
            txtTelegramUsername.Text = person.TelegramUserName;
            txtPhone1.Text = person.Phone1;
            txtPhone2.Text = person.Phone2;
            txtPhone3.Text = person.Phone3;
            txtPhone4.Text = person.Phone4;

        }

        public void ClearPersonInfo()
        {
            txtPersonID.Clear();
            txtFullName.Clear();
            txtSex.Clear();
            txtTelegramUsername.Clear();
            txtPhone1.Clear();
            txtPhone2.Clear();
            txtPhone3.Clear();
            txtPhone4.Clear();


        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_PersonInfo_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }
    }
}
