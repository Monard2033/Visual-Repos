using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Laborator2
{
    class Persoana
    {
        private int index;
        private string nume;
        private DateTime dataNasterii;
        private string telefon;
        private string adresa;
        private Categorie categorie;

        public Persoana(int index, string nume, DateTime dataNasterii, string telefon, string adresa, Categorie categorie)
        {
            this.index = index;
            this.nume = nume;
            this.dataNasterii = dataNasterii;
            this.telefon = telefon;
            this.adresa = adresa;
            this.categorie = categorie;
        }
        [Description("Index"), Browsable(false)]
        public int Index
        {
            get
            {
                return index;
            }
        }
        [Description("Nume"), Category("Date Personale")]
        public string Nume
        {
            get { return nume; }
        }
        [Description("Data Nasterii"), Category("Date Personale")]
        public string DataNasterii
        {
            get
            {
                return dataNasterii.ToString("dd.MM.yyyy");
            }

        }
        [Description("Telefon"), Category("Date de contact")]
        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }
        [Description("Adresa"), Category("Date de contact")]
        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }
        [Description("Categorie"), Category("Date Personale")]
        public Categorie Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }
    }
        enum Categorie : int
        {
            Prieteni,
            Colegi,
            Rude,
            Diversi
        };
}

