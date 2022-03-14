using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Ex3
{
    public partial class Form1 : Form
    {
        int k=0;
        public Form1()
        {
            InitializeComponent();
        }
        public byte[] StringToByteArray(string s)
        {
            return CharArrayToByteArray(s.ToCharArray());
        }
        public byte[] CharArrayToByteArray(char[] array)
        {
            return Encoding.ASCII.GetBytes(array, 0, array.Length);
        }
        public string ByteArrayToString(byte[] array)
        {
            return Encoding.ASCII.GetString(array);
        }
        private void buttonGenerare_Click(object sender, EventArgs e)
        {
            k = int.Parse(textBoxK.Text);
            SHA512CryptoServiceProvider mySHA512 = new SHA512CryptoServiceProvider();
            SHA512CryptoServiceProvider yourSHA512 = new SHA512CryptoServiceProvider();
            RandomNumberGenerator rnd = RandomNumberGenerator.Create();
            byte[] parola1 = new byte[1];
            byte[] parola2 = new byte[2];
            byte[] hashValue1;
            byte[] aux_hashValue1;
            string aux,aux1;

            rnd.GetBytes(parola1);
            hashValue1 = mySHA512.ComputeHash(parola1);
            textBoxParola1.Text = ByteArrayToString(parola1);
            textBoxHash1.Text = ByteArrayToString(hashValue1);
            aux1 = (textBoxHash1.Text).Substring(64-k);
            aux1 = aux1.Trim();
            label6.Text = aux1;
            
            rnd.GetBytes(parola2);
            aux_hashValue1 = yourSHA512.ComputeHash(parola2);
            aux = ByteArrayToString(aux_hashValue1);
            while((aux.Substring(64-k)).CompareTo(aux1)!=0)
            {
                rnd.GetBytes(parola2);
                aux_hashValue1 = yourSHA512.ComputeHash(parola2);
                aux = ByteArrayToString(aux_hashValue1);
            }
            textBoxParola2.Text = ByteArrayToString(parola2);
            textBoxHash2.Text = ByteArrayToString(aux_hashValue1);
        }
    }
}
