
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
            ArchitectureTest test = new ArchitectureTest();
            MessageBox.Show(test.GetMessage());
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
