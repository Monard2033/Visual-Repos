using System;
using System.Windows.Forms;

namespace L4MTP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string CNP)
        {
            InitializeComponent();
            txtCNP.Text = CNP;
        }
        public string CNP => txtCNP.Text;
        public DateTime Data => dateTimePicker1.Value;
        public string Imagine => txtImagine.Text;
        public string Diagnostic => txtDiagnostic.Text;
        public string Comentarii => txtComentarii.Text;
        private string GetFileName(string path)
        {
            string[] splitChars = new string[] { "\\" };
            string[] result = path.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);
            return result[result.GetLength(0) - 1];

        }
        private void button_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = Form1.imgFolder
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtImagine.Text = GetFileName(ofd.FileName);
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }

}
