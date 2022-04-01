using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using GestionMaterielUWP.Metier;
using System.Diagnostics;

namespace GestionMaterielUWP.DataAccess
{
    public static class Dao
    {
        public static ObservableCollection<Adherent> GetAdherents(string connectionString)
        {
            const string GetAdherentsQuery = "select nom,prenom,rue,cp,ville,telephone," +
               " mail,genre,niveau,pointure,taille " +
               " from GMAdherent";

            var adherents = new ObservableCollection<Adherent>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = GetAdherentsQuery;
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var adherent = new Adherent();
                                    adherent.AdherentNom = reader.GetString(0);
                                    adherent.AdherentPrenom = reader.GetString(1);
                                    adherent.Rue = reader.GetString(2);
                                    adherent.Cp = reader.GetString(3);
                                    adherent.Ville = reader.GetString(4);
                                    adherent.Telephone = reader.GetString(5);
                                    adherent.Mail = reader.GetString(6);
                                    adherent.Genre = reader.GetString(7);
                                    adherent.Niveau = reader.GetString(8);
                                    adherent.Pointure = reader.GetInt32(9);
                                    adherent.Taille = reader.GetString(10);
                                    adherents.Add(adherent);
                                }
                            }
                        }
                    }
                }
                return adherents;
            }
            catch (Exception eSql)
            {
                Debug.WriteLine("Exception: " + eSql.Message);
            }
            return null;
        }
    }
}
