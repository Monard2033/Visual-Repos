using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4_Iulian
{
    public partial class Form1 : Form
    {
        public static string imgFolder = @"C:\Users\Student\Desktop\MTP_4\MTP_4\IMG";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.pacientiTableAdapter.Fill(this.pacienti_IULIDataSet.Pacienti);

        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            
                this.Validate();
                this.pacientiBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.pacienti_IULIDataSet  );

            }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(((DataRowView)pacientiBindingSource.Current)["CNP"].ToString());

            if (f.ShowDialog() == DialogResult.OK)
            {
                radiografiiTableAdapter.Insert(f.CNP, f.Imagine, f.Data, f.Diagnostic, f.Comentarii);
                tableAdapterManager.UpdateAll(this.pacienti_IULIDataSet);
                radiografiiTableAdapter.Fill(pacienti_IULIDataSet.Radiografii);
                ShowImages();
            }

        }
        private void ShowImages()
        {
            PictureBox myPicture;
            int index = 0;
            flowLayoutPanel1.Controls.Clear();
            pictureBox1.Image = null;
            txtDetalii.Text = "";

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
                myPicture.Click += pic_Click;
            }
        }
        void pic_Click(object sender, EventArgs e)
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
                    SqlConnection sc = new SqlConnection("Data Source=localhost; Initial Catalog=LoginScreen;Integreted Security=True");
                    SqlCommand com = new SqlCommand();
                    com.Connection = sc;
                    sc.Open();
                    SqlDataReader read = (null);
                    com.CommandText = ("select * from Pacienti");
                    read = com.ExecuteReader();
                    txtDetalii.Text = (read["CNP"].ToString());
             
                    txtDetalii.Text = "Data: 18 iulie 2002 \n Diagnostic TBC \n Comentarii este bine, isi revine\n";
                    dataGridView1.TabIndex = foundIndex;
                }
                else
                    MessageBox.Show("Font was not found.");
            }
            txtDetalii.Text = "Data: 18 iulie 2002 \n Diagnostic TBC \n Comentarii este bine, isi revine\n";
        }

        private void pacientiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowImages();
        }
    }
}
