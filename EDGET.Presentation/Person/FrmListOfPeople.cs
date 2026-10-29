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

namespace EDGET.Presentation
{
    public partial class FrmListOfPeople : Form
    {
        public FrmListOfPeople()
        {
            InitializeComponent();
        }

        

        private void FrmPeople_Load(object sender, EventArgs e)
        {



            dgvPeople.DataSource = ClsPersonBusiness.GetAllPeople();
            dgvPeople.Columns["PersonID"].HeaderText = "ID";
            dgvPeople.Columns["FullName"].HeaderText = "Full Name";
            dgvPeople.Columns["Sex"].HeaderText = "Sex";
            dgvPeople.Columns["TelegramUserName"].HeaderText = "Telegram Username";


        }

        private void kbtnAddPerson_Click(object sender, EventArgs e)
        {

        }

        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddEditPerson frm = new FrmAddEditPerson();
            frm.ShowDialog();
            FrmPeople_Load(null, null);
        }

        private void updatePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeople.CurrentRow == null)
            {
                MessageBox.Show("Please select a person first.", "No Person Selected",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRow = Convert.ToInt32(dgvPeople.CurrentRow.Cells["PersonID"].Value);

            FrmAddEditPerson frm = new FrmAddEditPerson(selectedRow);

            frm.ShowDialog();

            FrmPeople_Load(null, null);
        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeople.CurrentRow == null)
            {
                MessageBox.Show("Please select a person first.", "No Person Selected",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int personID = Convert.ToInt32(dgvPeople.CurrentRow.Cells["PersonID"].Value);
            string fullName = Convert.ToString(dgvPeople.CurrentRow.Cells["FullName"].Value);

            if (MessageBox.Show($"Are you sure you want to delete '{fullName}'?", "Confirm Delete",MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            ClsPersonBusiness person = new ClsPersonBusiness();

            if (person.DeletePerson(personID))
            {
                MessageBox.Show("Person deleted successfully.", "Success",MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmPeople_Load(null, null);
            }
            else
            {
                MessageBox.Show("Failed to delete person.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeople.CurrentRow == null)
            {
                MessageBox.Show("Please select a person first.", "No Person Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRow = Convert.ToInt32(dgvPeople.CurrentRow.Cells["PersonID"].Value);

            ShowPersonInfo frm = new ShowPersonInfo(selectedRow);
            frm.ShowDialog();
        }
    }
}
