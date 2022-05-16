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
        private string fileName;

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
            //create a folder 
            string path = @"C:\\Users\"+ Environment.UserName +"\Desktop\LPF";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            //create a file
            fileName = @"C:\Users\"+ Environment.UserName +"\Desktop\LPF\Jucator: " + textBoxNume.Text + ".txt";
            // Check if file already exists. If yes, delete it.  
            if (File.Exists(fileName))
            {
                // Create a new file 
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    foreach (Jucator jucator in lista_jucatori)
                    {
                        sw.WriteLine("Nume: " + jucator.Nume.ToString());
                        sw.WriteLine("Post: " + jucator.Post.ToString());
                        sw.WriteLine("CNP: " + jucator.cnp.ToString());

                    }
                    MessageBox.Show("Jucatorul a fost adaugat cu succes!");
                }
            }
            this.Close();
        }
    }
}
