using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEval
{
    public class Notes
    {
        private int idNote;
        private int note;

        public Notes(int uneId)
        {
            this.idNote = uneId;
            this.note = 0;
        }
        public int GetNote()
        {
            return this.note;
        }
        public bool AjouterBonus(int bonus)
        {
            bool nombreCorrect = false;
            if(bonus > 0 && bonus < 10)
            {
                this.note = this.note + bonus;
                nombreCorrect = true;
            }
            else
                if(bonus < 0 && bonus > -10 )
                {
                this.note = this.note - bonus;
                nombreCorrect = true;
            }
            return nombreCorrect;
        }
        public int NoterCandidature(int uneNote)
        {
            return this.note = uneNote;
        }
    }
}
