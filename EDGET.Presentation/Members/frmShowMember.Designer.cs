namespace EDGET.Presentation.Members
{
    partial class frmShowFamily
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkStatus = new Krypton.Toolkit.KryptonCheckBox();
            this.lblFamilyName = new System.Windows.Forms.Label();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblStudyYear = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.uC_PersonInfo2 = new EDGET.Presentation.UC_PersonInfo();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Join Date : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Year of Study : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Department : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Student ID : ";
            // 
            // chkStatus
            // 
            this.chkStatus.Location = new System.Drawing.Point(39, 472);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(139, 23);
            this.chkStatus.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStatus.TabIndex = 15;
            this.chkStatus.Values.Text = "Active Member";
            // 
            // lblFamilyName
            // 
            this.lblFamilyName.AutoSize = true;
            this.lblFamilyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamilyName.Location = new System.Drawing.Point(170, 369);
            this.lblFamilyName.Name = "lblFamilyName";
            this.lblFamilyName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFamilyName.Size = new System.Drawing.Size(60, 25);
            this.lblFamilyName.TabIndex = 20;
            this.lblFamilyName.Text = "????";
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.AutoSize = true;
            this.lblJoinDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoinDate.Location = new System.Drawing.Point(170, 411);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(60, 25);
            this.lblJoinDate.TabIndex = 21;
            this.lblJoinDate.Text = "????";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(608, 369);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 25);
            this.lblAddress.TabIndex = 22;
            this.lblAddress.Text = "????";
            // 
            // lblStudyYear
            // 
            this.lblStudyYear.AutoSize = true;
            this.lblStudyYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudyYear.Location = new System.Drawing.Point(608, 411);
            this.lblStudyYear.Name = "lblStudyYear";
            this.lblStudyYear.Size = new System.Drawing.Size(60, 25);
            this.lblStudyYear.TabIndex = 23;
            this.lblStudyYear.Text = "????";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(613, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 33);
            this.button1.TabIndex = 24;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // uC_PersonInfo2
            // 
            this.uC_PersonInfo2.BackColor = System.Drawing.Color.White;
            this.uC_PersonInfo2.Location = new System.Drawing.Point(0, 0);
            this.uC_PersonInfo2.Name = "uC_PersonInfo2";
            this.uC_PersonInfo2.Size = new System.Drawing.Size(791, 344);
            this.uC_PersonInfo2.TabIndex = 25;
            // 
            // frmShowFamily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 528);
            this.Controls.Add(this.uC_PersonInfo2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblStudyYear);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblJoinDate);
            this.Controls.Add(this.lblFamilyName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkStatus);
            this.Name = "frmShowFamily";
            this.Text = "frmShowMember";
            this.Load += new System.EventHandler(this.frmShowFamily_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC_PersonInfo uC_PersonInfo1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Krypton.Toolkit.KryptonCheckBox chkStatus;
        private System.Windows.Forms.Label lblFamilyName;
        private System.Windows.Forms.Label lblJoinDate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblStudyYear;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UC_PersonInfo uC_PersonInfo2;
    }
}