namespace WindowsFormsApp1
{
    partial class Form1
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.studentInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readingJournalIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readingJournalReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addJournalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mainMenu.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentInformationToolStripMenuItem,
            this.employeeInformationToolStripMenuItem,
            this.circulationToolStripMenuItem,
            this.libraryInformationToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(20, 8, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(1902, 59);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // studentInformationToolStripMenuItem
            // 
            this.studentInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.studentSearchToolStripMenuItem,
            this.studentDueToolStripMenuItem});
            this.studentInformationToolStripMenuItem.Name = "studentInformationToolStripMenuItem";
            this.studentInformationToolStripMenuItem.Size = new System.Drawing.Size(326, 49);
            this.studentInformationToolStripMenuItem.Text = "Student Information";
            this.studentInformationToolStripMenuItem.Click += new System.EventHandler(this.studentInformationToolStripMenuItem_Click);
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // studentSearchToolStripMenuItem
            // 
            this.studentSearchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentSearchToolStripMenuItem.Name = "studentSearchToolStripMenuItem";
            this.studentSearchToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.studentSearchToolStripMenuItem.Text = "Student Search";
            this.studentSearchToolStripMenuItem.Click += new System.EventHandler(this.studentSearchToolStripMenuItem_Click);
            // 
            // studentDueToolStripMenuItem
            // 
            this.studentDueToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDueToolStripMenuItem.Name = "studentDueToolStripMenuItem";
            this.studentDueToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.studentDueToolStripMenuItem.Text = "Student Due";
            this.studentDueToolStripMenuItem.Click += new System.EventHandler(this.studentDueToolStripMenuItem_Click);
            // 
            // employeeInformationToolStripMenuItem
            // 
            this.employeeInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.employeeSearchToolStripMenuItem});
            this.employeeInformationToolStripMenuItem.Name = "employeeInformationToolStripMenuItem";
            this.employeeInformationToolStripMenuItem.Size = new System.Drawing.Size(354, 49);
            this.employeeInformationToolStripMenuItem.Text = "Employee Information";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(292, 36);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            // 
            // employeeSearchToolStripMenuItem
            // 
            this.employeeSearchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeSearchToolStripMenuItem.Name = "employeeSearchToolStripMenuItem";
            this.employeeSearchToolStripMenuItem.Size = new System.Drawing.Size(292, 36);
            this.employeeSearchToolStripMenuItem.Text = "Employee Search";
            // 
            // circulationToolStripMenuItem
            // 
            this.circulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readingJournalIssueToolStripMenuItem,
            this.readingJournalReturnToolStripMenuItem});
            this.circulationToolStripMenuItem.Name = "circulationToolStripMenuItem";
            this.circulationToolStripMenuItem.Size = new System.Drawing.Size(189, 49);
            this.circulationToolStripMenuItem.Text = "Circulation";
            // 
            // readingJournalIssueToolStripMenuItem
            // 
            this.readingJournalIssueToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readingJournalIssueToolStripMenuItem.Name = "readingJournalIssueToolStripMenuItem";
            this.readingJournalIssueToolStripMenuItem.Size = new System.Drawing.Size(356, 36);
            this.readingJournalIssueToolStripMenuItem.Text = "Reading Journal Issue";
            this.readingJournalIssueToolStripMenuItem.Click += new System.EventHandler(this.readingJournalIssueToolStripMenuItem_Click);
            // 
            // readingJournalReturnToolStripMenuItem
            // 
            this.readingJournalReturnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readingJournalReturnToolStripMenuItem.Name = "readingJournalReturnToolStripMenuItem";
            this.readingJournalReturnToolStripMenuItem.Size = new System.Drawing.Size(356, 36);
            this.readingJournalReturnToolStripMenuItem.Text = "Reading Journal Return";
            this.readingJournalReturnToolStripMenuItem.Click += new System.EventHandler(this.readingJournalReturnToolStripMenuItem_Click);
            // 
            // libraryInformationToolStripMenuItem
            // 
            this.libraryInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addJournalsToolStripMenuItem});
            this.libraryInformationToolStripMenuItem.Name = "libraryInformationToolStripMenuItem";
            this.libraryInformationToolStripMenuItem.Size = new System.Drawing.Size(311, 49);
            this.libraryInformationToolStripMenuItem.Text = "Library Information";
            // 
            // addJournalsToolStripMenuItem
            // 
            this.addJournalsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addJournalsToolStripMenuItem.Name = "addJournalsToolStripMenuItem";
            this.addJournalsToolStripMenuItem.Size = new System.Drawing.Size(246, 36);
            this.addJournalsToolStripMenuItem.Text = "Add Journals";
            this.addJournalsToolStripMenuItem.Click += new System.EventHandler(this.addJournalsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(144, 49);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 974);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.lib4;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1902, 974);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Form1";
            this.Text = "Library Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem studentInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentDueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libraryInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readingJournalIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readingJournalReturnToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem addJournalsToolStripMenuItem;
    }
}

