using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEval
{
    public class RH
    {
        //Déclaration attributs
        private int idRH;
        private string nomRH;
        private string prenomRH;   
        private List<Offre> lesOffres;
        private List<Candidature> lesCandidatures;
        //Constructeur
        public RH(string unNom, string unPrenom)
        {
            this.nomRH = unNom;
            this.prenomRH = unPrenom;
            this.lesOffres = new List<Offre>();
            this.lesCandidatures = new List<Candidature>();
        }
        //Getteurs
        public string GetNomRH()
        {
            return this.nomRH;
        }
        public string GetPrenomRH()
        {
            return this.prenomRH;
        }
        public List<Offre> GetLesOffres()
        {
            return this.lesOffres;
        }
    }
}
