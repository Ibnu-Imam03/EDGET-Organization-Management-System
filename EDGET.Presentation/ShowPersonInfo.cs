using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDGET.Presentation
{
    public partial class ShowPersonInfo : Form
    {
        int _PersonID = -1;
        public ShowPersonInfo(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void uC_PersonInfo1_Load(object sender, EventArgs e)
        {

        }

        private void ShowPersonInfo_Load(object sender, EventArgs e)
        {
            uC_PersonInfo1.LoadPersonInfo(_PersonID);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
