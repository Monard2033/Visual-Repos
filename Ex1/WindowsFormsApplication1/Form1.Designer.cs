namespace WindowsFormsApplication1
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
            this.Check_files = new System.Windows.Forms.Button();
            this.File1 = new System.Windows.Forms.Button();
            this.File2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFile1 = new System.Windows.Forms.TextBox();
            this.textBoxFile2 = new System.Windows.Forms.TextBox();
            this.textBoxFile1Hash = new System.Windows.Forms.TextBox();
            this.textBoxFile2Hash = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Check_files
            // 
            this.Check_files.Location = new System.Drawing.Point(380, 44);
            this.Check_files.Name = "Check_files";
            this.Check_files.Size = new System.Drawing.Size(138, 171);
            this.Check_files.TabIndex = 0;
            this.Check_files.Text = "Check files";
            this.Check_files.UseVisualStyleBackColor = true;
            this.Check_files.Click += new System.EventHandler(this.Check_files_Click);
            // 
            // File1
            // 
            this.File1.Location = new System.Drawing.Point(12, 47);
            this.File1.Name = "File1";
            this.File1.Size = new System.Drawing.Size(75, 30);
            this.File1.TabIndex = 1;
            this.File1.Text = "File1";
            this.File1.UseVisualStyleBackColor = true;
            this.File1.Click += new System.EventHandler(this.File1_Click);
            // 
            // File2
            // 
            this.File2.Location = new System.Drawing.Point(12, 138);
            this.File2.Name = "File2";
            this.File2.Size = new System.Drawing.Size(75, 32);
            this.File2.TabIndex = 2;
            this.File2.Text = "File2";
            this.File2.UseVisualStyleBackColor = true;
            this.File2.Click += new System.EventHandler(this.File2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "File1 Hash";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "File2 Hash";
            // 
            // textBoxFile1
            // 
            this.textBoxFile1.Location = new System.Drawing.Point(111, 54);
            this.textBoxFile1.Name = "textBoxFile1";
            this.textBoxFile1.Size = new System.Drawing.Size(233, 20);
            this.textBoxFile1.TabIndex = 5;
            // 
            // textBoxFile2
            // 
            this.textBoxFile2.Location = new System.Drawing.Point(111, 149);
            this.textBoxFile2.Name = "textBoxFile2";
            this.textBoxFile2.Size = new System.Drawing.Size(233, 20);
            this.textBoxFile2.TabIndex = 6;
            // 
            // textBoxFile1Hash
            // 
            this.textBoxFile1Hash.Location = new System.Drawing.Point(111, 103);
            this.textBoxFile1Hash.Name = "textBoxFile1Hash";
            this.textBoxFile1Hash.Size = new System.Drawing.Size(233, 20);
            this.textBoxFile1Hash.TabIndex = 7;
            // 
            // textBoxFile2Hash
            // 
            this.textBoxFile2Hash.Location = new System.Drawing.Point(111, 195);
            this.textBoxFile2Hash.Name = "textBoxFile2Hash";
            this.textBoxFile2Hash.Size = new System.Drawing.Size(233, 20);
            this.textBoxFile2Hash.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 261);
            this.Controls.Add(this.textBoxFile2Hash);
            this.Controls.Add(this.textBoxFile1Hash);
            this.Controls.Add(this.textBoxFile2);
            this.Controls.Add(this.textBoxFile1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.File2);
            this.Controls.Add(this.File1);
            this.Controls.Add(this.Check_files);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Check_files;
        private System.Windows.Forms.Button File1;
        private System.Windows.Forms.Button File2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFile1;
        private System.Windows.Forms.TextBox textBoxFile2;
        private System.Windows.Forms.TextBox textBoxFile1Hash;
        private System.Windows.Forms.TextBox textBoxFile2Hash;
    }
}

