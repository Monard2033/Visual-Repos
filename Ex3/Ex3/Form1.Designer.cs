namespace Ex3
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
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxParola1 = new System.Windows.Forms.TextBox();
            this.textBoxParola2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHash1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxHash2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonGenerare = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(37, 22);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(100, 20);
            this.textBoxK.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "k=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola1";
            // 
            // textBoxParola1
            // 
            this.textBoxParola1.Location = new System.Drawing.Point(72, 57);
            this.textBoxParola1.Name = "textBoxParola1";
            this.textBoxParola1.Size = new System.Drawing.Size(100, 20);
            this.textBoxParola1.TabIndex = 3;
            // 
            // textBoxParola2
            // 
            this.textBoxParola2.Location = new System.Drawing.Point(72, 87);
            this.textBoxParola2.Name = "textBoxParola2";
            this.textBoxParola2.Size = new System.Drawing.Size(100, 20);
            this.textBoxParola2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parola2";
            // 
            // textBoxHash1
            // 
            this.textBoxHash1.Location = new System.Drawing.Point(72, 116);
            this.textBoxHash1.Name = "textBoxHash1";
            this.textBoxHash1.Size = new System.Drawing.Size(705, 20);
            this.textBoxHash1.TabIndex = 7;
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hash1";
            // 
            // textBoxHash2
            // 
            this.textBoxHash2.Location = new System.Drawing.Point(72, 147);
            this.textBoxHash2.Name = "textBoxHash2";
            this.textBoxHash2.Size = new System.Drawing.Size(705, 20);
            this.textBoxHash2.TabIndex = 9;
            
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hash2";
            // 
            // buttonGenerare
            // 
            this.buttonGenerare.Location = new System.Drawing.Point(162, 22);
            this.buttonGenerare.Name = "buttonGenerare";
            this.buttonGenerare.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerare.TabIndex = 10;
            this.buttonGenerare.Text = "Generare";
            this.buttonGenerare.UseVisualStyleBackColor = true;
            this.buttonGenerare.Click += new System.EventHandler(this.buttonGenerare_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 304);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonGenerare);
            this.Controls.Add(this.textBoxHash2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxHash1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxParola2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxParola1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxK);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxParola1;
        private System.Windows.Forms.TextBox textBoxParola2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHash1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxHash2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonGenerare;
        private System.Windows.Forms.Label label6;
    }
}

