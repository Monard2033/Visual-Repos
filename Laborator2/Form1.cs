using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Laborator2
{
    public partial class Form1 : Form
    {
        List<Persoana> agenda = new List<Persoana>();
        public Form1()
        {
            InitializeComponent();
            //adaugare prieteni
            TreeNode node = new TreeNode();
            node.Name = "Prieteni";
            node.Text = "Prieteni";
            treeView1.Nodes.Add(node);
            //adaugare colegi
            TreeNode node1 = new TreeNode();
            node1.Name = "Colegi";
            node1.Text = "Colegi";
            treeView1.Nodes.Add(node1);
            //adaugare rude
            TreeNode node2 = new TreeNode();
            node2.Name = "Rude";
            node2.Text = "Rude";
            treeView1.Nodes.Add(node2);
            //adaugare diversi
            TreeNode node3 = new TreeNode();
            node3.Name = "Diversi";
            node3.Text = "Diversi";
            treeView1.Nodes.Add(node3);
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            int index = agenda.Count + 1;
            string nume = txtNume.Text;
            DateTime dataNasterii = dateTimePicker1.Value;
            string telefon = txtTelefon.Text;
            string adresa = txtAdresa.Text;
            Categorie categorie = (Categorie)Enum.Parse(typeof(Categorie), comboCategorii.SelectedItem.ToString());
            Persoana p = new Persoana(index, nume, dataNasterii, telefon, adresa, categorie);
            agenda.Add(p);

            TreeNode childNode = new TreeNode();
            childNode.Name = p.Index.ToString();
            childNode.Text = p.Nume;
            treeView1.Nodes[p.Categorie.ToString()].Nodes.Add(childNode);
            propertyGrid1.SelectedObject = p;

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Persoana selectedp = getPersoanaByIndex(treeView1.SelectedNode.Name);
            propertyGrid1.SelectedObject = selectedp;
        }
        private Persoana getPersoanaByIndex(string index)
        { return agenda.Find(x => x.Index.ToString() == index); }
        private Persoana getPersoanaByName(string name)
        { return agenda.Find(x => x.Nume == name); }

        private void buttonCauta_Click(object sender, EventArgs e)
        {
            Persoana p = getPersoanaByName(txtNume2.Text);
            propertyGrid1.SelectedObject = p;
        }

        private void buttonStergere_Click(object sender, EventArgs e)
        {
            Persoana p = (Persoana)propertyGrid1.SelectedObject;

            if (MessageBox.Show("Doriti sa stergeti persoana [" + p.Nume + "]?", "Intrebare", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Persoana pstergere = getPersoanaByName(p.Nume);
                treeView1.Nodes[p.Categorie.ToString()].Nodes[p.Index.ToString()].Remove();
                agenda.Remove(pstergere);
            }
        }

        private void buttonFisier_Click(object sender, EventArgs e)
        {
            string dir = Application.StartupPath;
            StreamWriter sw = new StreamWriter(dir + "\\agenda.txt", false);
            foreach(Persoana p in agenda)
            {
                sw.WriteLine("-------------------------------");
                sw.WriteLine("Nume: " + p.Nume);
                sw.WriteLine("Data Nasterii: " + p.DataNasterii);
                sw.WriteLine("Adresa: " + p.Adresa);
                sw.WriteLine("Telefon: " + p.Telefon);
                sw.WriteLine("Categorii: " + p.Categorie);
                sw.WriteLine("------------------------------");
            }
            sw.Close();
            Process.Start("notepad.exe", dir + "\\agenda.txt");
        }
    }
}

