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
        private int coeff;
        //Constructeur
        public Critere(int unIdCritere, string unNomCritere, int unCoeff)
        {
            this.idCrit = unIdCritere;
            this.nomCrit = unNomCritere;
            this.coeff = unCoeff;
        }
        //Getteurs
        public string GetNomCritere()
        {
            return this.nomCrit;
        }
        public int GetCoeffCritere()
        {
            return this.coeff;
        }
    }
}
