
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
            DatabaseConnectionManager manager =
       new DatabaseConnectionManager();

            string result = manager.TestConnection();

            MessageBox.Show(result);

        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
