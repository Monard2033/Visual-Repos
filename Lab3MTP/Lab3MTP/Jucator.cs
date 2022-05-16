namespace Lab3MTP
{
    public class Jucator
    {
        private string nume, CNP;
        private Poz post;
        public Jucator(string nume, Poz post, string CNP)
        {
            this.nume = nume;
            this.post = post;
            this.CNP = CNP;
        }

        public string Nume
        {
            get => nume;
            set => nume = value;
        }

        public Poz Post
        {
            get => post;
            set => post = value;
        }

        public string cnp
        {
            get => CNP;
            set => CNP = value;
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
