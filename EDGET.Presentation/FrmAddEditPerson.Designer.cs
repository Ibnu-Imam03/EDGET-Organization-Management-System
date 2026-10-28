namespace EDGET.Presentation
{
    partial class FrmAddEditPerson
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
            this.components = new System.ComponentModel.Container();
            this.kryptonPanelHeader = new Krypton.Toolkit.KryptonPanel();
            this.lblTitle = new Krypton.Toolkit.KryptonLabel();
            this.lblFullName = new Krypton.Toolkit.KryptonLabel();
            this.lblSex = new Krypton.Toolkit.KryptonLabel();
            this.lblTelegramUsername = new Krypton.Toolkit.KryptonLabel();
            this.cmbSex = new Krypton.Toolkit.KryptonComboBox();
            this.txtFullName = new Krypton.Toolkit.KryptonTextBox();
            this.txtTelegramUsername = new Krypton.Toolkit.KryptonTextBox();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.btnCancel = new Krypton.Toolkit.KryptonButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelHeader)).BeginInit();
            this.kryptonPanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanelHeader
            // 
            this.kryptonPanelHeader.Controls.Add(this.lblTitle);
            this.kryptonPanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanelHeader.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelHeader.Name = "kryptonPanelHeader";
            this.kryptonPanelHeader.Size = new System.Drawing.Size(584, 75);
            this.kryptonPanelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(180, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(208, 37);
            this.lblTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Values.Text = "Add New Person";
            // 
            // lblFullName
            // 
            this.lblFullName.Location = new System.Drawing.Point(12, 93);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(90, 26);
            this.lblFullName.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Values.Text = "Full Name ";
            // 
            // lblSex
            // 
            this.lblSex.Location = new System.Drawing.Point(12, 154);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(41, 26);
            this.lblSex.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.TabIndex = 2;
            this.lblSex.Values.Text = "SEX";
            // 
            // lblTelegramUsername
            // 
            this.lblTelegramUsername.Location = new System.Drawing.Point(12, 216);
            this.lblTelegramUsername.Name = "lblTelegramUsername";
            this.lblTelegramUsername.Size = new System.Drawing.Size(174, 26);
            this.lblTelegramUsername.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelegramUsername.TabIndex = 3;
            this.lblTelegramUsername.Values.Text = "Telegram User Name";
            // 
            // cmbSex
            // 
            this.cmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbSex.Location = new System.Drawing.Point(12, 188);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(125, 22);
            this.cmbSex.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbSex.TabIndex = 4;
            this.cmbSex.Validating += new System.ComponentModel.CancelEventHandler(this.cmbSex_Validating);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(12, 125);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(437, 23);
            this.txtFullName.TabIndex = 5;
            this.txtFullName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFullName_Validating);
            // 
            // txtTelegramUsername
            // 
            this.txtTelegramUsername.Location = new System.Drawing.Point(12, 248);
            this.txtTelegramUsername.Name = "txtTelegramUsername";
            this.txtTelegramUsername.Size = new System.Drawing.Size(437, 23);
            this.txtTelegramUsername.TabIndex = 6;
            this.txtTelegramUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelegramUsername_Validating);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(85, 305);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(190, 41);
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.TabIndex = 7;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Text = "Save Person";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(304, 305);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(190, 41);
            this.btnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCancel.Values.Text = "Cancel";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTelegramUsername);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.cmbSex);
            this.Controls.Add(this.lblTelegramUsername);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.kryptonPanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddEditPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Person — EDGET";
            this.Load += new System.EventHandler(this.FrmAddEditPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelHeader)).EndInit();
            this.kryptonPanelHeader.ResumeLayout(false);
            this.kryptonPanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanelHeader;
        private Krypton.Toolkit.KryptonLabel lblTitle;
        private Krypton.Toolkit.KryptonLabel lblFullName;
        private Krypton.Toolkit.KryptonLabel lblSex;
        private Krypton.Toolkit.KryptonLabel lblTelegramUsername;
        private Krypton.Toolkit.KryptonComboBox cmbSex;
        private Krypton.Toolkit.KryptonTextBox txtFullName;
        private Krypton.Toolkit.KryptonTextBox txtTelegramUsername;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}