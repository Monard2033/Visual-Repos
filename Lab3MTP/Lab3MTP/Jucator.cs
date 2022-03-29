using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3MTP
{
    public class Jucator
    {
        string nume, CNP;
        Poz post;
        public Jucator(string nume, Poz post, string CNP)
        {
            this.nume = nume;
            this.post = post;
            this.CNP = CNP;
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public Poz Post
        {
            get { return post; }
            set { post = value; }
        }

        public string cnp
        {
            get { return CNP; }
            set { CNP = value; }
        }
        
    }
    public enum Poz : int
    {
        Portar,
        Fundas,
        Mijlocaj,
        Atacant
    };
}
