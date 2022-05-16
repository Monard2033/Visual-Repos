using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Lab3MTP
{
    public partial class Form3 : Form
    {
        private List<Jucator> lista_jucatori = new List<Jucator>();
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
            Poz pozitie_teren = (Poz)Enum.Parse(typeof(Poz), comboBoxPost.SelectedIndex.ToString());
            fotbalist_nou = new Jucator(textBoxNume.Text, pozitie_teren, textBoxCNP.Text);
            if (fotbalist_nou == null)
            {
                MessageBox.Show("Nu ati introdus datele corect!");
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                lista_jucatori.Add(fotbalist_nou);
                string path = "C:\\Users\\" + Environment.UserName + "Desktop\\LPF\\";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                //create a file
                fileName = @"C:\Users\" + Environment.UserName + "\\Desktop\\LPF\\Jucator: " + textBoxNume.Text + ".txt";
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
                DialogResult = DialogResult.OK;
            }
            
        }
    }
  
}
