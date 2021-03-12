using System;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            MAD salaire1 = new MAD(50000);
            Client c1 = new Client("El mtougui", "Hanane", "adresse_c1");
            Compte co0 = new Compte(salaire1, c1);

            MAD salaire2 = new MAD(40000);
            Client c2 = new Client("Nouri", "Touria", "adresse_c2");
            Compte co1 = new Compte(salaire2, c1);

            
            
            salaire1.print();
            co0.consulter();

            co0.crediter(new MAD(200));
            co0.débiter(new MAD(500));
            co0.virement(new MAD(600),co1);
            c1.afficher();

            co1.consulter();
            c2.afficher();
            
            
            
            Console.ReadKey();
        }
    }
}
