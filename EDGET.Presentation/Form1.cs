
using System;
using System.Windows.Forms;
using EDGET.Business;

namespace EDGET.Presentation
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
          

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dgvPeople.DataSource = ClsPersonBusiness.GetAllPeople();
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void kryptonPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
