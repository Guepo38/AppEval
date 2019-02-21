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

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Username=postgres;Password=;Database=AppEval");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO critere(libelleCritere, coeff, idOffre) VALUES('" + textBoxAjout.Text + "','" + comboBoxCoeff.SelectedItem.ToString() + "',1)", conn);
            NpgsqlDataReader criteres = cmd.ExecuteReader();
            criteres.Close();
            conn.Close();
            MessageBox.Show("Vous avez ajouté un nouveau critère");
            textBoxAjout.Clear();
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
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Username=postgres;Password=root;Database=AppEval");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * from CRITERE ", conn); //where idOffre = '" + comboBoxOffre.SelectedItem.ToString() + "'
            NpgsqlDataReader criteres = cmd.ExecuteReader();
            while (criteres.Read())
            {
                listBoxCritereEmploi.Items.Add(criteres.GetValue(0));
            }
            criteres.Close();
            conn.Close();
        }

        private void FormCritere_Load(object sender, EventArgs e)
        {
            var connString = "Server=localhost;Username=postgres;Password=root;Database=AppEval";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT titre FROM offre_emploi", conn))
                using (var titre = cmd.ExecuteReader())
                    while (titre.Read())
                    {
                        comboBoxOffre.Items.Add(titre.GetString(0));
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

        private void dateTimePickerDateLimite_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerDateLimite.MinDate = new DateTime(2019, 2, 1);
            dateTimePickerDateLimite.MaxDate = new DateTime(2021, 2, 1);

        }
    }
}
