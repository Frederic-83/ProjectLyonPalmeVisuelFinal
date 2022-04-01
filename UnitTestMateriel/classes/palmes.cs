using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Materiel.Models
{
    class Palme
    {
        public class palme : Materiel
        {
            //attributs
            private string matiere;
            private int pointure;
            private bool aillette;

            public palme(int _codemat, string _type, string _marque, string _etat, string matiere, int pointure, bool aillette) :
                base(_codemat, _type, _marque, _etat)
            {
                this.matiere = matiere;
                this.pointure = pointure;
                this.aillette = aillette;
            }

            public override string ToString()
            {
                // return base.Tostring
                string _palmes;
                _palmes = string.Concat("matiere : ", matiere, "pointure : ", pointure, "aillette: ", aillette);
                return base.ToString();
            }

        }


    }
}