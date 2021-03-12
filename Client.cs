using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    class Client
    {
        private string nom;
        private string prenom;
        private string adresse;
        public Client(string n, string p, string a)
        {
            this.nom = n;
            this.prenom = p;
            this.adresse = a;
        }
        public void afficher()
        {
            Console.WriteLine("le nom du client :" + this.nom);
            Console.WriteLine("le prenom du client :" + this.prenom);
            Console.WriteLine("l'adresse du client est :" + this.adresse);
        }
    }
}
