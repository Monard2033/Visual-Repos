namespace Laborator2
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
            this.comboBoxCipher = new System.Windows.Forms.ComboBox();
            this.GK = new System.Windows.Forms.Button();
            this.ENC = new System.Windows.Forms.Button();
            this.Dec = new System.Windows.Forms.Button();
            this.GET = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxIV = new System.Windows.Forms.TextBox();
            this.textBoxPlain = new System.Windows.Forms.TextBox();
            this.GDT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPlainHex = new System.Windows.Forms.TextBox();
            this.textBoxCipher = new System.Windows.Forms.TextBox();
            this.textBoxCipherHex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCipher
            // 
            this.comboBoxCipher.FormattingEnabled = true;
            this.comboBoxCipher.Items.AddRange(new object[] {
            "DES",
            "3DES",
            "Rijndael"});
            this.comboBoxCipher.Location = new System.Drawing.Point(33, 29);
            this.comboBoxCipher.Name = "comboBoxCipher";
            this.comboBoxCipher.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCipher.TabIndex = 0;
            this.comboBoxCipher.SelectedIndexChanged += new System.EventHandler(this.Generate);
            // 
            // GK
            // 
            this.GK.Location = new System.Drawing.Point(21, 78);
            this.GK.Name = "GK";
            this.GK.Size = new System.Drawing.Size(147, 23);
            this.GK.TabIndex = 1;
            this.GK.Text = "Generate Key and IV";
            this.GK.UseVisualStyleBackColor = true;
            this.GK.TextChanged += new System.EventHandler(this.buttonGen_Click);
            this.GK.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // ENC
            // 
            this.ENC.Location = new System.Drawing.Point(21, 175);
            this.ENC.Name = "ENC";
            this.ENC.Size = new System.Drawing.Size(147, 38);
            this.ENC.TabIndex = 2;
            this.ENC.Text = "Encrypt";
            this.ENC.UseVisualStyleBackColor = true;
            this.ENC.TextChanged += new System.EventHandler(this.buttonEnc_Click);
            this.ENC.Click += new System.EventHandler(this.buttonEnc_Click);
            // 
            // Dec
            // 
            this.Dec.Location = new System.Drawing.Point(21, 277);
            this.Dec.Name = "Dec";
            this.Dec.Size = new System.Drawing.Size(150, 41);
            this.Dec.TabIndex = 3;
            this.Dec.Text = "Decrypt";
            this.Dec.UseVisualStyleBackColor = true;
            this.Dec.TextChanged += new System.EventHandler(this.buttonDec_Click);
            this.Dec.Click += new System.EventHandler(this.buttonDec_Click);
            // 
            // GET
            // 
            this.GET.Location = new System.Drawing.Point(21, 371);
            this.GET.Name = "GET";
            this.GET.Size = new System.Drawing.Size(133, 32);
            this.GET.TabIndex = 4;
            this.GET.Text = "Get Encrypt Time";
            this.GET.UseVisualStyleBackColor = true;
            this.GET.TextChanged += new System.EventHandler(this.buttonEncTime_Click);
            this.GET.Click += new System.EventHandler(this.buttonEncTime_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(244, 30);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(217, 20);
            this.textBoxKey.TabIndex = 5;
            // 
            // textBoxIV
            // 
            this.textBoxIV.Location = new System.Drawing.Point(244, 81);
            this.textBoxIV.Name = "textBoxIV";
            this.textBoxIV.Size = new System.Drawing.Size(217, 20);
            this.textBoxIV.TabIndex = 6;
            // 
            // textBoxPlain
            // 
            this.textBoxPlain.Location = new System.Drawing.Point(244, 159);
            this.textBoxPlain.Name = "textBoxPlain";
            this.textBoxPlain.Size = new System.Drawing.Size(217, 20);
            this.textBoxPlain.TabIndex = 7;
            // 
            // GDT
            // 
            this.GDT.Location = new System.Drawing.Point(21, 417);
            this.GDT.Name = "GDT";
            this.GDT.Size = new System.Drawing.Size(133, 32);
            this.GDT.TabIndex = 8;
            this.GDT.Text = "Get Decrypt Time";
            this.GDT.UseVisualStyleBackColor = true;
            this.GDT.Click += new System.EventHandler(this.buttonEncTime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "IV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Plain Text";
            // 
            // textBoxPlainHex
            // 
            this.textBoxPlainHex.Location = new System.Drawing.Point(244, 193);
            this.textBoxPlainHex.Name = "textBoxPlainHex";
            this.textBoxPlainHex.Size = new System.Drawing.Size(217, 20);
            this.textBoxPlainHex.TabIndex = 12;
            // 
            // textBoxCipher
            // 
            this.textBoxCipher.Location = new System.Drawing.Point(244, 260);
            this.textBoxCipher.Name = "textBoxCipher";
            this.textBoxCipher.Size = new System.Drawing.Size(217, 20);
            this.textBoxCipher.TabIndex = 13;
            // 
            // textBoxCipherHex
            // 
            this.textBoxCipherHex.Location = new System.Drawing.Point(244, 298);
            this.textBoxCipherHex.Name = "textBoxCipherHex";
            this.textBoxCipherHex.Size = new System.Drawing.Size(217, 20);
            this.textBoxCipherHex.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cipher Text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "ASCII";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "HEX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "HEX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "ASCII";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Time/Mesage at encryption:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(241, 427);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Time/Mesage at decryption:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCipherHex);
            this.Controls.Add(this.textBoxCipher);
            this.Controls.Add(this.textBoxPlainHex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GDT);
            this.Controls.Add(this.textBoxPlain);
            this.Controls.Add(this.textBoxIV);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.GET);
            this.Controls.Add(this.Dec);
            this.Controls.Add(this.ENC);
            this.Controls.Add(this.GK);
            this.Controls.Add(this.comboBoxCipher);
            this.Name = "Form1";
            this.Text = "Windows";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCipher;
        private System.Windows.Forms.Button GK;
        private System.Windows.Forms.Button ENC;
        private System.Windows.Forms.Button Dec;
        private System.Windows.Forms.Button GET;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxIV;
        private System.Windows.Forms.TextBox textBoxPlain;
        private System.Windows.Forms.Button GDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPlainHex;
        private System.Windows.Forms.TextBox textBoxCipher;
        private System.Windows.Forms.TextBox textBoxCipherHex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

