using System;
using System.Data;
using System.Drawing;
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


            foreach (DataRowView drv in radiografiiBindingSource.List)
            {
                myPicture = new PictureBox
                {
                    Name = "Picture" + index.ToString()
                };
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
            ShowImages();
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

            this.Validate();
            this.pacientiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pacientiDataSet);
        }

        private void buttonAdaugare_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(((DataRowView)pacientiBindingSource.Current)["CNP"].ToString());

            if (f.ShowDialog() == DialogResult.OK)
            {
                radiografiiTableAdapter.Insert(f.CNP, f.Imagine, f.Data, f.Diagnostic, f.Comentarii);
                tableAdapterManager.UpdateAll(this.pacientiDataSet);
                radiografiiTableAdapter.Fill(pacientiDataSet.Radiografii);
                ShowImages();
            }
        }

        private void pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pictureBox1.Image = pic.Image;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            if (pacientiBindingSource.SupportsSearching != true)
            {
                MessageBox.Show("Cannot search the list.");
            }
            else
            {
                int foundIndex = pacientiBindingSource.Find("Nume", txtCautare.Text);
                if (foundIndex > -1)
                {
                    //SqlConnection sc = new SqlConnection("Data Source=localhost; Initial Catalog=LoginScreen;Integreted Security=True");
                    //SqlCommand com = new SqlCommand();
                    //com.Connection = sc;
                    //sc.Open();
                    //SqlDataReader read = (null);
                    //com.CommandText = ("select * from Pacienti");
                    ////read = com.ExecuteReader();
                    //txtDetalii.Text = (read["CNP"].ToString());

                    txtDetalii.Text = "Data: 18 iulie 2002 \n Diagnostic TBC \n Comentarii este bine, isi revine\n";
                    pacientiDataGridView.TabIndex = foundIndex;
                }
                else
                {
                    MessageBox.Show("Font was not found.");
                }
            }
            txtDetalii.Text = "Data: 18 iulie 2002 \n Diagnostic TBC \n Comentarii este bine, isi revine\n";
        }
    }
}
