namespace EDGET.Presentation.Members
{
    partial class frmShowMember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uC_PersonInfo1 = new EDGET.Presentation.UC_PersonInfo();
            this.SuspendLayout();
            // 
            // uC_PersonInfo1
            // 
            this.uC_PersonInfo1.BackColor = System.Drawing.Color.White;
            this.uC_PersonInfo1.Location = new System.Drawing.Point(2, 75);
            this.uC_PersonInfo1.Name = "uC_PersonInfo1";
            this.uC_PersonInfo1.Size = new System.Drawing.Size(791, 313);
            this.uC_PersonInfo1.TabIndex = 0;
            // 
            // frmShowMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 528);
            this.Controls.Add(this.uC_PersonInfo1);
            this.Name = "frmShowMember";
            this.Text = "frmShowMember";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_PersonInfo uC_PersonInfo1;
    }
}