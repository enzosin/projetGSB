using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetier
{
   public class datagraphe
    {
        private string nomFamille;
        private int idMedicament;
       


        public datagraphe(string unNom, int unId)
        {
            NomFamille = unNom;
            IdMedicament = unId;

        }

        public string NomFamille { get => nomFamille; set => nomFamille = value; }
        public int IdMedicament { get => idMedicament; set => idMedicament = value; }
    }
}
