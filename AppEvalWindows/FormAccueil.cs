using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEvalWindows
{
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent();
        }

        private void labelBienvenue_Click(object sender, EventArgs e)
        {

        }

        private void buttonConsulter_Click(object sender, EventArgs e)
        {                  
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirnouveauform));
            monthread.Start();
            this.Close();           
             void ouvrirnouveauform()
            {
                Application.Run(new FormSuivi());
            }
        }

        private void buttonAjout_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirnouveauform));
            monthread.Start();
            this.Close();
            void ouvrirnouveauform()
            {
                Application.Run(new FormCritere());
            }
        }

        private void FormAccueil_Load(object sender, EventArgs e)
        {

        }

        private void buttonNoter_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirnouveauform));
            monthread.Start();
            this.Close();
            void ouvrirnouveauform()
            {
                Application.Run(new FormNoter());
            }
        }
    }
}
