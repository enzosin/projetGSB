using MySql.Data.MySqlClient;
using System;
using ClassMetier;
using System.Collections.Generic;
namespace GstBdd
{
    public class GstBDD
    {
        private MySqlConnection cnx;
        private MySqlCommand cmd;
        private MySqlDataReader dr;

        // Constructeur
        public GstBDD()
        {
            string chaine = "Server=localhost;Database=gstmedicaments;Uid=root;Pwd=";
            cnx = new MySqlConnection(chaine);
            cnx.Open();
        }


        // renvoi la liste de tous les médicaments
        public List<Medicament> getLstMedicamentGael()
        {
            List<Medicament> lstMedoc = new List<Medicament>();

            cmd = new MySqlCommand("SELECT MED_DepotLegal, MED_NomCommercial, famille.FAM_libelle, MED_Composition, MED_Effets, MED_Contreindic, MED_PrixChantillon FROM medicaments INNER JOIN famille ON famille.FAM_code = medicaments.FAM_Code ", cnx);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Medicament unMedicament = new Medicament(Convert.ToInt16(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), Convert.ToDouble(dr[6].ToString()));
                lstMedoc.Add(unMedicament);
            }
            dr.Close();
            return lstMedoc;
        }

        // renvoi la liste de tous les dosages
        public List<Dosage> getLstDosageGael()
        {
            List<Dosage> lstDosage = new List<Dosage>();

            cmd = new MySqlCommand("SELECT DOS_CODE, DOS_QUANTITE, DOS_UNITE FROM dosage ", cnx);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Dosage unDosage = new Dosage(Convert.ToInt16(dr[0].ToString()), Convert.ToInt16(dr[1].ToString()), dr[2].ToString());
                lstDosage.Add(unDosage);
            }
            dr.Close();
            return lstDosage;
        }

        // Renvoi la liste de toutes les familles
        public List<Famille> getLstFamilleGael()
        {
            List<Famille> lstFamille = new List<Famille>();

            cmd = new MySqlCommand("SELECT FAM_code, FAM_libelle FROM famille ", cnx);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Famille uneFamille = new Famille(Convert.ToInt16(dr[0].ToString()), dr[1].ToString());
                lstFamille.Add(uneFamille);
            }
            dr.Close();

            return lstFamille;
        }

        // Renvoi le dernier id Medicament 
        public int getLastIdMedocGael()
        {
            int lastId;

            cmd = new MySqlCommand("SELECT Max(MED_DepotLegal) FROM medicaments", cnx);
            dr = cmd.ExecuteReader();

            dr.Read();
            lastId = Convert.ToInt16(dr[0].ToString());
            dr.Close();
            return lastId + 1;
        }

        // Ajoute un medicament en base de données
        public void addMedicamentGael(string nomMedoc, int idFamille, string composition, string effet, string contreIndic, double prix)
        {
            int lastId = getLastIdMedocGael();
            string temp = prix.ToString().Replace(',', '.');

            cmd = new MySqlCommand("INSERT INTO medicaments VALUES (" + lastId + ", '" + nomMedoc + "', '" + idFamille + "', '" + composition + "', '" + effet + "', '" + contreIndic + "', '" + temp + "')", cnx);
            cmd.ExecuteNonQuery();
        }

        // Update le médicament
        public void UpdateMedicamentEnzo(int MED_DepotLegal, string MED_NomCommercial, int FAM_Code, string MED_Composition, string MED_Effets, string MED_Contreindic, double MED_PrixChantillon)
        {
            string temp = MED_PrixChantillon.ToString().Replace(',', '.');
            cmd = new MySqlCommand("UPDATE medicaments SET MED_NomCommercial = '" + MED_NomCommercial + "', FAM_Code ='" + FAM_Code + "', MED_Composition = '" + MED_Composition + "', MED_Effets = '" + MED_Effets + "', MED_Contreindic = '" + MED_Contreindic + "', MED_PrixChantillon = " + temp + " WHERE MED_DepotLegal = '" + MED_DepotLegal + "'", cnx);
            cmd.ExecuteNonQuery();
        }

        // Ajoute une prescription
        public void addPrescriptionGael(int idMedoc, int idIndividu, int idDosage, string txtPosologie)
        {
            cmd = new MySqlCommand("INSERT INTO prescrire VALUES (" + idMedoc + ", " + idIndividu + ", " + idDosage + ", '" + txtPosologie + "')", cnx);
            cmd.ExecuteNonQuery();
        }

        // Renvoi une liste de tous les types individus
        public List<TypeIndividu> GetTypeIndividusYanis()
        {
            List<TypeIndividu> mesIndividus = new List<TypeIndividu>();

            cmd = new MySqlCommand("Select TIN_CODE , TIN_LIBELLE from type_individu", cnx);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TypeIndividu uneNouveauInvidu = new TypeIndividu(Convert.ToInt16(dr[0].ToString()), dr[1].ToString());
                mesIndividus.Add(uneNouveauInvidu);
            }
            dr.Close();
            return mesIndividus;
        }
        // renvoi le dernier id individu
        public int getLastIdIndividuYanis()
        {
            int lastId;

            cmd = new MySqlCommand("SELECT Max(TIN_CODE) FROM type_individu", cnx);
            dr = cmd.ExecuteReader();

            dr.Read();
            lastId = Convert.ToInt16(dr[0].ToString());
            dr.Close();
            return lastId + 1;
        }

        // Insert un nouvel individu
        public void InsertIndividuYanis(int TIN_CODE, string TIN_LIBELLE)
        {
            int lastId = getLastIdIndividuYanis();
            cmd = new MySqlCommand("Insert into type_individu values(" + lastId + ",'" + TIN_LIBELLE + "' )", cnx);
            cmd.ExecuteNonQuery();
        }
        public void UpdateIndividuYanis(int TIN_CODE, string TIN_LIBELLE)
        {
            cmd = new MySqlCommand("UPDATE type_individu SET TIN_LIBELLE = " + "'" + TIN_LIBELLE + "' WHERE TIN_CODE = " + TIN_CODE, cnx);
            cmd.ExecuteNonQuery();
        }

        // renvoi un medicament selon son id
        public Medicament getMedicamentByIdGael(int id)
        {
            Medicament unMedoc;

            cmd = new MySqlCommand("SELECT MED_DepotLegal, MED_NomCommercial, famille.FAM_libelle, MED_Composition, MED_Effets, MED_Contreindic, MED_PrixChantillon FROM medicaments INNER JOIN famille ON famille.FAM_code = medicaments.FAM_Code WHERE medicaments.MED_DepotLegal = " + id, cnx);
            dr = cmd.ExecuteReader();

            dr.Read();
            unMedoc = new Medicament(Convert.ToInt16(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), Convert.ToDouble(dr[6].ToString()));
            dr.Close();

            return unMedoc;
        }

        // renvoi un objet de type Famille selon son nom
        public Famille getFamilleByName(string name)
        {
            Famille uneFam;

            cmd = new MySqlCommand("SELECT FAM_code, FAM_libelle FROM `famille` WHERE FAM_libelle ='" + name + "'", cnx);
            dr = cmd.ExecuteReader();
            dr.Read();
            uneFam = new Famille(Convert.ToInt16(dr[0].ToString()), dr[1].ToString());
            dr.Close();
            return uneFam;
        }

        // Insert un médicament perturbateur 
        public void InsertMedicamentPertubateur(int MedicamentPertubateur, int MedicamentPertube)
        {
            cmd = new MySqlCommand("INSERT INTO  interagir (Med_Pertubateur, MED_MED_Perturbe) VALUES(" + MedicamentPertubateur + "," + MedicamentPertube + ")", cnx);
            cmd.ExecuteNonQuery();
        }

        // renvoi la liste de médicament NonPerturbateur selon l'id d'un médicament
        // un médicament ne peut être perturbé par lui même
        // un médicament ne peut être perturbé plus d'une fois par le même médicament
        public List<Medicament> GetMedicamentNonPertubateurYanis(int MED_DepotLegal)
        {
            List<Medicament> mesMedicamentsNonPertub = new List<Medicament>();
            cmd = new MySqlCommand("SELECT MED_DepotLegal, MED_NomCommercial, famille.FAM_libelle, MED_Composition, MED_Effets, MED_Contreindic, MED_PrixChantillon from medicaments INNER JOIN famille ON famille.FAM_code = medicaments.FAM_Code where MED_DepotLegal != "+ MED_DepotLegal + " AND MED_DepotLegal NOT IN (SELECT interagir.Med_Pertubateur FROM interagir WHERE interagir.MED_MED_Perturbe = " + MED_DepotLegal +")", cnx);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Medicament uneNouveauMedicamentNonPertub = new Medicament(Convert.ToInt16(dr[0]), dr[1].ToString(), dr[4].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), Convert.ToInt16(dr[6]));
                mesMedicamentsNonPertub.Add(uneNouveauMedicamentNonPertub);
            }
            dr.Close();
            return mesMedicamentsNonPertub;
        }
        // Renvoi la liste des médicaments perturbateurs
        public List<Medicament> GetMedicamentPertubateurYanis(int MED_DepotLegal)
        {
            List<Medicament> mesMedicamentsPertub = new List<Medicament>();

            cmd = new MySqlCommand("SELECT Med_Pertubateur , MED_NomCommercial, famille.FAM_libelle, MED_Composition,  MED_Effets, MED_Contreindic, MED_PrixChantillon from medicaments INNER JOIN famille ON famille.FAM_code = medicaments.FAM_Code inner join interagir on medicaments.MED_DepotLegal = interagir.Med_Pertubateur where interagir.MED_MED_Perturbe =" + MED_DepotLegal, cnx);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Medicament uneNouveauMedicamentPertub = new Medicament(Convert.ToInt16(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), Convert.ToInt16(dr[6]));
                mesMedicamentsPertub.Add(uneNouveauMedicamentPertub);
            }
            dr.Close();
            return mesMedicamentsPertub;
        }

        public List<datagraphe> GetDataGrapheYan()
        {
            List<datagraphe> mesDatas = new List<datagraphe>();

            cmd = new MySqlCommand("SELECT FAM_libelle, count(medicaments.MED_DepotLegal) From famille inner join medicaments on famille.FAM_code = medicaments.MED_DepotLegal GROUP by medicaments.FAM_code", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                datagraphe dg = new datagraphe (dr[0].ToString(), Convert.ToInt16(dr[1]));
                mesDatas.Add(dg);
            }
            dr.Close();

            return mesDatas;
        }

        public List<DataGraphMedocPertub> getDataGraphEnzo()
        {
            List<DataGraphMedocPertub> mesDatas = new List<DataGraphMedocPertub>();
            cmd = new MySqlCommand("SELECT medicaments.MED_NomCommercial, COUNT(interagir.MED_MED_Perturbe) FROM medicaments INNER JOIN interagir ON medicaments.MED_DepotLegal = interagir.MED_MED_Perturbe GROUP By MED_NomCommercial", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DataGraphMedocPertub dg = new DataGraphMedocPertub(dr[0].ToString(), Convert.ToInt16(dr[1]));
                mesDatas.Add(dg);
            }
            dr.Close();

            return mesDatas;
        }

        // Renvoi les ibelle individu avec le nombre de foisqu'il est dans une prescription
        // exemple Femme enceinte - 9 prescriptions pour ce type de personne
        public List<GraphTypePersonne> GetGraphTypePersonnes()
        {
            List<GraphTypePersonne> lstTypePersonne = new List<GraphTypePersonne>();

            cmd = new MySqlCommand("SELECT type_individu.TIN_LIBELLE, COUNT(prescrire.TIN_CODE) AS nbTypePersonne FROM type_individu INNER JOIN prescrire ON prescrire.TIN_CODE = type_individu.TIN_CODE GROUP BY prescrire.TIN_CODE", cnx);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                GraphTypePersonne typePersonne = new GraphTypePersonne(dr[0].ToString(), Convert.ToInt16(dr[1]));
                lstTypePersonne.Add(typePersonne);
            }
            dr.Close();
            return lstTypePersonne;
        }

        // Vérifie Si la prescription n'est pas déja atttribué
        public bool VerifPrescription(int idIndividu, int idMedicament, int idDosage)
        {
            bool existe = false;
            cmd = new MySqlCommand("SELECT prescrire.MED_DepotLegal FROM prescrire WHERE TIN_CODE =" + idIndividu + " AND DOS_CODE =" + idDosage + " AND MED_DepotLegal =" + idMedicament, cnx);

            dr = cmd.ExecuteReader();

            while (dr.Read())
                existe = true;
            dr.Close();
            return existe;
        }
    }
}



    
