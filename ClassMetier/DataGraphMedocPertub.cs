using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetier
{
    public class DataGraphMedocPertub
    {
       

        private string NomMedicamentEnzo;
        private int idMedicamentPerturbe;


        public DataGraphMedocPertub(string unNom, int unId)
        {
            NomMedicamentEnzo1 = unNom;
            IdMedicamentPerturbe = unId;

        }


        public int IdMedicamentPerturbe { get => idMedicamentPerturbe; set => idMedicamentPerturbe = value; }
        public string NomMedicamentEnzo1 { get => NomMedicamentEnzo; set => NomMedicamentEnzo = value; }
    }
}

