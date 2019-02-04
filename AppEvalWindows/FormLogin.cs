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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {

            bool btnFound = false;
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Username=postgres;Password=;Database=AppEval");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * from RH where loginrh = '" + textBoxLogin.Text + "' and password = '" + textBoxPassword.Text + "'", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                btnFound = true;
                this.Close();
                System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirnouveauform));
                monthread.Start();
                void ouvrirnouveauform()
                {
                    Application.Run(new FormAccueil());
                }
            }
            if(btnFound == false)
            {
                MessageBox.Show("Votre nom de compte ou votre mot de passe est faux. Veuillez réessayer s'il vous plaît.");
            }
            dr.Close();
            conn.Close();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            string msg = "Voulez allez quitter l'application AppEval";
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
                    Application.Run(new FormLogin());
                }
            }
            //Sinon on reste dessus.
            else
            {
                e.Cancel = true;
            }
        }
    }
}
