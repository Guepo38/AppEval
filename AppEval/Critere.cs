using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEval
{
    public class Critere
    {
        //Déclaration attributs
        // clonage shainee
        private int idCrit;
        private string nomCrit;
        //Constructeur
        public Critere(int unIdCritere, string unNomCritere)
        {
            this.idCrit = unIdCritere;
            this.nomCrit = unNomCritere;
        }
        //Getteurs
        public string GetNomCritere()
        {
            return this.nomCrit;
        }
    }
}
