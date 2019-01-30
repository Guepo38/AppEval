using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEval
{
    public class Commentaires
    {
        //Déclaration Attributs
        private int idCom;
        private string contenuCom;
        //Constructeur
        public Commentaires(int uneId)
        {
            this.idCom = uneId;
            this.contenuCom = "";
        }
        //Getteur
        public string GetContenu()
        {
            return this.contenuCom;
        }
        //Méthodes
        public void AjouterContenu(string unContenu)
        {
            this.contenuCom = unContenu;
        }
        
 
    }
}
