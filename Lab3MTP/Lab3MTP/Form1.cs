using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3MTP
{
    public partial class Form1 : Form
    {
        string echipa_noua;
        public static string nume_echipa_selectata;
        public Form1()
        {
        InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonEchipa_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            comboBox1.Items.Add(Form2.nume_nou);
        }

        private void buttonJucator_Click(object sender, EventArgs e)
        {
            nume_echipa_selectata = comboBox1.Text;
            Form3 f3 = new Form3();
            f3.ShowDialog();
            Button btn = new Button();
            btn.Text = Form3.fotbalist_nou.Nume;
            btn.Width = 200;
            btn.Tag = Form3.fotbalist_nou; // se atribuie un obiect de tip Jucator
            flowLayoutPanel1.Controls.Add(btn);
            btn.Click += Btn_Click;
        }
        void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Jucator j = (Jucator)btn.Tag;
            textBox1.Text = j.Nume;
            comboBox2.SelectedItem = j.Post;
            textBox3.Text = j.cnp;
            dateTimePicker1.Text = j.cnp[3].ToString() + j.cnp[4].ToString() + "." + j.cnp[5].ToString()
                +j.cnp[6].ToString() + "." + j.cnp[1].ToString() + j.cnp[2].ToString();
            int newNumber = int.Parse(j.cnp[1].ToString() + j.cnp[2].ToString());
            if(newNumber<22)
            {
                textBox3.Text = (22 - newNumber).ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            string rootpath = @"C:\Users\Student\Desktop\LPF\" + comboBox1.Text;
            string[] dirs = Directory.GetDirectories(rootpath);
            foreach (string dir in dirs)
            {
                Button btn = new Button();
                btn.Text = dir;
                btn.Width = 200;
                btn.Tag = Form3.fotbalist_nou;
                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += Btn_Click;
            }
        }
    }
}
