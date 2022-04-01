using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Materiel.Models
{
    class Adherent
    {

        //attributs
        private int id;
        private int numero;
        private string nom;
        private string prenom;
        private string adressrue;
        private string addresscodepostal;
        private string adresseville;
        private int telephone;
        private string mail;
        private string genre;
        private string niveau;
        private DateTime datenaissance;
        private string certmedical;
        private double pointure;
        private double taille;

        public Adherent(int id, int numero, string nom, string prenom, string adressrue, string addresscodepostal, string adresseville, int telephone, string mail, string genre, string niveau, DateTime datenaissance, string certmedical, double pointure, double taille)
        {
            this.id = id;
            this.numero = numero;
            this.nom = nom;
            this.prenom = prenom;
            this.adressrue = adressrue;
            this.addresscodepostal = addresscodepostal;
            this.adresseville = adresseville;
            this.telephone = telephone;
            this.mail = mail;
            this.genre = genre;
            this.niveau = niveau;
            this.datenaissance = datenaissance;
            this.certmedical = certmedical;
            this.pointure = pointure;
            this.taille = taille;
        }

        public override string ToString()
        {
            // return base.Tostring
            string _combinaison;
            _combinaison = string.Concat("id : ", id ,"numero : ", numero, "nom : ", nom, "prenom : ", prenom, "adressrue : ", adressrue, "addresscodepostal : ", addresscodepostal, "adresseville : ", adresseville, "telephone : ", telephone, "mail : ", mail, "genre: ", genre, "niveau : ", niveau, "datenaissance : ", datenaissance, "certmedical : ", certmedical, "pointure : ", pointure, "taille : ", taille) ;
            return base.ToString();
        }

    }
}
