using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Materiel.Models
{
    class Combinaison
    {
        public class combinaison : Materiel
        {
            //attributs
            private double taille;
            private string saison;
            private string genre;

            public combinaison(int _codemat, string _type, string _marque, string _etat, double taille, string saison, string genre) :
                base(_codemat, _type, _marque, _etat)
            {
                this.taille = taille;
                this.saison = saison;
                this.genre = genre;
            }

            public override string ToString()
            {
                // return base.Tostring
                string _combinaison;
                _combinaison = string.Concat("taille : ", taille, "saison : ", saison, "genre: ", genre);
                return base.ToString();
            }
        }
    }
}
