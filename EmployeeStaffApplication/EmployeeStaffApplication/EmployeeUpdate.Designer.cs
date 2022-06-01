namespace EmployeeStaffApplication
{
    partial class EmployeeUpdate
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
            this.btninsert = new System.Windows.Forms.Button();
            this.dateTimePickerdob = new System.Windows.Forms.DateTimePicker();
            this.emplocation = new System.Windows.Forms.ComboBox();
            this.empeducation = new System.Windows.Forms.ComboBox();
            this.emppos = new System.Windows.Forms.ComboBox();
            this.comgen = new System.Windows.Forms.ComboBox();
            this.txtempname = new System.Windows.Forms.TextBox();
            this.empaddress = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.numempid = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numempid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(758, 359);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(168, 85);
            this.btninsert.TabIndex = 28;
            this.btninsert.Text = "UPDATE";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // dateTimePickerdob
            // 
            this.dateTimePickerdob.Location = new System.Drawing.Point(257, 312);
            this.dateTimePickerdob.Name = "dateTimePickerdob";
            this.dateTimePickerdob.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerdob.TabIndex = 27;
            // 
            // emplocation
            // 
            this.emplocation.FormattingEnabled = true;
            this.emplocation.Items.AddRange(new object[] {
            "Mumbai",
            "Pune",
            "Chennai",
            "Banglore",
            "Hyderabad",
            "GuruGav"});
            this.emplocation.Location = new System.Drawing.Point(638, 312);
            this.emplocation.Name = "emplocation";
            this.emplocation.Size = new System.Drawing.Size(121, 24);
            this.emplocation.TabIndex = 26;
            // 
            // empeducation
            // 
            this.empeducation.FormattingEnabled = true;
            this.empeducation.Items.AddRange(new object[] {
            "BTech /BE",
            "MTech",
            "BCA",
            "MCA",
            "BCOM",
            "MCOM"});
            this.empeducation.Location = new System.Drawing.Point(95, 312);
            this.empeducation.Name = "empeducation";
            this.empeducation.Size = new System.Drawing.Size(121, 24);
            this.empeducation.TabIndex = 25;
            // 
            // emppos
            // 
            this.emppos.FormattingEnabled = true;
            this.emppos.Items.AddRange(new object[] {
            "Senior Developer",
            "Junior Developer",
            "Associative Developer",
            "Tainnee",
            "Manager",
            "SystemSupervisior"});
            this.emppos.Location = new System.Drawing.Point(469, 210);
            this.emppos.Name = "emppos";
            this.emppos.Size = new System.Drawing.Size(121, 24);
            this.emppos.TabIndex = 24;
            // 
            // comgen
            // 
            this.comgen.FormattingEnabled = true;
            this.comgen.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comgen.Location = new System.Drawing.Point(342, 210);
            this.comgen.Name = "comgen";
            this.comgen.Size = new System.Drawing.Size(121, 24);
            this.comgen.TabIndex = 23;
            // 
            // txtempname
            // 
            this.txtempname.Location = new System.Drawing.Point(120, 210);
            this.txtempname.Name = "txtempname";
            this.txtempname.Size = new System.Drawing.Size(100, 22);
            this.txtempname.TabIndex = 21;
            // 
            // empaddress
            // 
            this.empaddress.Location = new System.Drawing.Point(496, 312);
            this.empaddress.Name = "empaddress";
            this.empaddress.Size = new System.Drawing.Size(100, 22);
            this.empaddress.TabIndex = 20;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(236, 209);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(100, 22);
            this.txtphone.TabIndex = 22;
            // 
            // numempid
            // 
            this.numempid.Location = new System.Drawing.Point(149, 93);
            this.numempid.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numempid.Name = "numempid";
            this.numempid.Size = new System.Drawing.Size(120, 22);
            this.numempid.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(654, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "EmpLocation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(502, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "EmpAddress";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "EmpDob";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "EmpEducation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "EmpPosition";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "EmpGender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "EmpPhone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "EmpName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "EmpID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(208, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(315, 32);
            this.label11.TabIndex = 30;
            this.label11.Text = "Update Employee Details";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(-287, -174);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 508);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.dateTimePickerdob);
            this.Controls.Add(this.emplocation);
            this.Controls.Add(this.empeducation);
            this.Controls.Add(this.emppos);
            this.Controls.Add(this.comgen);
            this.Controls.Add(this.txtempname);
            this.Controls.Add(this.empaddress);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.numempid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeUpdate";
            this.Load += new System.EventHandler(this.EmployeeUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numempid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.DateTimePicker dateTimePickerdob;
        private System.Windows.Forms.ComboBox emplocation;
        private System.Windows.Forms.ComboBox empeducation;
        private System.Windows.Forms.ComboBox emppos;
        private System.Windows.Forms.ComboBox comgen;
        private System.Windows.Forms.TextBox txtempname;
        private System.Windows.Forms.TextBox empaddress;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.NumericUpDown numempid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
    }
}