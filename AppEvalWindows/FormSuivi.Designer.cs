namespace AppEvalWindows
{
    partial class FormSuivi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxMeilleurCandidature = new System.Windows.Forms.GroupBox();
            this.buttonAccueil = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.labelMoyenneMeilleure = new System.Windows.Forms.Label();
            this.textBoxMoyenneMeilleure = new System.Windows.Forms.TextBox();
            this.buttonAccepter = new System.Windows.Forms.Button();
            this.buttonRefuser = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBoxListCandidat = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelOffre = new System.Windows.Forms.Label();
            this.comboBoxChoixOffre = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxMeilleurCandidature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBoxListCandidat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(925, 135);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBoxMeilleurCandidature
            // 
            this.groupBoxMeilleurCandidature.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBoxMeilleurCandidature.Controls.Add(this.buttonAccueil);
            this.groupBoxMeilleurCandidature.Controls.Add(this.buttonQuitter);
            this.groupBoxMeilleurCandidature.Controls.Add(this.dataGridView1);
            this.groupBoxMeilleurCandidature.Controls.Add(this.labelMoyenneMeilleure);
            this.groupBoxMeilleurCandidature.Controls.Add(this.textBoxMoyenneMeilleure);
            this.groupBoxMeilleurCandidature.Location = new System.Drawing.Point(16, 262);
            this.groupBoxMeilleurCandidature.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMeilleurCandidature.Name = "groupBoxMeilleurCandidature";
            this.groupBoxMeilleurCandidature.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMeilleurCandidature.Size = new System.Drawing.Size(961, 217);
            this.groupBoxMeilleurCandidature.TabIndex = 3;
            this.groupBoxMeilleurCandidature.TabStop = false;
            this.groupBoxMeilleurCandidature.Text = "Les meilleures candidatures:";
            this.groupBoxMeilleurCandidature.Enter += new System.EventHandler(this.groupBoxMeilleurCandidature_Enter);
            // 
            // buttonAccueil
            // 
            this.buttonAccueil.Location = new System.Drawing.Point(379, 166);
            this.buttonAccueil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAccueil.Name = "buttonAccueil";
            this.buttonAccueil.Size = new System.Drawing.Size(120, 43);
            this.buttonAccueil.TabIndex = 12;
            this.buttonAccueil.Text = "Accueil";
            this.buttonAccueil.UseVisualStyleBackColor = true;
            this.buttonAccueil.Click += new System.EventHandler(this.buttonAccueil_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(507, 166);
            this.buttonQuitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(120, 43);
            this.buttonQuitter.TabIndex = 11;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // labelMoyenneMeilleure
            // 
            this.labelMoyenneMeilleure.AutoSize = true;
            this.labelMoyenneMeilleure.Location = new System.Drawing.Point(12, 180);
            this.labelMoyenneMeilleure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMoyenneMeilleure.Name = "labelMoyenneMeilleure";
            this.labelMoyenneMeilleure.Size = new System.Drawing.Size(204, 17);
            this.labelMoyenneMeilleure.TabIndex = 4;
            this.labelMoyenneMeilleure.Text = "Moyenne des meilleures notes:";
            this.labelMoyenneMeilleure.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxMoyenneMeilleure
            // 
            this.textBoxMoyenneMeilleure.Location = new System.Drawing.Point(225, 176);
            this.textBoxMoyenneMeilleure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMoyenneMeilleure.Name = "textBoxMoyenneMeilleure";
            this.textBoxMoyenneMeilleure.ReadOnly = true;
            this.textBoxMoyenneMeilleure.Size = new System.Drawing.Size(119, 22);
            this.textBoxMoyenneMeilleure.TabIndex = 5;
            this.textBoxMoyenneMeilleure.TextChanged += new System.EventHandler(this.textBoxMoyenne_TextChanged);
            // 
            // buttonAccepter
            // 
            this.buttonAccepter.Location = new System.Drawing.Point(343, 182);
            this.buttonAccepter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAccepter.Name = "buttonAccepter";
            this.buttonAccepter.Size = new System.Drawing.Size(100, 34);
            this.buttonAccepter.TabIndex = 7;
            this.buttonAccepter.Text = "Accepter";
            this.buttonAccepter.UseVisualStyleBackColor = true;
            // 
            // buttonRefuser
            // 
            this.buttonRefuser.Location = new System.Drawing.Point(451, 182);
            this.buttonRefuser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRefuser.Name = "buttonRefuser";
            this.buttonRefuser.Size = new System.Drawing.Size(100, 34);
            this.buttonRefuser.TabIndex = 8;
            this.buttonRefuser.Text = "Refuser";
            this.buttonRefuser.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 28);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(615, 143);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // groupBoxListCandidat
            // 
            this.groupBoxListCandidat.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBoxListCandidat.Controls.Add(this.dataGridView2);
            this.groupBoxListCandidat.Controls.Add(this.buttonRefuser);
            this.groupBoxListCandidat.Controls.Add(this.label1);
            this.groupBoxListCandidat.Controls.Add(this.textBox1);
            this.groupBoxListCandidat.Controls.Add(this.buttonAccepter);
            this.groupBoxListCandidat.Location = new System.Drawing.Point(327, 15);
            this.groupBoxListCandidat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxListCandidat.Name = "groupBoxListCandidat";
            this.groupBoxListCandidat.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxListCandidat.Size = new System.Drawing.Size(651, 240);
            this.groupBoxListCandidat.TabIndex = 2;
            this.groupBoxListCandidat.TabStop = false;
            this.groupBoxListCandidat.Text = "Liste des candidatures:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Moyenne des notes:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 188);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(145, 22);
            this.textBox1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBox1.Controls.Add(this.labelOffre);
            this.groupBox1.Controls.Add(this.comboBoxChoixOffre);
            this.groupBox1.Controls.Add(this.dataGridView3);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(303, 240);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des Offres";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelOffre
            // 
            this.labelOffre.AutoSize = true;
            this.labelOffre.Location = new System.Drawing.Point(4, 129);
            this.labelOffre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOffre.Name = "labelOffre";
            this.labelOffre.Size = new System.Drawing.Size(200, 17);
            this.labelOffre.TabIndex = 14;
            this.labelOffre.Text = "Informations de l\'offre choisie :";
            // 
            // comboBoxChoixOffre
            // 
            this.comboBoxChoixOffre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChoixOffre.FormattingEnabled = true;
            this.comboBoxChoixOffre.Location = new System.Drawing.Point(8, 28);
            this.comboBoxChoixOffre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxChoixOffre.Name = "comboBoxChoixOffre";
            this.comboBoxChoixOffre.Size = new System.Drawing.Size(271, 24);
            this.comboBoxChoixOffre.TabIndex = 13;
            this.comboBoxChoixOffre.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoixOffre_SelectedIndexChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(8, 162);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(272, 46);
            this.dataGridView3.TabIndex = 12;
            // 
            // FormSuivi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 492);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxMeilleurCandidature);
            this.Controls.Add(this.groupBoxListCandidat);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSuivi";
            this.Text = "eKara Suivi des Candidatures";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSuivi_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Noter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxMeilleurCandidature.ResumeLayout(false);
            this.groupBoxMeilleurCandidature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBoxListCandidat.ResumeLayout(false);
            this.groupBoxListCandidat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxMeilleurCandidature;
        private System.Windows.Forms.Label labelMoyenneMeilleure;
        private System.Windows.Forms.TextBox textBoxMoyenneMeilleure;
        private System.Windows.Forms.Button buttonAccepter;
        private System.Windows.Forms.Button buttonRefuser;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBoxListCandidat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAccueil;
        private System.Windows.Forms.Label labelOffre;
        private System.Windows.Forms.ComboBox comboBoxChoixOffre;
    }
}