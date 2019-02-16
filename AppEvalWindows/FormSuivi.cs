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
    public partial class FormSuivi : Form
    {
        public FormSuivi()
        {
            InitializeComponent();
            var db = "Host=localhost;Username=postgres;Password=root;Database=AppEval";
            using (var connexionDB = new NpgsqlConnection(db))
            {
                connexionDB.Open();

                // Afficher les offre emploi non candidatés
                using (var Offre = new NpgsqlCommand("SELECT DISTINCT titre FROM OFFRE_EMPLOI", connexionDB))
                using (var AfficheOffre = Offre.ExecuteReader())
                    while (AfficheOffre.Read())
                    {
                        comboBoxChoixOffre.Items.Add(AfficheOffre.GetString(0));
                    }


                comboBoxChoixOffre.SelectedIndex = 0;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirnouveauform));
            monthread.Start();
            this.Close(); 
            void ouvrirnouveauform() {
                Application.Run(new FormNoter());
            }
        }

        private void Form2_Noter_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMoyenne_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNoter_Click(object sender, EventArgs e)
        {
            FormNoter f = new FormNoter();
            f.Show();           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        //Pop-up lorsque l'utilisateur quitte l'application.
        private void FormSuivi_FormClosed(object sender, FormClosingEventArgs e)
        {
            string msg = "Voulez allez quitter l'espace de suivie";
            string cap = "Quitter l'espace de suivie AppEval.";
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void buttonAccueil_Click(object sender, EventArgs e)
        {
            this.Close();         
        }

        private void comboBoxChoixOffre_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void groupBoxMeilleurCandidature_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var db = "Server=localhost;Username=postgres;Password=;Database=AppEval";
            //using (var connexionDB = new NpgsqlConnection(db))
            //{
            //    connexionDB.Open();
            //    /// CTRL + K + C commentaire CTRL K + U décommenté
            //    /// Si on selectionne une Offre dans la combobox affiche dans dataGridView2 les candidatures CANDIDATÉ
            //    using (var offrecand = new npgsqlcommand("select * from candidature where idoffre = idoffre and statut != 'refusé' ", connexiondb))
            //    using (var afficheoffrecand = offrecand.executereader())
            //        while (afficheoffrecand.read())
            //        {
            //            datagridview2_CellContentClick.items.add(afficheoffrecand.getstring(0));
            //        }

            //}
        }
    }
}
