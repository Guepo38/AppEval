 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEval
{
    public class Candidature
    {
        //Déclaration attributs
        private string nomCandidat;
        private string prenomCandidat;
        private List<Commentaires> lesCommentaires;
        private List<Notes> lesNotes;
        private List<RH> lesEvaluateurs;
        private double moyenneCandidat;
        private string commentairePDF;
        private DateTime datePDF;
        //Constructeur
        public Candidature(string unNom, string unPrenom)
        {
            this.nomCandidat = unNom;
            this.prenomCandidat = unPrenom;
            this.lesCommentaires = new List<Commentaires>();
            this.lesNotes = new List<Notes>();
            this.lesEvaluateurs = new List<RH>();
            this.moyenneCandidat = 0;
            this.commentairePDF = "";
        }
        //Getteurs
        public string GetNomCandidat()
        {
            return this.nomCandidat;
        }
        public string GetPrenomCandidat()
        {
            return this.prenomCandidat;
        }
        public List<Notes> GetNoteCandidat()
        {
            return this.lesNotes;
        }
        public List<Commentaires> GetLesCommentaires()
        {
            return lesCommentaires;
        }
        //Méthodes
        public double CalculerMoyenne()
        {
            double moyenne = 0;
            foreach(Notes c in lesNotes)
            {
                moyenne += c.GetNote();
            }
            moyenne = moyenne / lesNotes.Count();
            this.moyenneCandidat = moyenne;
            return this.moyenneCandidat;
        }
        public string EcrireCommentairePDF(string unCommentaire)
        {
            return unCommentaire;
        }
        public string AfficherContenuCom()
        {
            string oui = "";
            foreach(Commentaires c in lesCommentaires)
            {
                oui += c.GetContenu();
            }
            return oui;
        }
    }
}
