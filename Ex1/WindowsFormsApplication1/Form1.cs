using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;

namespace WindowsFormsApplication1
{    
    public partial class Form1 : Form
    {
        byte[] hash1;
        byte[] hash2;
        SHA512CryptoServiceProvider mySha512 = new SHA512CryptoServiceProvider();
        public Form1()
        {
            InitializeComponent();
        }
        public string ByteArrayToString(byte[] array)
        {
            return Encoding.ASCII.GetString(array);
        }

        private void File1_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if(f.ShowDialog()==DialogResult.OK)
            {                
                string s=f.FileName;
                FileStream fstream = new FileStream(s, FileMode.Open);
                textBoxFile1.Text = s;
                hash1 = mySha512.ComputeHash(fstream);
                textBoxFile1Hash.Text = ByteArrayToString(hash1);
                fstream.Close();
            }

        }        

        private void File2_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                string s = f.FileName;
                FileStream fstream = new FileStream(s, FileMode.Open);
                textBoxFile2.Text = s;
                hash2 = mySha512.ComputeHash(fstream);
                textBoxFile2Hash.Text = ByteArrayToString(hash2);
                fstream.Close();
            }
        }

        private void Check_files_Click(object sender, EventArgs e)
        {
            if(textBoxFile1Hash.Text.CompareTo(textBoxFile2Hash.Text)==0)
            {
                MessageBox.Show("Fisierele sunt identice!", "Mesaj", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Fisierele  NU sunt identice!", "Mesaj", MessageBoxButtons.OK);
            }
        }
    }
}
