using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace AppEvalWindows
{
    public partial class FormNoter : Form
    {
        string idOffre = "";
        public FormNoter()
        {
            InitializeComponent();
            var db = "Server=localhost;Username=postgres;Password=;Database=AppEval";
            using (var connexionDB = new NpgsqlConnection(db))
            {
                connexionDB.Open();

                // Afficher les offre emploi
                using (var Offre = new NpgsqlCommand("SELECT DISTINCT titre FROM OFFRE_EMPLOI", connexionDB))
                using (var AfficheOffre = Offre.ExecuteReader())
                    while (AfficheOffre.Read())
                    {
                        comboBoxOffre.Items.Add(AfficheOffre.GetString(0));
                    }

                comboBoxOffre.SelectedIndex = 0;
            }

            using (var connexionDB = new NpgsqlConnection(db))
            {
                connexionDB.Open();

                // Afficher les offre emploi
                using (var Offre = new NpgsqlCommand("SELECT DISTINCT nomcand FROM candidature WHERE idOffre = '" + this.idOffre + "'", connexionDB))
                using (var AfficheOffre = Offre.ExecuteReader())
                    while (AfficheOffre.Read())
                    {
                        comboBoxCandidatures.Items.Add(AfficheOffre.GetString(0));
                    }

                comboBoxCandidatures.SelectedIndex = 0;
            }

        }

        private void groupBoxNoter_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAccueil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxNotes.SelectedItem = 0;
        }

        private void buttonNoter_Click(object sender, EventArgs e)
        {

        }
        private void FormCritere_FormClosed(object sender, FormClosingEventArgs e)
        {
            string msg = "Voulez allez quitter l'espace de notation";
            string cap = "Quitter l'espace de notation AppEval.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon ico = MessageBoxIcon.Question;

            DialogResult result;
            result = MessageBox.Show(this, msg, cap, buttons, ico);

            //Si clique sur oui, on quitte l'application.
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
                System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirnouveauform));
                monthread.Start();
                void ouvrirnouveauform()
                {
                    Application.Run(new FormAccueil());
                }
            }
            //Sinon on reste dessus.
            else
            {
                e.Cancel = true;

            }

        }

        private void comboBoxOffre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string titre = comboBoxOffre.Text.ToString();
            var db = "Server=localhost;Username=postgres;Password=;Database=AppEval";
            using (var connexionDB = new NpgsqlConnection(db))
            {
                connexionDB.Open();

                // Afficher les offre emploi
                using (var Offre = new NpgsqlCommand("SELECT DISTINCT idOffre FROM OFFRE_EMPLOI WHERE titre = '" + titre + "'", connexionDB))
                using (var AfficheOffre = Offre.ExecuteReader())
                    while (AfficheOffre.Read())
                    {
                        this.idOffre = AfficheOffre.GetString(0);
                    }

            }
        }

        private void FormNoter_Load_1(object sender, EventArgs e)
        {
          
        }
    }
}
