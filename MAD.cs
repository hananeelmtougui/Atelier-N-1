using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    class MAD
    {
        private double valeur;
        public MAD(double v)
        {
            this.valeur = v;
        }
        public void print()
        {
            Console.WriteLine("la valeur de la somme d'argent est :" + this.valeur);
        }
        public static MAD operator +(MAD A, MAD B)
        {
            MAD r = new MAD(0);
            r.valeur = A.valeur + B.valeur;
            return r;
        }
        public static MAD operator -(MAD L, MAD H)
        {
            MAD s = new MAD(0);
            s.valeur = L.valeur - H.valeur;
            return s;
        }
        public static bool operator >(MAD D, MAD P)
        {
            if (D.valeur > P.valeur)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(MAD D, MAD P)
        {
            if (D.valeur < P.valeur)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
