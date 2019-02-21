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
        // idOffre de l'offre selectionné
        string idOffre = "";

        public FormNoter()
        {

            InitializeComponent();

            var db = "Host=localhost;Username=postgres;Password=root;Database=AppEval";
            
            using (var connexionDB = new NpgsqlConnection(db))
            {
                connexionDB.Open();

                // Afficher les titre de OFFRE EMPLOI
                using (var Offre = new NpgsqlCommand("SELECT DISTINCT titre FROM OFFRE_EMPLOI", connexionDB))
                using (var AfficheOffre = Offre.ExecuteReader())
                    while (AfficheOffre.Read())
                    {
                        comboBoxOffre.Items.Add(AfficheOffre.GetString(0));
                    }

                comboBoxOffre.SelectedIndex = 0;
            }
      
            using (var connexiondb = new NpgsqlConnection(db))
            {
                connexiondb.Open();

                // Afficher les nomCand ayant fait une CANDIDTAURE en fonction de idOffre
                using (var Candidat = new NpgsqlCommand("SELECT DISTINCT nomCand FROM CANDIDATURE WHERE idOffre = '" + this.idOffre + "' AND statut = 'En Attente'", connexiondb))
                using (var AfficheCand = Candidat.ExecuteReader())
                    while (AfficheCand.Read())
                    {
                        //ajoute les nomcand dans la comboboxcand en precisant son type string
                        comboBoxCandidatures.Items.Add(AfficheCand.GetString(0));
                        
                    }

                comboBoxCandidatures.SelectedIndex = 0;
            }

            using (var connexiondb = new NpgsqlConnection(db))
            {
                connexiondb.Open();

                // Afficher les nomcand ayant fait une candidature en fonction de idoffre
                using (var Critere = new NpgsqlCommand("SELECT libelleCritere FROM CRITERE", connexiondb))
                using (var AfficheCrit = Critere.ExecuteReader())
                    while (AfficheCrit.Read())
                    {
                        //ajoute les nomcand dans la comboboxcand en precisant son type string
                        listBox_Criteres.Items.Add(AfficheCrit.GetString(0));
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
            // Permet de prendre idOffre du titre de l'offre selectionné
            string titre = comboBoxOffre.Text.ToString();

            var db = "Host=localhost;Username=postgres;Password=root;Database=AppEval";
            using (var connexionDB = new NpgsqlConnection(db))
            {
                connexionDB.Open();

                
                using (var idOffre = new NpgsqlCommand("SELECT DISTINCT idOffre FROM OFFRE_EMPLOI WHERE titre = '" + titre + "'", connexionDB))
                using (var SelectId = idOffre.ExecuteReader())
                    while (SelectId.Read())
                    {
                        this.idOffre = SelectId.GetString(0);
                    }

            }
            
            //On clear les valeurs et on relance la requête
            // besoin de refaire fusinné les forms avec les class
            comboBoxCandidatures.Items.Clear();
            using (var connexiondb = new NpgsqlConnection(db))
            {
                connexiondb.Open();

                // Afficher les nomcand ayant fait une candidature en fonction de idoffre
                using (var Candidat = new NpgsqlCommand("SELECT DISTINCT nomCand FROM CANDIDATURE WHERE idOffre = '" + this.idOffre + "' AND statut = 'En Attente'", connexiondb))
                using (var AfficheCand = Candidat.ExecuteReader())
                    while (AfficheCand.Read())
                    {
                        //ajoute les nomcand dans la comboboxcand en precisant son type string
                        comboBoxCandidatures.Items.Add(AfficheCand.GetString(0));

                    }

                comboBoxCandidatures.SelectedIndex = 0;
            }


            // Quand on select une Offre sa prend son id et change les valeurs de Candidatures et relance la requete
            // ou refresh la comboBox Candidatures pour afficher les bonne personnes

        }

        private void FormNoter_Load_1(object sender, EventArgs e)
        {
            
        }

        private void comboBoxCandidatures_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
