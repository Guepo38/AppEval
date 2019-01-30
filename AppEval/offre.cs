using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEval
{
    public class Offre
    {
        //Déclaration attributs
        private int idOffre;
        private string titreOffre;
        private DateTime dateLimiteVote;
        private List<Critere> lesCriteres;

        //Constructeur Offre
        public Offre(int uneId, string unTitre, DateTime uneDateLimiteVote)
        {
            this.idOffre = uneId;
            this.titreOffre = unTitre;
            this.dateLimiteVote = uneDateLimiteVote;
            this.lesCriteres = new List<Critere>();
        }

        //Getteurs
        public string GetDateLimite()
        {
            return this.dateLimiteVote.ToString();
        }
        public string GetTitreOffre()
        {
            return this.titreOffre;
        }
        public List<Critere> GetListeCriteres()
        {
            return this.lesCriteres;
        }

        //Méthodes
        //Change la date actuelle
        public void ChangerDateLimite(DateTime nouvelleDate)
        {
            this.dateLimiteVote = nouvelleDate;
        }
        //Ajoute un critère, à faire pour ajouter dans la BDD
        public void AjouterCritere(Critere unCritere)
        {
            this.lesCriteres.Add(unCritere);
        }
    }
}
