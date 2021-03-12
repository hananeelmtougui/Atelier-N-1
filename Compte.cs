using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    class Compte
    {
        private static int compt;
        private readonly int numcompte;
        private MAD solde;
        private readonly Client titulaire;
        private static MAD plafond;

        static Compte()
        {
            compt = 0;
            plafond = new MAD(2000.00);
        }
        public Compte(MAD s, Client t)
        {
            this.numcompte = compt++;
            this.solde = s;
            this.titulaire = t;
        }
        public void crediter(MAD sum)
        {
            this.solde = this.solde + sum;
        }
        public bool débiter(MAD sum)
        {
            if (plafond > sum)
            {
                this.solde = this.solde - sum;
                return true;
            }
            else
            {
                Console.WriteLine("le solde est insuffisant pour débiter");
                return false;
            }

        }
        public void virement(MAD sum, Compte C)
        {
            C.crediter(sum);
        }
        public void consulter()
        {
            Console.WriteLine("le numéro du compte est :" + this.numcompte);
            Console.WriteLine("le solde est :" +this.solde );
           
        }
    }
}
