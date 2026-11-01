namespace EDGET.Presentation
{
    partial class UC_PersonInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.txtPersonID = new Krypton.Toolkit.KryptonTextBox();
            this.txtFullName = new Krypton.Toolkit.KryptonTextBox();
            this.txtSex = new Krypton.Toolkit.KryptonTextBox();
            this.txtTelegramUsername = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone1 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.txtPhone2 = new Krypton.Toolkit.KryptonTextBox();
            this.txtPhone3 = new Krypton.Toolkit.KryptonTextBox();
            this.txtPhone4 = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(38, 101);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(96, 26);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Person ID : ";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(35, 153);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(99, 26);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "Full Name : ";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(86, 205);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(48, 26);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 3;
            this.kryptonLabel4.Values.Text = "Sex : ";
            this.kryptonLabel4.Click += new System.EventHandler(this.kryptonLabel4_Click);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(40, 261);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(94, 26);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 4;
            this.kryptonLabel5.Values.Text = "Telegram : ";
            // 
            // txtPersonID
            // 
            this.txtPersonID.Location = new System.Drawing.Point(147, 101);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.ReadOnly = true;
            this.txtPersonID.Size = new System.Drawing.Size(309, 23);
            this.txtPersonID.TabIndex = 5;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(147, 153);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(309, 23);
            this.txtFullName.TabIndex = 6;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(147, 205);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(309, 23);
            this.txtSex.TabIndex = 7;
            // 
            // txtTelegramUsername
            // 
            this.txtTelegramUsername.Location = new System.Drawing.Point(147, 258);
            this.txtTelegramUsername.Name = "txtTelegramUsername";
            this.txtTelegramUsername.ReadOnly = true;
            this.txtTelegramUsername.Size = new System.Drawing.Size(309, 23);
            this.txtTelegramUsername.TabIndex = 8;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.label1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(791, 85);
            this.kryptonPanel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Person Info";
            // 
            // txtPhone1
            // 
            this.txtPhone1.Location = new System.Drawing.Point(147, 300);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.ReadOnly = true;
            this.txtPhone1.Size = new System.Drawing.Size(119, 23);
            this.txtPhone1.TabIndex = 11;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(60, 303);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(70, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 10;
            this.kryptonLabel1.Values.Text = "Phone : ";
            // 
            // txtPhone2
            // 
            this.txtPhone2.Location = new System.Drawing.Point(305, 300);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.ReadOnly = true;
            this.txtPhone2.Size = new System.Drawing.Size(119, 23);
            this.txtPhone2.TabIndex = 12;
            // 
            // txtPhone3
            // 
            this.txtPhone3.Location = new System.Drawing.Point(455, 300);
            this.txtPhone3.Name = "txtPhone3";
            this.txtPhone3.ReadOnly = true;
            this.txtPhone3.Size = new System.Drawing.Size(119, 23);
            this.txtPhone3.TabIndex = 13;
            // 
            // txtPhone4
            // 
            this.txtPhone4.Location = new System.Drawing.Point(594, 300);
            this.txtPhone4.Name = "txtPhone4";
            this.txtPhone4.ReadOnly = true;
            this.txtPhone4.Size = new System.Drawing.Size(119, 23);
            this.txtPhone4.TabIndex = 14;
            // 
            // UC_PersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtPhone4);
            this.Controls.Add(this.txtPhone3);
            this.Controls.Add(this.txtPhone2);
            this.Controls.Add(this.txtPhone1);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.txtTelegramUsername);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtPersonID);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "UC_PersonInfo";
            this.Size = new System.Drawing.Size(791, 344);
            this.Load += new System.EventHandler(this.UC_PersonInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonTextBox txtPersonID;
        private Krypton.Toolkit.KryptonTextBox txtFullName;
        private Krypton.Toolkit.KryptonTextBox txtSex;
        private Krypton.Toolkit.KryptonTextBox txtTelegramUsername;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonTextBox txtPhone1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox txtPhone2;
        private Krypton.Toolkit.KryptonTextBox txtPhone3;
        private Krypton.Toolkit.KryptonTextBox txtPhone4;
    }
}
