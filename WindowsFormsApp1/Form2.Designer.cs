namespace WindowsFormsApp1
{
    partial class addStudentForm
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.addressInp = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.newClassInp = new System.Windows.Forms.Button();
            this.newStreamInp = new System.Windows.Forms.Button();
            this.rollInp = new System.Windows.Forms.TextBox();
            this.divisionInp = new System.Windows.Forms.ComboBox();
            this.classInp = new System.Windows.Forms.ComboBox();
            this.streamInp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mobileNoInp = new System.Windows.Forms.TextBox();
            this.genderInp = new System.Windows.Forms.ComboBox();
            this.bloodGroupInp = new System.Windows.Forms.ComboBox();
            this.dobInp = new System.Windows.Forms.DateTimePicker();
            this.newCasteInp = new System.Windows.Forms.Button();
            this.casteInp = new System.Windows.Forms.ComboBox();
            this.surnameInp = new System.Windows.Forms.TextBox();
            this.fnameInp = new System.Windows.Forms.TextBox();
            this.lnameInp = new System.Windows.Forms.TextBox();
            this.regNoInp = new System.Windows.Forms.TextBox();
            this.bloodGroupLbl = new System.Windows.Forms.Label();
            this.genderLbl = new System.Windows.Forms.Label();
            this.mobileNoLbl = new System.Windows.Forms.Label();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.fnameLbl = new System.Windows.Forms.Label();
            this.lnameLbl = new System.Windows.Forms.Label();
            this.casteLbl = new System.Windows.Forms.Label();
            this.dobLbl = new System.Windows.Forms.Label();
            this.regNoLbl = new System.Windows.Forms.Label();
            this.searchLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 100);
            this.panel1.TabIndex = 0;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(512, 22);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(443, 55);
            this.title.TabIndex = 0;
            this.title.Text = "Add/Modify Student";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cancelBtn);
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.modifyBtn);
            this.panel2.Controls.Add(this.saveBtn);
            this.panel2.Location = new System.Drawing.Point(13, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 889);
            this.panel2.TabIndex = 1;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(23, 351);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(152, 49);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(23, 247);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(152, 49);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyBtn.Location = new System.Drawing.Point(23, 154);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(152, 49);
            this.modifyBtn.TabIndex = 1;
            this.modifyBtn.Text = "Modify";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(23, 69);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(152, 49);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.addressInp);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.mobileNoInp);
            this.panel3.Controls.Add(this.genderInp);
            this.panel3.Controls.Add(this.bloodGroupInp);
            this.panel3.Controls.Add(this.dobInp);
            this.panel3.Controls.Add(this.newCasteInp);
            this.panel3.Controls.Add(this.casteInp);
            this.panel3.Controls.Add(this.surnameInp);
            this.panel3.Controls.Add(this.fnameInp);
            this.panel3.Controls.Add(this.lnameInp);
            this.panel3.Controls.Add(this.regNoInp);
            this.panel3.Controls.Add(this.bloodGroupLbl);
            this.panel3.Controls.Add(this.genderLbl);
            this.panel3.Controls.Add(this.mobileNoLbl);
            this.panel3.Controls.Add(this.surnameLbl);
            this.panel3.Controls.Add(this.fnameLbl);
            this.panel3.Controls.Add(this.lnameLbl);
            this.panel3.Controls.Add(this.casteLbl);
            this.panel3.Controls.Add(this.dobLbl);
            this.panel3.Controls.Add(this.regNoLbl);
            this.panel3.Controls.Add(this.searchLbl);
            this.panel3.Location = new System.Drawing.Point(234, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1136, 724);
            this.panel3.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(184, 627);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Address";
            // 
            // addressInp
            // 
            this.addressInp.Location = new System.Drawing.Point(286, 608);
            this.addressInp.Name = "addressInp";
            this.addressInp.Size = new System.Drawing.Size(413, 64);
            this.addressInp.TabIndex = 22;
            this.addressInp.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.newClassInp);
            this.groupBox2.Controls.Add(this.newStreamInp);
            this.groupBox2.Controls.Add(this.rollInp);
            this.groupBox2.Controls.Add(this.divisionInp);
            this.groupBox2.Controls.Add(this.classInp);
            this.groupBox2.Controls.Add(this.streamInp);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(734, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 228);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Class Details";
            // 
            // newClassInp
            // 
            this.newClassInp.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.add;
            this.newClassInp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.newClassInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newClassInp.Location = new System.Drawing.Point(273, 94);
            this.newClassInp.Name = "newClassInp";
            this.newClassInp.Size = new System.Drawing.Size(31, 27);
            this.newClassInp.TabIndex = 24;
            this.newClassInp.UseVisualStyleBackColor = true;
            // 
            // newStreamInp
            // 
            this.newStreamInp.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.add;
            this.newStreamInp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.newStreamInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newStreamInp.Location = new System.Drawing.Point(273, 43);
            this.newStreamInp.Name = "newStreamInp";
            this.newStreamInp.Size = new System.Drawing.Size(31, 27);
            this.newStreamInp.TabIndex = 22;
            this.newStreamInp.UseVisualStyleBackColor = true;
            // 
            // rollInp
            // 
            this.rollInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollInp.Location = new System.Drawing.Point(128, 183);
            this.rollInp.Name = "rollInp";
            this.rollInp.Size = new System.Drawing.Size(139, 27);
            this.rollInp.TabIndex = 7;
            this.rollInp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rollInp_KeyDown);
            // 
            // divisionInp
            // 
            this.divisionInp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.divisionInp.FormattingEnabled = true;
            this.divisionInp.Items.AddRange(new object[] {
            "Division 1",
            "Division 2"});
            this.divisionInp.Location = new System.Drawing.Point(128, 132);
            this.divisionInp.Name = "divisionInp";
            this.divisionInp.Size = new System.Drawing.Size(139, 28);
            this.divisionInp.TabIndex = 6;
            this.divisionInp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.divisionInp_KeyDown);
            // 
            // classInp
            // 
            this.classInp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classInp.FormattingEnabled = true;
            this.classInp.Items.AddRange(new object[] {
            "Class1",
            "Class2"});
            this.classInp.Location = new System.Drawing.Point(128, 86);
            this.classInp.Name = "classInp";
            this.classInp.Size = new System.Drawing.Size(139, 28);
            this.classInp.TabIndex = 5;
            this.classInp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.classInp_KeyDown);
            // 
            // streamInp
            // 
            this.streamInp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.streamInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streamInp.FormattingEnabled = true;
            this.streamInp.Items.AddRange(new object[] {
            "CSE",
            "ENTC",
            "IT",
            "Mechanical",
            "Chemical",
            "Civil"});
            this.streamInp.Location = new System.Drawing.Point(128, 42);
            this.streamInp.Name = "streamInp";
            this.streamInp.Size = new System.Drawing.Size(139, 28);
            this.streamInp.TabIndex = 4;
            this.streamInp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.streamInp_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(21, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(21, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Division";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(21, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Roll No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stream";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(780, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 214);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Photo Selection";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.add;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(115, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 49);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 186);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mobileNoInp
            // 
            this.mobileNoInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileNoInp.Location = new System.Drawing.Point(184, 525);
            this.mobileNoInp.Name = "mobileNoInp";
            this.mobileNoInp.Size = new System.Drawing.Size(241, 27);
            this.mobileNoInp.TabIndex = 19;
            this.mobileNoInp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mobileNoInp_KeyDown);
            // 
            // genderInp
            // 
            this.genderInp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderInp.FormattingEnabled = true;
            this.genderInp.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.genderInp.Location = new System.Drawing.Point(184, 465);
            this.genderInp.Name = "genderInp";
            this.genderInp.Size = new System.Drawing.Size(115, 28);
            this.genderInp.TabIndex = 18;
            this.genderInp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.genderInp_KeyDown);
            // 
            // bloodGroupInp
            // 
            this.bloodGroupInp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bloodGroupInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodGroupInp.FormattingEnabled = true;
            this.bloodGroupInp.Items.AddRange(new object[] {
            "A+",
            "B+",
            "AB+",
            "O+",
            "A-",
            "B-",
            "AB-",
            "O-"});
            this.bloodGroupInp.Location = new System.Drawing.Point(185, 411);
            this.bloodGroupInp.Name = "bloodGroupInp";
            this.bloodGroupInp.Size = new System.Drawing.Size(114, 28);
            this.bloodGroupInp.TabIndex = 17;
            this.bloodGroupInp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bloodGroupInp_KeyDown);
            // 
            // dobInp
            // 
            this.dobInp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobInp.CustomFormat = "yyyy/MM/dd";
            this.dobInp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobInp.Location = new System.Drawing.Point(185, 353);
            this.dobInp.Name = "dobInp";
            this.dobInp.Size = new System.Drawing.Size(114, 22);
            this.dobInp.TabIndex = 16;
            this.dobInp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dobInp_KeyDown);
            // 
            // newCasteInp
            // 
            this.newCasteInp.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.add;
            this.newCasteInp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.newCasteInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCasteInp.Location = new System.Drawing.Point(394, 304);
            this.newCasteInp.Name = "newCasteInp";
            this.newCasteInp.Size = new System.Drawing.Size(31, 27);
            this.newCasteInp.TabIndex = 15;
            this.newCasteInp.UseVisualStyleBackColor = true;
            // 
            // casteInp
            // 
            this.casteInp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.casteInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casteInp.FormattingEnabled = true;
            this.casteInp.Items.AddRange(new object[] {
            "Open",
            "OBC",
            "SB",
            "SBC",
            "NT"});
            this.casteInp.Location = new System.Drawing.Point(185, 303);
            this.casteInp.Name = "casteInp";
            this.casteInp.Size = new System.Drawing.Size(190, 28);
            this.casteInp.TabIndex = 14;
            this.casteInp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.casteInp_KeyDown);
            // 
            // surnameInp
            // 
            this.surnameInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameInp.Location = new System.Drawing.Point(184, 140);
            this.surnameInp.Name = "surnameInp";
            this.surnameInp.Size = new System.Drawing.Size(241, 27);
            this.surnameInp.TabIndex = 13;
            this.surnameInp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.surnameInp_KeyDown);
            // 
            // fnameInp
            // 
            this.fnameInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameInp.Location = new System.Drawing.Point(184, 190);
            this.fnameInp.Name = "fnameInp";
            this.fnameInp.Size = new System.Drawing.Size(241, 27);
            this.fnameInp.TabIndex = 12;
            this.fnameInp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fnameInp_KeyDown);
            // 
            // lnameInp
            // 
            this.lnameInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameInp.Location = new System.Drawing.Point(184, 245);
            this.lnameInp.Name = "lnameInp";
            this.lnameInp.Size = new System.Drawing.Size(241, 27);
            this.lnameInp.TabIndex = 11;
            this.lnameInp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lnameInp_KeyDown);
            // 
            // regNoInp
            // 
            this.regNoInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regNoInp.Location = new System.Drawing.Point(185, 88);
            this.regNoInp.Name = "regNoInp";
            this.regNoInp.Size = new System.Drawing.Size(240, 27);
            this.regNoInp.TabIndex = 10;
            this.regNoInp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.regNoInp_KeyDown);
            // 
            // bloodGroupLbl
            // 
            this.bloodGroupLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodGroupLbl.Location = new System.Drawing.Point(28, 411);
            this.bloodGroupLbl.Name = "bloodGroupLbl";
            this.bloodGroupLbl.Size = new System.Drawing.Size(150, 25);
            this.bloodGroupLbl.TabIndex = 9;
            this.bloodGroupLbl.Text = "Blood Group";
            this.bloodGroupLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genderLbl
            // 
            this.genderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLbl.Location = new System.Drawing.Point(28, 465);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(150, 25);
            this.genderLbl.TabIndex = 8;
            this.genderLbl.Text = "Gender";
            this.genderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mobileNoLbl
            // 
            this.mobileNoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileNoLbl.Location = new System.Drawing.Point(28, 525);
            this.mobileNoLbl.Name = "mobileNoLbl";
            this.mobileNoLbl.Size = new System.Drawing.Size(150, 25);
            this.mobileNoLbl.TabIndex = 7;
            this.mobileNoLbl.Text = "Mobile No.";
            this.mobileNoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // surnameLbl
            // 
            this.surnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameLbl.Location = new System.Drawing.Point(28, 137);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(150, 25);
            this.surnameLbl.TabIndex = 6;
            this.surnameLbl.Text = "Surname *";
            this.surnameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fnameLbl
            // 
            this.fnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameLbl.Location = new System.Drawing.Point(28, 187);
            this.fnameLbl.Name = "fnameLbl";
            this.fnameLbl.Size = new System.Drawing.Size(150, 25);
            this.fnameLbl.TabIndex = 5;
            this.fnameLbl.Text = "First Name *";
            this.fnameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnameLbl
            // 
            this.lnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameLbl.Location = new System.Drawing.Point(28, 230);
            this.lnameLbl.Name = "lnameLbl";
            this.lnameLbl.Size = new System.Drawing.Size(150, 50);
            this.lnameLbl.TabIndex = 4;
            this.lnameLbl.Text = "Last / Father\'s Name";
            this.lnameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // casteLbl
            // 
            this.casteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casteLbl.Location = new System.Drawing.Point(28, 303);
            this.casteLbl.Name = "casteLbl";
            this.casteLbl.Size = new System.Drawing.Size(150, 25);
            this.casteLbl.TabIndex = 3;
            this.casteLbl.Text = "Caste";
            this.casteLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dobLbl
            // 
            this.dobLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLbl.Location = new System.Drawing.Point(28, 351);
            this.dobLbl.Name = "dobLbl";
            this.dobLbl.Size = new System.Drawing.Size(150, 25);
            this.dobLbl.TabIndex = 2;
            this.dobLbl.Text = "Date of Birth";
            this.dobLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // regNoLbl
            // 
            this.regNoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regNoLbl.Location = new System.Drawing.Point(28, 86);
            this.regNoLbl.Name = "regNoLbl";
            this.regNoLbl.Size = new System.Drawing.Size(150, 25);
            this.regNoLbl.TabIndex = 1;
            this.regNoLbl.Text = "Reg. No";
            this.regNoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.searchLbl.Location = new System.Drawing.Point(71, 18);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(193, 25);
            this.searchLbl.TabIndex = 0;
            this.searchLbl.Text = "Press F4 to search";
            // 
            // addStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 903);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1400, 950);
            this.MinimumSize = new System.Drawing.Size(1400, 950);
            this.Name = "addStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information";
            this.Activated += new System.EventHandler(this.addStudentForm_Activated);
            this.Load += new System.EventHandler(this.addStudentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label bloodGroupLbl;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.Label mobileNoLbl;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.Label fnameLbl;
        private System.Windows.Forms.Label lnameLbl;
        private System.Windows.Forms.Label casteLbl;
        private System.Windows.Forms.Label dobLbl;
        private System.Windows.Forms.Label regNoLbl;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.ComboBox casteInp;
        private System.Windows.Forms.TextBox surnameInp;
        private System.Windows.Forms.TextBox fnameInp;
        private System.Windows.Forms.TextBox lnameInp;
        private System.Windows.Forms.TextBox regNoInp;
        private System.Windows.Forms.Button newCasteInp;
        private System.Windows.Forms.DateTimePicker dobInp;
        private System.Windows.Forms.RichTextBox addressInp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button newClassInp;
        private System.Windows.Forms.Button newStreamInp;
        private System.Windows.Forms.TextBox rollInp;
        private System.Windows.Forms.ComboBox divisionInp;
        private System.Windows.Forms.ComboBox classInp;
        private System.Windows.Forms.ComboBox streamInp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox mobileNoInp;
        private System.Windows.Forms.ComboBox genderInp;
        private System.Windows.Forms.ComboBox bloodGroupInp;
        private System.Windows.Forms.Label label5;
    }
}