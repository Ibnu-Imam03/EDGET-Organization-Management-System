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

        }
    }
}
