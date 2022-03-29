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
    public partial class Form3 : Form
    {
        List<Jucator> lista_jucatori = new List<Jucator>();
        public static Jucator fotbalist_nou;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var pozitie_teren = (Poz)Enum.Parse(typeof(Poz), comboBoxPost.SelectedIndex.ToString());
            fotbalist_nou = new Jucator(textBoxNume.Text, pozitie_teren, textBoxCNP.Text);
            lista_jucatori.Add(fotbalist_nou);
            string fileName = "C:\\Users\\Student\\Desktop\\LPF\\" + Form1.nume_echipa_selectata + "\\" + textBoxCNP.Text;

            // Check if file already exists. If yes, delete it.     
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.WriteLine(fotbalist_nou.Nume);
                sw.WriteLine(fotbalist_nou.Post);
                sw.WriteLine(fotbalist_nou.cnp);
            }

            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            this.Close();
        }

    }
}
