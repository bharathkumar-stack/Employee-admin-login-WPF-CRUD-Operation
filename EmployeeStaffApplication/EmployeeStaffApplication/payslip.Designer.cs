namespace EmployeeStaffApplication
{
    partial class numslip
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
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numpayslip = new System.Windows.Forms.NumericUpDown();
            this.numworkinddays = new System.Windows.Forms.NumericUpDown();
            this.numempworkindays = new System.Windows.Forms.NumericUpDown();
            this.numpffund = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numpayslip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numworkinddays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numempworkindays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpffund)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payslip Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total woking Days";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "ProvidentFund";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Employee Working Days";
            // 
            // numpayslip
            // 
            this.numpayslip.Location = new System.Drawing.Point(52, 100);
            this.numpayslip.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numpayslip.Name = "numpayslip";
            this.numpayslip.Size = new System.Drawing.Size(120, 22);
            this.numpayslip.TabIndex = 1;
            // 
            // numworkinddays
            // 
            this.numworkinddays.Location = new System.Drawing.Point(199, 100);
            this.numworkinddays.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numworkinddays.Name = "numworkinddays";
            this.numworkinddays.Size = new System.Drawing.Size(120, 22);
            this.numworkinddays.TabIndex = 1;
            // 
            // numempworkindays
            // 
            this.numempworkindays.Location = new System.Drawing.Point(382, 100);
            this.numempworkindays.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numempworkindays.Name = "numempworkindays";
            this.numempworkindays.Size = new System.Drawing.Size(120, 22);
            this.numempworkindays.TabIndex = 1;
            // 
            // numpffund
            // 
            this.numpffund.Location = new System.Drawing.Point(585, 100);
            this.numpffund.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numpffund.Name = "numpffund";
            this.numpffund.Size = new System.Drawing.Size(120, 22);
            this.numpffund.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Genereate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numslip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numempworkindays);
            this.Controls.Add(this.numpffund);
            this.Controls.Add(this.numworkinddays);
            this.Controls.Add(this.numpayslip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "numslip";
            this.Text = "payslip";
            this.Load += new System.EventHandler(this.payslip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numpayslip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numworkinddays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numempworkindays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpffund)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numpayslip;
        private System.Windows.Forms.NumericUpDown numworkinddays;
        private System.Windows.Forms.NumericUpDown numempworkindays;
        private System.Windows.Forms.NumericUpDown numpffund;
        private System.Windows.Forms.Button button1;
    }
}