using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Materiel.Models
{
    class pret
    {
        public class Pret
        {
            //attributs
            private int idpret;
            private DateTime datepret;
            private int idAdherent;

            public Pret(int idpret, DateTime datepret, int idAdherent)
            {
                this.idpret = idpret;
                this.datepret = datepret;
                this.idAdherent = idAdherent;
            }

            public override string ToString()
            {
                // return base.Tostring
                string _combinaison;
                _combinaison = string.Concat("idpret : ", idpret, "datepret : ", datepret, "idAdherent : ", idAdherent);
                return base.ToString();
            }
        }
    }
}
