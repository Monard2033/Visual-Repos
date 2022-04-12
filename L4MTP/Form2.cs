using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
        public string CNP { get { return txtCNP.Text; } }
        public DateTime Data { get { return dateTimePicker1.Value; } }
        public string Imagine { get { return txtImagine.Text; } }
        public string Diagnostic { get { return txtDiagnostic.Text; } }
        public string Comentarii { get { return txtComentarii.Text; } }
        private string GetFileName(string path)
        {
            string[] splitChars = new string[] { "\\" };
            string[] result = path.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);
            return result[result.GetLength(0) - 1];

        }
        private void button_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Form1.imgFolder;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtDiagnostic.Text = GetFileName(ofd.FileName);
            }
        }
    }
}
