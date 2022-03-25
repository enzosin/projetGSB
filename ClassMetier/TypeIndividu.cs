using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetier
{
    public class TypeIndividu
    {
        private int idType;
        private string libelleType;

        public TypeIndividu(int unId, string unLibelle)
        {
            IdType = unId;
            LibelleType = unLibelle;
        }

        public int IdType { get => idType; set => idType = value; }
        public string LibelleType { get => libelleType; set => libelleType = value; }
    }
}
