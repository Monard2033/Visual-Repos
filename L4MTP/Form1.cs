using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L4MTP
{
    public partial class Form1 : Form
    {
        public static string imgFolder = @"C:\Users\Student\Desktop\MTP_4\MTP_4\IMG";
        public Form1()
        {
            InitializeComponent();
        }
        private void ShowImages()
        {
            PictureBox myPicture;
            int index = 0;
            flowLayoutPanel1.Controls.Clear();
            pictureBox1.Image = null;
            txtDiagnostic.Text = "";

            foreach (DataRowView drv in radiografiiBindingSource.List)
            {
                myPicture = new PictureBox();
                myPicture.Name = "Picture" + index.ToString();
                myPicture.SetBounds(0, 0, 90, 70);
                myPicture.BackColor = Color.Black;
                myPicture.SizeMode = PictureBoxSizeMode.Zoom;
                myPicture.Image = Bitmap.FromFile(imgFolder + @"\" + drv["Imagine"]);
                myPicture.Tag = index++;
                flowLayoutPanel1.Controls.Add(myPicture);
                myPicture.Click += MyPicture_Click;
            }
        }
        private void MyPicture_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pacientiDataSet.Radiografii' table. You can move, or remove it, as needed.
            this.radiografiiTableAdapter.Fill(this.pacientiDataSet.Radiografii);
            // TODO: This line of code loads data into the 'pacientiDataSet.Pacienti' table. You can move, or remove it, as needed.
            this.pacientiTableAdapter.Fill(this.pacientiDataSet.Pacienti);

        }

        private void textBox_Cautare_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Salveaza_Click(object sender, EventArgs e)
        {

        }

        private void button_Adaugare_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
