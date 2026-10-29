
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
        }
        private void LoadFormInPanel(Form frm)
        {
            pnlContent.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(frm);
            frm.Show();
        }
       

        private void btnPeople_Click(object sender, EventArgs e)
        {
            pnlSidebar.Visible = false;

            LoadFormInPanel(new FrmListOfPeople());
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            pnlSidebar.Visible = !pnlSidebar.Visible;

        }
    }
}
