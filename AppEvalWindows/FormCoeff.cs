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
    public partial class FormCoeff : Form
    {
        public FormCoeff()
        {
            InitializeComponent();
        }

        private void labelOffreEmploi_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAjoutCoeff_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Nouveau critère ajouté", "Critère ajouté");
        }
    }
}
