using System;
using System.IO;
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
            if (nume_nou != null)
            {
                Directory.CreateDirectory("C:\\Users\\" + Environment.UserName + "\\Desktop\\LPF");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Introduceti numele echipei!");
                DialogResult = DialogResult.Cancel;
            }
            DialogResult = DialogResult.OK;
        }
    }
}
