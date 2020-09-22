namespace PDFEncryption
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lnkPDF = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdoForbid = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkModifyAnnotations = new System.Windows.Forms.CheckBox();
            this.chkCopy = new System.Windows.Forms.CheckBox();
            this.chkModifyContent = new System.Windows.Forms.CheckBox();
            this.chkPrint = new System.Windows.Forms.CheckBox();
            this.chkAssembly = new System.Windows.Forms.CheckBox();
            this.chkScreenReaders = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encrypt PDF Files and Set Privileges using Aspose.PDF";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtLicense);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 63);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Load License File";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLicense
            // 
            this.txtLicense.Location = new System.Drawing.Point(17, 26);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(348, 23);
            this.txtLicense.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lnkPDF);
            this.groupBox2.Location = new System.Drawing.Point(12, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 49);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // lnkPDF
            // 
            this.lnkPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkPDF.AutoSize = true;
            this.lnkPDF.Location = new System.Drawing.Point(6, 19);
            this.lnkPDF.Name = "lnkPDF";
            this.lnkPDF.Size = new System.Drawing.Size(151, 15);
            this.lnkPDF.TabIndex = 0;
            this.lnkPDF.TabStop = true;
            this.lnkPDF.Text = "Select a PDF File To Encrypt";
            this.lnkPDF.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Encrypt PDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtOwner);
            this.groupBox3.Controls.Add(this.txtUser);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(452, 194);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Specify Privileges and Passwords";
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(6, 127);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(440, 23);
            this.txtOwner.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(6, 62);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(440, 23);
            this.txtUser.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Owner Password: (Leave blank if do not want to set)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Password: (Leave blank if do not want to set)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Controls.Add(this.rdoForbid);
            this.groupBox4.Location = new System.Drawing.Point(12, 364);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(451, 45);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(228, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(133, 19);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "Allow All with Below";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdoForbid
            // 
            this.rdoForbid.AutoSize = true;
            this.rdoForbid.Checked = true;
            this.rdoForbid.Location = new System.Drawing.Point(85, 16);
            this.rdoForbid.Name = "rdoForbid";
            this.rdoForbid.Size = new System.Drawing.Size(137, 19);
            this.rdoForbid.TabIndex = 0;
            this.rdoForbid.TabStop = true;
            this.rdoForbid.Text = "Forbid All with Below";
            this.rdoForbid.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkModifyAnnotations);
            this.groupBox5.Controls.Add(this.chkCopy);
            this.groupBox5.Controls.Add(this.chkModifyContent);
            this.groupBox5.Controls.Add(this.chkPrint);
            this.groupBox5.Controls.Add(this.chkAssembly);
            this.groupBox5.Controls.Add(this.chkScreenReaders);
            this.groupBox5.Location = new System.Drawing.Point(12, 415);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(451, 76);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // chkModifyAnnotations
            // 
            this.chkModifyAnnotations.AutoSize = true;
            this.chkModifyAnnotations.Location = new System.Drawing.Point(16, 44);
            this.chkModifyAnnotations.Name = "chkModifyAnnotations";
            this.chkModifyAnnotations.Size = new System.Drawing.Size(132, 19);
            this.chkModifyAnnotations.TabIndex = 5;
            this.chkModifyAnnotations.Text = "Modify Annotations";
            this.chkModifyAnnotations.UseVisualStyleBackColor = true;
            // 
            // chkCopy
            // 
            this.chkCopy.AutoSize = true;
            this.chkCopy.Location = new System.Drawing.Point(344, 22);
            this.chkCopy.Name = "chkCopy";
            this.chkCopy.Size = new System.Drawing.Size(54, 19);
            this.chkCopy.TabIndex = 4;
            this.chkCopy.Text = "Copy";
            this.chkCopy.UseVisualStyleBackColor = true;
            // 
            // chkModifyContent
            // 
            this.chkModifyContent.AutoSize = true;
            this.chkModifyContent.Location = new System.Drawing.Point(170, 44);
            this.chkModifyContent.Name = "chkModifyContent";
            this.chkModifyContent.Size = new System.Drawing.Size(110, 19);
            this.chkModifyContent.TabIndex = 3;
            this.chkModifyContent.Text = "Modify Content";
            this.chkModifyContent.UseVisualStyleBackColor = true;
            // 
            // chkPrint
            // 
            this.chkPrint.AutoSize = true;
            this.chkPrint.Location = new System.Drawing.Point(344, 44);
            this.chkPrint.Name = "chkPrint";
            this.chkPrint.Size = new System.Drawing.Size(51, 19);
            this.chkPrint.TabIndex = 2;
            this.chkPrint.Text = "Print";
            this.chkPrint.UseVisualStyleBackColor = true;
            // 
            // chkAssembly
            // 
            this.chkAssembly.AutoSize = true;
            this.chkAssembly.Location = new System.Drawing.Point(170, 22);
            this.chkAssembly.Name = "chkAssembly";
            this.chkAssembly.Size = new System.Drawing.Size(77, 19);
            this.chkAssembly.TabIndex = 1;
            this.chkAssembly.Text = "Assembly";
            this.chkAssembly.UseVisualStyleBackColor = true;
            // 
            // chkScreenReaders
            // 
            this.chkScreenReaders.AutoSize = true;
            this.chkScreenReaders.Location = new System.Drawing.Point(16, 22);
            this.chkScreenReaders.Name = "chkScreenReaders";
            this.chkScreenReaders.Size = new System.Drawing.Size(105, 19);
            this.chkScreenReaders.TabIndex = 0;
            this.chkScreenReaders.Text = "Screen Readers";
            this.chkScreenReaders.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 530);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encrypt PDF Files and Set Privileges using Aspose.PDF";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel lnkPDF;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdoForbid;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkCopy;
        private System.Windows.Forms.CheckBox chkModifyContent;
        private System.Windows.Forms.CheckBox chkPrint;
        private System.Windows.Forms.CheckBox chkAssembly;
        private System.Windows.Forms.CheckBox chkScreenReaders;
        private System.Windows.Forms.CheckBox chkModifyAnnotations;
    }
}

