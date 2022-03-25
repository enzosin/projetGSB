using System;

namespace ClassMetier
{
    public class Medicament
    {
        private int idMedicament;
        private string nomMedicament;
        private string nomFamille;
        private string composition;
        private string effets;
        private string contreIndication;
        private double prixEchantillon;

        public Medicament(int unId, string unNomMedoc, string uneFamille, string uneComposition, string desEffets, string uneContreIndic, double unPrix)
        {
            IdMedicament = unId;
            NomMedicament = unNomMedoc;
            NomFamille = uneFamille;
            Composition = uneComposition;
            Effets = desEffets;
            ContreIndication = uneContreIndic;
            PrixEchantillon = unPrix;
        }

        public int IdMedicament { get => idMedicament; set => idMedicament = value; }
        public string NomMedicament { get => nomMedicament; set => nomMedicament = value; }
        public string Composition { get => composition; set => composition = value; }
        public string Effets { get => effets; set => effets = value; }
        public string ContreIndication { get => contreIndication; set => contreIndication = value; }
        public double PrixEchantillon { get => prixEchantillon; set => prixEchantillon = value; }
        public string NomFamille { get => nomFamille; set => nomFamille = value; }
    }
}
