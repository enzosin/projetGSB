using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetier
{
   public class GraphTypePersonne
    {
        private string libelleTypeIndividu;
        private int nbTypeIndivu;

        public GraphTypePersonne(string unLibelle, int nbType)
        {
            LibelleTypeIndividu = unLibelle;
            NbTypeIndivu = nbType;
        }

        public string LibelleTypeIndividu { get => libelleTypeIndividu; set => libelleTypeIndividu = value; }
        public int NbTypeIndivu { get => nbTypeIndivu; set => nbTypeIndivu = value; }
    }

}
