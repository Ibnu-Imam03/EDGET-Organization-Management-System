namespace EDGET.Presentation
{
    partial class FrmPeople
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
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.lblTitle = new Krypton.Toolkit.KryptonLabel();
            this.lblSubtitle = new Krypton.Toolkit.KryptonLabel();
            this.btnAddNew = new Krypton.Toolkit.KryptonButton();
            this.btnUpdate = new Krypton.Toolkit.KryptonButton();
            this.btnDelete = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnDelete);
            this.kryptonPanel1.Controls.Add(this.btnUpdate);
            this.kryptonPanel1.Controls.Add(this.btnAddNew);
            this.kryptonPanel1.Controls.Add(this.lblSubtitle);
            this.kryptonPanel1.Controls.Add(this.lblTitle);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.MaximumSize = new System.Drawing.Size(0, 100);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1002, 100);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(170)))));
            this.kryptonPanel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(408, 45);
            this.lblTitle.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Values.Text = "EDGET People Management";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Location = new System.Drawing.Point(28, 60);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(237, 21);
            this.lblSubtitle.StateCommon.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.lblSubtitle.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Values.Text = "Manage EDGET organization people";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.Location = new System.Drawing.Point(498, 55);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(160, 42);
            this.btnAddNew.StateCommon.Back.Color1 = System.Drawing.Color.Cyan;
            this.btnAddNew.StateCommon.Back.Color2 = System.Drawing.Color.Cyan;
            this.btnAddNew.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddNew.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAddNew.Values.Text = "Add New Person";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(664, 55);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 42);
            this.btnUpdate.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnUpdate.Values.Text = "Update Person";
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(830, 55);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 42);
            this.btnDelete.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.btnDelete.StateCommon.Back.Color2 = System.Drawing.Color.Red;
            this.btnDelete.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnDelete.Values.Text = "Delete Person";
            // 
            // FrmPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 468);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "FrmPeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDGET — People Management";
            this.Load += new System.EventHandler(this.FrmPeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel lblTitle;
        private Krypton.Toolkit.KryptonLabel lblSubtitle;
        private Krypton.Toolkit.KryptonButton btnAddNew;
        private Krypton.Toolkit.KryptonButton btnDelete;
        private Krypton.Toolkit.KryptonButton btnUpdate;
    }
}