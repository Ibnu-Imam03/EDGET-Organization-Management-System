namespace EDGET.Presentation
{
    partial class FrmMain
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
            this.pnlHeader = new Krypton.Toolkit.KryptonPanel();
            this.btnMenu = new Krypton.Toolkit.KryptonButton();
            this.pnlSidebar = new Krypton.Toolkit.KryptonPanel();
            this.btnEvents = new Krypton.Toolkit.KryptonButton();
            this.btnDocuments = new Krypton.Toolkit.KryptonButton();
            this.btnZiyara = new Krypton.Toolkit.KryptonButton();
            this.btnFinance = new Krypton.Toolkit.KryptonButton();
            this.btnAcademic = new Krypton.Toolkit.KryptonButton();
            this.btnChildren = new Krypton.Toolkit.KryptonButton();
            this.btnPeople = new Krypton.Toolkit.KryptonButton();
            this.btnMembers = new Krypton.Toolkit.KryptonButton();
            this.btnDashboard = new Krypton.Toolkit.KryptonButton();
            this.pnlContent = new Krypton.Toolkit.KryptonPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSidebar)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.btnMenu);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(874, 100);
            this.pnlHeader.StateCommon.Color1 = System.Drawing.Color.Blue;
            this.pnlHeader.StateCommon.Color2 = System.Drawing.Color.Blue;
            this.pnlHeader.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(12, 59);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 35);
            this.btnMenu.StateCommon.Back.Color1 = System.Drawing.Color.Blue;
            this.btnMenu.StateCommon.Back.Color2 = System.Drawing.Color.Blue;
            this.btnMenu.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnMenu.Values.Text = "☰";
            this.btnMenu.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.btnEvents);
            this.pnlSidebar.Controls.Add(this.btnDocuments);
            this.pnlSidebar.Controls.Add(this.btnZiyara);
            this.pnlSidebar.Controls.Add(this.btnFinance);
            this.pnlSidebar.Controls.Add(this.btnAcademic);
            this.pnlSidebar.Controls.Add(this.btnChildren);
            this.pnlSidebar.Controls.Add(this.btnPeople);
            this.pnlSidebar.Controls.Add(this.btnMembers);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 100);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(233, 420);
            this.pnlSidebar.StateCommon.Color1 = System.Drawing.Color.Cyan;
            this.pnlSidebar.TabIndex = 1;
            // 
            // btnEvents
            // 
            this.btnEvents.Location = new System.Drawing.Point(46, 332);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(118, 25);
            this.btnEvents.StateCommon.Back.Color1 = System.Drawing.Color.Cyan;
            this.btnEvents.StateCommon.Back.Color2 = System.Drawing.Color.Cyan;
            this.btnEvents.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnEvents.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Red;
            this.btnEvents.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvents.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEvents.TabIndex = 8;
            this.btnEvents.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnEvents.Values.Text = "Events";
            // 
            // btnDocuments
            // 
            this.btnDocuments.Location = new System.Drawing.Point(46, 377);
            this.btnDocuments.Name = "btnDocuments";
            this.btnDocuments.Size = new System.Drawing.Size(118, 25);
            this.btnDocuments.StateCommon.Back.Color1 = System.Drawing.Color.Cyan;
            this.btnDocuments.StateCommon.Back.Color2 = System.Drawing.Color.Cyan;
            this.btnDocuments.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnDocuments.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Red;
            this.btnDocuments.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocuments.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDocuments.TabIndex = 7;
            this.btnDocuments.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnDocuments.Values.Text = "Documents";
            // 
            // btnZiyara
            // 
            this.btnZiyara.Location = new System.Drawing.Point(46, 243);
            this.btnZiyara.Name = "btnZiyara";
            this.btnZiyara.Size = new System.Drawing.Size(118, 25);
            this.btnZiyara.StateCommon.Back.Color1 = System.Drawing.Color.Cyan;
            this.btnZiyara.StateCommon.Back.Color2 = System.Drawing.Color.Cyan;
            this.btnZiyara.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnZiyara.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Red;
            this.btnZiyara.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZiyara.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnZiyara.TabIndex = 6;
            this.btnZiyara.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnZiyara.Values.Text = "Ziyara";
            // 
            // btnFinance
            // 
            this.btnFinance.Location = new System.Drawing.Point(46, 291);
            this.btnFinance.Name = "btnFinance";
            this.btnFinance.Size = new System.Drawing.Size(118, 25);
            this.btnFinance.StateCommon.Back.Color1 = System.Drawing.Color.Cyan;
            this.btnFinance.StateCommon.Back.Color2 = System.Drawing.Color.Cyan;
            this.btnFinance.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnFinance.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Red;
            this.btnFinance.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinance.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFinance.TabIndex = 5;
            this.btnFinance.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnFinance.Values.Text = "Finance";
            // 
            // btnAcademic
            // 
            this.btnAcademic.Location = new System.Drawing.Point(46, 199);
            this.btnAcademic.Name = "btnAcademic";
            this.btnAcademic.Size = new System.Drawing.Size(118, 25);
            this.btnAcademic.StateCommon.Back.Color1 = System.Drawing.Color.Cyan;
            this.btnAcademic.StateCommon.Back.Color2 = System.Drawing.Color.Cyan;
            this.btnAcademic.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnAcademic.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Red;
            this.btnAcademic.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcademic.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAcademic.TabIndex = 4;
            this.btnAcademic.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAcademic.Values.Text = "Academic";
            // 
            // btnChildren
            // 
            this.btnChildren.Location = new System.Drawing.Point(46, 155);
            this.btnChildren.Name = "btnChildren";
            this.btnChildren.Size = new System.Drawing.Size(118, 25);
            this.btnChildren.StateCommon.Back.Color1 = System.Drawing.Color.Cyan;
            this.btnChildren.StateCommon.Back.Color2 = System.Drawing.Color.Cyan;
            this.btnChildren.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnChildren.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Red;
            this.btnChildren.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChildren.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnChildren.TabIndex = 3;
            this.btnChildren.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnChildren.Values.Text = "Children";
            // 
            // btnPeople
            // 
            this.btnPeople.Location = new System.Drawing.Point(46, 63);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(118, 25);
            this.btnPeople.StateCommon.Back.Color1 = System.Drawing.Color.Cyan;
            this.btnPeople.StateCommon.Back.Color2 = System.Drawing.Color.Cyan;
            this.btnPeople.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnPeople.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Red;
            this.btnPeople.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeople.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPeople.TabIndex = 2;
            this.btnPeople.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnPeople.Values.Text = "People";
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.Location = new System.Drawing.Point(46, 107);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(118, 25);
            this.btnMembers.StateCommon.Back.Color1 = System.Drawing.Color.Cyan;
            this.btnMembers.StateCommon.Back.Color2 = System.Drawing.Color.Cyan;
            this.btnMembers.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnMembers.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Red;
            this.btnMembers.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembers.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMembers.TabIndex = 1;
            this.btnMembers.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnMembers.Values.Text = "Members";
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(46, 20);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(118, 25);
            this.btnDashboard.StateCommon.Back.Color1 = System.Drawing.Color.Cyan;
            this.btnDashboard.StateCommon.Back.Color2 = System.Drawing.Color.Cyan;
            this.btnDashboard.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear50;
            this.btnDashboard.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnDashboard.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Red;
            this.btnDashboard.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnDashboard.Values.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(233, 100);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(641, 420);
            this.pnlContent.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(106, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "EDGET — Organization Management System";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(874, 520);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EDGET Charity Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSidebar)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel pnlHeader;
        private Krypton.Toolkit.KryptonPanel pnlSidebar;
        private Krypton.Toolkit.KryptonPanel pnlContent;
        private Krypton.Toolkit.KryptonButton btnAcademic;
        private Krypton.Toolkit.KryptonButton btnChildren;
        private Krypton.Toolkit.KryptonButton btnPeople;
        private Krypton.Toolkit.KryptonButton btnMembers;
        private Krypton.Toolkit.KryptonButton btnDashboard;
        private Krypton.Toolkit.KryptonButton btnEvents;
        private Krypton.Toolkit.KryptonButton btnDocuments;
        private Krypton.Toolkit.KryptonButton btnZiyara;
        private Krypton.Toolkit.KryptonButton btnFinance;
        private Krypton.Toolkit.KryptonButton btnMenu;
        private System.Windows.Forms.Label label1;
    }
}

