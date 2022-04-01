using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Materiel.Models
{
    public class Materiel
    {
        //atributs
        private int _codeMat;
        private string _type;
        private string _marque;
        private string _etat;

        public Materiel(int _codeMat, string _type, string _marque, string _etat)
        {
            this._codeMat = _codeMat;
            this._type = _type;
            this._marque = _marque;
            this._etat = _etat;
        }

        public override string ToString()
        {
            // return base.Tostring
            string _materiel;
            _materiel = string.Concat("_codeMat : ", _codeMat, "_type : ", _type, "_marque : ", _marque, "_etat :", _etat);
            return base.ToString();
        }
    }
}
