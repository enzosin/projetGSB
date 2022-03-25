using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetier
{
    public class Famille
    {
        private int idFamille;
        private string nomFamille;

        public Famille(int unId, string unNom)
        {
            IdFamille = unId;
            NomFamille = unNom;
        }

        public int IdFamille { get => idFamille; set => idFamille = value; }
        public string NomFamille { get => nomFamille; set => nomFamille = value; }
    }
}
