namespace ICAE03_2018
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLeftAll = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnRightAll = new System.Windows.Forms.Button();
            this.lstFollow = new System.Windows.Forms.ListBox();
            this.lstOffer = new System.Windows.Forms.ListBox();
            this.cmbStream = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkSpeak = new System.Windows.Forms.CheckBox();
            this.chkWrite = new System.Windows.Forms.CheckBox();
            this.chkRead = new System.Windows.Forms.CheckBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.rdoFemale);
            this.groupBox1.Controls.Add(this.rdoMale);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtReg);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 374);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLeftAll);
            this.groupBox3.Controls.Add(this.btnLeft);
            this.groupBox3.Controls.Add(this.btnRight);
            this.groupBox3.Controls.Add(this.btnRightAll);
            this.groupBox3.Controls.Add(this.lstFollow);
            this.groupBox3.Controls.Add(this.lstOffer);
            this.groupBox3.Controls.Add(this.cmbStream);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(375, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(576, 308);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Educational Details";
            // 
            // btnLeftAll
            // 
            this.btnLeftAll.Location = new System.Drawing.Point(254, 242);
            this.btnLeftAll.Name = "btnLeftAll";
            this.btnLeftAll.Size = new System.Drawing.Size(67, 32);
            this.btnLeftAll.TabIndex = 9;
            this.btnLeftAll.Text = "<<";
            this.btnLeftAll.UseVisualStyleBackColor = true;
            this.btnLeftAll.Click += new System.EventHandler(this.btnLeftAll_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(254, 205);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(67, 32);
            this.btnLeft.TabIndex = 8;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(254, 168);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(67, 32);
            this.btnRight.TabIndex = 7;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnRightAll
            // 
            this.btnRightAll.Location = new System.Drawing.Point(254, 132);
            this.btnRightAll.Name = "btnRightAll";
            this.btnRightAll.Size = new System.Drawing.Size(67, 32);
            this.btnRightAll.TabIndex = 6;
            this.btnRightAll.Text = ">>";
            this.btnRightAll.UseVisualStyleBackColor = true;
            this.btnRightAll.Click += new System.EventHandler(this.btnRightAll_Click);
            // 
            // lstFollow
            // 
            this.lstFollow.FormattingEnabled = true;
            this.lstFollow.ItemHeight = 20;
            this.lstFollow.Location = new System.Drawing.Point(343, 131);
            this.lstFollow.Name = "lstFollow";
            this.lstFollow.Size = new System.Drawing.Size(218, 144);
            this.lstFollow.TabIndex = 5;
            // 
            // lstOffer
            // 
            this.lstOffer.FormattingEnabled = true;
            this.lstOffer.ItemHeight = 20;
            this.lstOffer.Location = new System.Drawing.Point(15, 131);
            this.lstOffer.Name = "lstOffer";
            this.lstOffer.Size = new System.Drawing.Size(218, 144);
            this.lstOffer.TabIndex = 4;
            // 
            // cmbStream
            // 
            this.cmbStream.FormattingEnabled = true;
            this.cmbStream.Location = new System.Drawing.Point(83, 39);
            this.cmbStream.Name = "cmbStream";
            this.cmbStream.Size = new System.Drawing.Size(150, 28);
            this.cmbStream.TabIndex = 3;
            this.cmbStream.SelectedIndexChanged += new System.EventHandler(this.cmbStream_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Subjects Followed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Subjects Offered";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Stream";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkSpeak);
            this.groupBox2.Controls.Add(this.chkWrite);
            this.groupBox2.Controls.Add(this.chkRead);
            this.groupBox2.Location = new System.Drawing.Point(19, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Language Ability (English)";
            // 
            // chkSpeak
            // 
            this.chkSpeak.AutoSize = true;
            this.chkSpeak.Location = new System.Drawing.Point(197, 45);
            this.chkSpeak.Name = "chkSpeak";
            this.chkSpeak.Size = new System.Drawing.Size(77, 24);
            this.chkSpeak.TabIndex = 2;
            this.chkSpeak.Text = "Speak";
            this.chkSpeak.UseVisualStyleBackColor = true;
            // 
            // chkWrite
            // 
            this.chkWrite.AutoSize = true;
            this.chkWrite.Location = new System.Drawing.Point(107, 45);
            this.chkWrite.Name = "chkWrite";
            this.chkWrite.Size = new System.Drawing.Size(71, 24);
            this.chkWrite.TabIndex = 1;
            this.chkWrite.Text = "Write";
            this.chkWrite.UseVisualStyleBackColor = true;
            // 
            // chkRead
            // 
            this.chkRead.AutoSize = true;
            this.chkRead.Location = new System.Drawing.Point(15, 45);
            this.chkRead.Name = "chkRead";
            this.chkRead.Size = new System.Drawing.Size(70, 24);
            this.chkRead.TabIndex = 0;
            this.chkRead.Text = "Read";
            this.chkRead.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(188, 112);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(85, 24);
            this.rdoFemale.TabIndex = 8;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            this.rdoFemale.CheckedChanged += new System.EventHandler(this.rdoFemale_CheckChanged);
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(96, 112);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(66, 24);
            this.rdoMale.TabIndex = 7;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            this.rdoMale.CheckedChanged += new System.EventHandler(this.rdoMale_CheckChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(96, 144);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(220, 77);
            this.txtAddress.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 27);
            this.txtName.TabIndex = 5;
            // 
            // txtReg
            // 
            this.txtReg.Location = new System.Drawing.Point(96, 37);
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(220, 27);
            this.txtReg.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sex:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reg No:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(420, 393);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(174, 38);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit Details";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(12, 437);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(968, 257);
            this.txtDisplay.TabIndex = 2;
            this.txtDisplay.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 706);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLeftAll;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnRightAll;
        private System.Windows.Forms.ListBox lstFollow;
        private System.Windows.Forms.ListBox lstOffer;
        private System.Windows.Forms.ComboBox cmbStream;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkSpeak;
        private System.Windows.Forms.CheckBox chkWrite;
        private System.Windows.Forms.CheckBox chkRead;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RichTextBox txtDisplay;
    }
}

