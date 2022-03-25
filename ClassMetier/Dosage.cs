using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetier
{
    public class Dosage
    {
        private int idDosage;
        private int quantite;
        private string unite;

        public Dosage(int unId, int uneQuantite, string uneUnite)
        {
            IdDosage = unId;
            Quantite = uneQuantite;
            Unite = uneUnite;
        }

        public int IdDosage { get => idDosage; set => idDosage = value; }
        public int Quantite { get => quantite; set => quantite = value; }
        public string Unite { get => unite; set => unite = value; }
    }
}
