namespace AppEvalWindows
{
    partial class FormCritere
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
            this.labelAjout = new System.Windows.Forms.Label();
            this.textBoxAjout = new System.Windows.Forms.TextBox();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.groupBoxCritere = new System.Windows.Forms.GroupBox();
            this.comboBoxOffre = new System.Windows.Forms.ComboBox();
            this.buttonAccueil = new System.Windows.Forms.Button();
            this.labelListCritere = new System.Windows.Forms.Label();
            this.listBoxCritereEmploi = new System.Windows.Forms.ListBox();
            this.labelListOffresEmplois = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelModifDate = new System.Windows.Forms.Label();
            this.dateTimePickerDateLimite = new System.Windows.Forms.DateTimePicker();
            this.groupBoxCritere.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAjout
            // 
            this.labelAjout.AutoSize = true;
            this.labelAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAjout.Location = new System.Drawing.Point(219, 113);
            this.labelAjout.Name = "labelAjout";
            this.labelAjout.Size = new System.Drawing.Size(89, 13);
            this.labelAjout.TabIndex = 0;
            this.labelAjout.Text = "Nouveau critère :";
            this.labelAjout.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxAjout
            // 
            this.textBoxAjout.Location = new System.Drawing.Point(314, 110);
            this.textBoxAjout.Name = "textBoxAjout";
            this.textBoxAjout.Size = new System.Drawing.Size(92, 21);
            this.textBoxAjout.TabIndex = 1;
            this.textBoxAjout.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(314, 136);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(92, 28);
            this.buttonAjouter.TabIndex = 2;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxCritere
            // 
            this.groupBoxCritere.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBoxCritere.Controls.Add(this.dateTimePickerDateLimite);
            this.groupBoxCritere.Controls.Add(this.labelModifDate);
            this.groupBoxCritere.Controls.Add(this.comboBoxOffre);
            this.groupBoxCritere.Controls.Add(this.buttonAccueil);
            this.groupBoxCritere.Controls.Add(this.labelListCritere);
            this.groupBoxCritere.Controls.Add(this.listBoxCritereEmploi);
            this.groupBoxCritere.Controls.Add(this.labelListOffresEmplois);
            this.groupBoxCritere.Controls.Add(this.buttonAjouter);
            this.groupBoxCritere.Controls.Add(this.textBoxAjout);
            this.groupBoxCritere.Controls.Add(this.labelAjout);
            this.groupBoxCritere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCritere.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCritere.Name = "groupBoxCritere";
            this.groupBoxCritere.Size = new System.Drawing.Size(437, 260);
            this.groupBoxCritere.TabIndex = 3;
            this.groupBoxCritere.TabStop = false;
            this.groupBoxCritere.Text = "Ajout d\'un critère";
            // 
            // comboBoxOffre
            // 
            this.comboBoxOffre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOffre.FormattingEnabled = true;
            this.comboBoxOffre.Location = new System.Drawing.Point(10, 53);
            this.comboBoxOffre.Name = "comboBoxOffre";
            this.comboBoxOffre.Size = new System.Drawing.Size(162, 23);
            this.comboBoxOffre.Sorted = true;
            this.comboBoxOffre.TabIndex = 14;
            this.comboBoxOffre.SelectedIndexChanged += new System.EventHandler(this.comboBoxOffre_SelectedIndexChanged);
            // 
            // buttonAccueil
            // 
            this.buttonAccueil.Location = new System.Drawing.Point(314, 192);
            this.buttonAccueil.Name = "buttonAccueil";
            this.buttonAccueil.Size = new System.Drawing.Size(90, 35);
            this.buttonAccueil.TabIndex = 13;
            this.buttonAccueil.Text = "Accueil";
            this.buttonAccueil.UseVisualStyleBackColor = true;
            this.buttonAccueil.Click += new System.EventHandler(this.buttonAccueil_Click);
            // 
            // labelListCritere
            // 
            this.labelListCritere.AutoSize = true;
            this.labelListCritere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListCritere.Location = new System.Drawing.Point(7, 92);
            this.labelListCritere.Name = "labelListCritere";
            this.labelListCritere.Size = new System.Drawing.Size(160, 15);
            this.labelListCritere.TabIndex = 6;
            this.labelListCritere.Text = "Les critères pour cette offre :";
            // 
            // listBoxCritereEmploi
            // 
            this.listBoxCritereEmploi.FormattingEnabled = true;
            this.listBoxCritereEmploi.ItemHeight = 15;
            this.listBoxCritereEmploi.Location = new System.Drawing.Point(10, 110);
            this.listBoxCritereEmploi.Name = "listBoxCritereEmploi";
            this.listBoxCritereEmploi.Size = new System.Drawing.Size(203, 109);
            this.listBoxCritereEmploi.TabIndex = 5;
            this.listBoxCritereEmploi.SelectedIndexChanged += new System.EventHandler(this.listBoxCritereEmploi_SelectedIndexChanged);
            // 
            // labelListOffresEmplois
            // 
            this.labelListOffresEmplois.AutoSize = true;
            this.labelListOffresEmplois.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListOffresEmplois.Location = new System.Drawing.Point(7, 35);
            this.labelListOffresEmplois.Name = "labelListOffresEmplois";
            this.labelListOffresEmplois.Size = new System.Drawing.Size(123, 15);
            this.labelListOffresEmplois.TabIndex = 4;
            this.labelListOffresEmplois.Text = "Les offres d\'emplois :";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // labelModifDate
            // 
            this.labelModifDate.AutoSize = true;
            this.labelModifDate.Location = new System.Drawing.Point(219, 35);
            this.labelModifDate.Name = "labelModifDate";
            this.labelModifDate.Size = new System.Drawing.Size(131, 15);
            this.labelModifDate.TabIndex = 15;
            this.labelModifDate.Text = "Modifier la date limite :";
            this.labelModifDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePickerDateLimite
            // 
            this.dateTimePickerDateLimite.Location = new System.Drawing.Point(222, 55);
            this.dateTimePickerDateLimite.Name = "dateTimePickerDateLimite";
            this.dateTimePickerDateLimite.Size = new System.Drawing.Size(128, 21);
            this.dateTimePickerDateLimite.TabIndex = 16;
            // 
            // FormCritere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 284);
            this.Controls.Add(this.groupBoxCritere);
            this.Name = "FormCritere";
            this.Text = "Formulaire d\'ajout des critères";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCritere_FormClosed);
            this.Load += new System.EventHandler(this.FormCritere_Load);
            this.groupBoxCritere.ResumeLayout(false);
            this.groupBoxCritere.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAjout;
        private System.Windows.Forms.TextBox textBoxAjout;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.GroupBox groupBoxCritere;
        private System.Windows.Forms.Label labelListCritere;
        private System.Windows.Forms.ListBox listBoxCritereEmploi;
        private System.Windows.Forms.Label labelListOffresEmplois;
        private System.Windows.Forms.Button buttonAccueil;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBoxOffre;
        private System.Windows.Forms.Label labelModifDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateLimite;
    }
}