namespace WindowsFormsApp1
{
    partial class studentSearchForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.regno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stream = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 100);
            this.panel1.TabIndex = 1;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(412, 16);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(340, 55);
            this.title.TabIndex = 0;
            this.title.Text = "Search Engine\r\n";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(12, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1123, 177);
            this.panel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(453, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regno,
            this.fname,
            this.lname,
            this.surname,
            this.caste,
            this.dob,
            this.bg,
            this.gender,
            this.mobno,
            this.stream,
            this._class,
            this.rollno});
            this.dgv1.Location = new System.Drawing.Point(12, 333);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(1123, 409);
            this.dgv1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(551, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 27);
            this.textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Surname",
            "Gender",
            "Class",
            "Roll No"});
            this.comboBox1.Location = new System.Drawing.Point(311, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // regno
            // 
            this.regno.DataPropertyName = "Reg No";
            this.regno.HeaderText = "Reg No";
            this.regno.MinimumWidth = 6;
            this.regno.Name = "regno";
            this.regno.ReadOnly = true;
            this.regno.Width = 125;
            // 
            // fname
            // 
            this.fname.DataPropertyName = "First Name";
            this.fname.HeaderText = "First Name";
            this.fname.MinimumWidth = 6;
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            this.fname.Width = 125;
            // 
            // lname
            // 
            this.lname.DataPropertyName = "Last Name";
            this.lname.HeaderText = "Last Name";
            this.lname.MinimumWidth = 6;
            this.lname.Name = "lname";
            this.lname.ReadOnly = true;
            this.lname.Width = 125;
            // 
            // surname
            // 
            this.surname.DataPropertyName = "Surname";
            this.surname.HeaderText = "Surname";
            this.surname.MinimumWidth = 6;
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            this.surname.Width = 125;
            // 
            // caste
            // 
            this.caste.DataPropertyName = "Caste";
            this.caste.HeaderText = "Caste";
            this.caste.MinimumWidth = 6;
            this.caste.Name = "caste";
            this.caste.ReadOnly = true;
            this.caste.Width = 125;
            // 
            // dob
            // 
            this.dob.DataPropertyName = "Date of Birth";
            this.dob.HeaderText = "Date of Birth";
            this.dob.MinimumWidth = 6;
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            this.dob.Width = 125;
            // 
            // bg
            // 
            this.bg.DataPropertyName = "Blood Group";
            this.bg.HeaderText = "Blood Group";
            this.bg.MinimumWidth = 6;
            this.bg.Name = "bg";
            this.bg.ReadOnly = true;
            this.bg.Width = 125;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "Gender";
            this.gender.HeaderText = "Gender";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 125;
            // 
            // mobno
            // 
            this.mobno.DataPropertyName = "Mobile No";
            this.mobno.HeaderText = "Mobile No";
            this.mobno.MinimumWidth = 6;
            this.mobno.Name = "mobno";
            this.mobno.ReadOnly = true;
            this.mobno.Width = 125;
            // 
            // stream
            // 
            this.stream.DataPropertyName = "Stream";
            this.stream.HeaderText = "Stream";
            this.stream.MinimumWidth = 6;
            this.stream.Name = "stream";
            this.stream.ReadOnly = true;
            this.stream.Width = 125;
            // 
            // _class
            // 
            this._class.DataPropertyName = "_class";
            this._class.HeaderText = "Class";
            this._class.MinimumWidth = 6;
            this._class.Name = "_class";
            this._class.ReadOnly = true;
            this._class.Width = 125;
            // 
            // rollno
            // 
            this.rollno.DataPropertyName = "Roll No";
            this.rollno.HeaderText = "Roll No";
            this.rollno.MinimumWidth = 6;
            this.rollno.Name = "rollno";
            this.rollno.ReadOnly = true;
            this.rollno.Width = 125;
            // 
            // studentSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 771);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1165, 818);
            this.MinimumSize = new System.Drawing.Size(1165, 818);
            this.Name = "studentSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Student";
            this.Load += new System.EventHandler(this.studentSearchForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn regno;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn caste;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn bg;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobno;
        private System.Windows.Forms.DataGridViewTextBoxColumn stream;
        private System.Windows.Forms.DataGridViewTextBoxColumn _class;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollno;
    }
}