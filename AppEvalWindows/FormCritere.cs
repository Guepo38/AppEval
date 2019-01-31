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
    public partial class FormCritere : Form
    {
        public FormCritere()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCoeff f = new FormCoeff();
            f.Show();
        }

        private void buttonAccueil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCritere_FormClosed(object sender, FormClosingEventArgs e)
        {
            string msg = "Voulez allez quitter l'espace d'ajout de critère";
            string cap = "Quitter l'espace d'ajout de critère AppEval.";
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
            
        }

        private void FormCritere_Load(object sender, EventArgs e)
        {
            var connString = "Server=localhost;Username=postgres;Password=;Database=AppEval";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT titre FROM offre_emploi", conn))
                using (var titre = cmd.ExecuteReader())
                    while (titre.Read())
                    {
                        comboBoxOffre.Items.Add(titre.GetString(0));
                    }

                using (var cmd2 = new NpgsqlCommand("SELECT libellecritere FROM critere", conn))
                using (var critere = cmd2.ExecuteReader())
                    while (critere.Read())
                    {
                        string[] stateList = new string[50];

                        for (int i = 1; i <= 50; i++)
                        {
                            stateList[i - 1] = critere.GetString(0);
                        }

                        for (int i = 0; i < stateList.Length; i++)
                        {
                            listBoxCritereEmploi.Items.Add(stateList[i].ToString());
                        }
                    }
            }
        }

        private void listBoxCritereEmploi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
