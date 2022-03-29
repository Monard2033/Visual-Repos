using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3MTP
{
    public partial class Form2 : Form
    {
        public static string nume_nou;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nume_nou = textBoxEchipaNoua.Text;
            Directory.CreateDirectory("C:\\Users\\Student\\Desktop\\LPF\\" + textBoxEchipaNoua.Text);
            this.Close();
        }
    }
}
