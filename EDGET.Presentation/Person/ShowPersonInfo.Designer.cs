namespace EDGET.Presentation
{
    partial class ShowPersonInfo
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
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.uC_PersonInfo1 = new EDGET.Presentation.UC_PersonInfo();
            this.SuspendLayout();
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(621, 349);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(140, 43);
            this.kryptonButton1.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 1;
            this.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton1.Values.Text = "Cancel";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // uC_PersonInfo1
            // 
            this.uC_PersonInfo1.BackColor = System.Drawing.Color.White;
            this.uC_PersonInfo1.Location = new System.Drawing.Point(1, 1);
            this.uC_PersonInfo1.Name = "uC_PersonInfo1";
            this.uC_PersonInfo1.Size = new System.Drawing.Size(791, 344);
            this.uC_PersonInfo1.TabIndex = 2;
            // 
            // ShowPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 404);
            this.Controls.Add(this.uC_PersonInfo1);
            this.Controls.Add(this.kryptonButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ShowPersonInfo";
            this.Text = "ShowPersonInfo";
            this.Load += new System.EventHandler(this.ShowPersonInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private UC_PersonInfo uC_PersonInfo1;
    }
}