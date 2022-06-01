namespace EmployeeStaffApplication
{
    partial class EmployeeInsert
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numempid = new System.Windows.Forms.NumericUpDown();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtempname = new System.Windows.Forms.TextBox();
            this.comgen = new System.Windows.Forms.ComboBox();
            this.emppos = new System.Windows.Forms.ComboBox();
            this.empeducation = new System.Windows.Forms.ComboBox();
            this.dateTimePickerdob = new System.Windows.Forms.DateTimePicker();
            this.empaddress = new System.Windows.Forms.TextBox();
            this.emplocation = new System.Windows.Forms.ComboBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numempid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "EmpID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "EmpName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "EmpPhone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "EmpGender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "EmpPosition";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "EmpEducation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "EmpDob";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "EmpAddress";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(628, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "EmpLocation";
            // 
            // numempid
            // 
            this.numempid.Location = new System.Drawing.Point(82, 93);
            this.numempid.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numempid.Name = "numempid";
            this.numempid.Size = new System.Drawing.Size(120, 22);
            this.numempid.TabIndex = 2;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(364, 92);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(100, 22);
            this.txtphone.TabIndex = 3;
            // 
            // txtempname
            // 
            this.txtempname.Location = new System.Drawing.Point(248, 93);
            this.txtempname.Name = "txtempname";
            this.txtempname.Size = new System.Drawing.Size(100, 22);
            this.txtempname.TabIndex = 3;
            // 
            // comgen
            // 
            this.comgen.FormattingEnabled = true;
            this.comgen.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comgen.Location = new System.Drawing.Point(470, 93);
            this.comgen.Name = "comgen";
            this.comgen.Size = new System.Drawing.Size(121, 24);
            this.comgen.TabIndex = 4;
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
            this.emppos.Location = new System.Drawing.Point(597, 93);
            this.emppos.Name = "emppos";
            this.emppos.Size = new System.Drawing.Size(121, 24);
            this.emppos.TabIndex = 4;
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
            this.empeducation.Location = new System.Drawing.Point(69, 235);
            this.empeducation.Name = "empeducation";
            this.empeducation.Size = new System.Drawing.Size(121, 24);
            this.empeducation.TabIndex = 4;
            // 
            // dateTimePickerdob
            // 
            this.dateTimePickerdob.Location = new System.Drawing.Point(231, 235);
            this.dateTimePickerdob.Name = "dateTimePickerdob";
            this.dateTimePickerdob.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerdob.TabIndex = 5;
            // 
            // empaddress
            // 
            this.empaddress.Location = new System.Drawing.Point(470, 235);
            this.empaddress.Name = "empaddress";
            this.empaddress.Size = new System.Drawing.Size(100, 22);
            this.empaddress.TabIndex = 3;
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
            this.emplocation.Location = new System.Drawing.Point(612, 235);
            this.emplocation.Name = "emplocation";
            this.emplocation.Size = new System.Drawing.Size(121, 24);
            this.emplocation.TabIndex = 4;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(631, 313);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 7;
            this.btninsert.Text = "INSERT";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "EMPPASS";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(82, 343);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(100, 22);
            this.txtpass.TabIndex = 8;
            // 
            // EmployeeInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.dateTimePickerdob);
            this.Controls.Add(this.emplocation);
            this.Controls.Add(this.empeducation);
            this.Controls.Add(this.emppos);
            this.Controls.Add(this.comgen);
            this.Controls.Add(this.txtempname);
            this.Controls.Add(this.empaddress);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.numempid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeInsert";
            this.Text = "EmployeeInsert";
            this.Load += new System.EventHandler(this.EmployeeInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numempid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numempid;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtempname;
        private System.Windows.Forms.ComboBox comgen;
        private System.Windows.Forms.ComboBox emppos;
        private System.Windows.Forms.ComboBox empeducation;
        private System.Windows.Forms.DateTimePicker dateTimePickerdob;
        private System.Windows.Forms.TextBox empaddress;
        private System.Windows.Forms.ComboBox emplocation;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtpass;
    }
}