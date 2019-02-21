namespace AppEvalWindows
{
    partial class FormNoter
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
            this.groupBoxNoter = new System.Windows.Forms.GroupBox();
            this.comboBoxOffre = new System.Windows.Forms.ComboBox();
            this.labelOffre = new System.Windows.Forms.Label();
            this.comboBoxCandidatures = new System.Windows.Forms.ComboBox();
            this.labelChoixNote = new System.Windows.Forms.Label();
            this.buttonAccueil = new System.Windows.Forms.Button();
            this.listBox_Criteres = new System.Windows.Forms.ListBox();
            this.labelChoixCritere = new System.Windows.Forms.Label();
            this.groupBoxCritere = new System.Windows.Forms.GroupBox();
            this.buttonNoter = new System.Windows.Forms.Button();
            this.comboBoxNotes = new System.Windows.Forms.ComboBox();
            this.groupBoxNoter.SuspendLayout();
            this.groupBoxCritere.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNoter
            // 
            this.groupBoxNoter.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBoxNoter.Controls.Add(this.comboBoxOffre);
            this.groupBoxNoter.Controls.Add(this.labelOffre);
            this.groupBoxNoter.Controls.Add(this.comboBoxCandidatures);
            this.groupBoxNoter.Controls.Add(this.labelChoixNote);
            this.groupBoxNoter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNoter.Location = new System.Drawing.Point(13, 6);
            this.groupBoxNoter.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxNoter.Name = "groupBoxNoter";
            this.groupBoxNoter.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxNoter.Size = new System.Drawing.Size(320, 281);
            this.groupBoxNoter.TabIndex = 0;
            this.groupBoxNoter.TabStop = false;
            this.groupBoxNoter.Text = "Noter une candidature";
            this.groupBoxNoter.Enter += new System.EventHandler(this.groupBoxNoter_Enter);
            // 
            // comboBoxOffre
            // 
            this.comboBoxOffre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOffre.FormattingEnabled = true;
            this.comboBoxOffre.Location = new System.Drawing.Point(12, 68);
            this.comboBoxOffre.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxOffre.Name = "comboBoxOffre";
            this.comboBoxOffre.Size = new System.Drawing.Size(253, 26);
            this.comboBoxOffre.TabIndex = 3;
            this.comboBoxOffre.SelectedIndexChanged += new System.EventHandler(this.comboBoxOffre_SelectedIndexChanged);
            // 
            // labelOffre
            // 
            this.labelOffre.AutoSize = true;
            this.labelOffre.Location = new System.Drawing.Point(8, 33);
            this.labelOffre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOffre.Name = "labelOffre";
            this.labelOffre.Size = new System.Drawing.Size(163, 18);
            this.labelOffre.TabIndex = 2;
            this.labelOffre.Text = "Selectionnez une offre :";
            // 
            // comboBoxCandidatures
            // 
            this.comboBoxCandidatures.FormattingEnabled = true;
            this.comboBoxCandidatures.Location = new System.Drawing.Point(12, 191);
            this.comboBoxCandidatures.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCandidatures.Name = "comboBoxCandidatures";
            this.comboBoxCandidatures.Size = new System.Drawing.Size(253, 26);
            this.comboBoxCandidatures.TabIndex = 1;
            this.comboBoxCandidatures.SelectedIndexChanged += new System.EventHandler(this.comboBoxCandidatures_SelectedIndexChanged);
            // 
            // labelChoixNote
            // 
            this.labelChoixNote.AutoSize = true;
            this.labelChoixNote.Location = new System.Drawing.Point(8, 165);
            this.labelChoixNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChoixNote.Name = "labelChoixNote";
            this.labelChoixNote.Size = new System.Drawing.Size(235, 18);
            this.labelChoixNote.TabIndex = 0;
            this.labelChoixNote.Text = "Choisissez la candidature à noter :";
            // 
            // buttonAccueil
            // 
            this.buttonAccueil.Location = new System.Drawing.Point(155, 226);
            this.buttonAccueil.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAccueil.Name = "buttonAccueil";
            this.buttonAccueil.Size = new System.Drawing.Size(120, 43);
            this.buttonAccueil.TabIndex = 13;
            this.buttonAccueil.Text = "Quitter";
            this.buttonAccueil.UseVisualStyleBackColor = true;
            this.buttonAccueil.Click += new System.EventHandler(this.buttonAccueil_Click);
            // 
            // listBox_Criteres
            // 
            this.listBox_Criteres.FormattingEnabled = true;
            this.listBox_Criteres.ItemHeight = 18;
            this.listBox_Criteres.Location = new System.Drawing.Point(8, 68);
            this.listBox_Criteres.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_Criteres.Name = "listBox_Criteres";
            this.listBox_Criteres.Size = new System.Drawing.Size(265, 112);
            this.listBox_Criteres.TabIndex = 14;
            this.listBox_Criteres.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // labelChoixCritere
            // 
            this.labelChoixCritere.AutoSize = true;
            this.labelChoixCritere.Location = new System.Drawing.Point(4, 33);
            this.labelChoixCritere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChoixCritere.Name = "labelChoixCritere";
            this.labelChoixCritere.Size = new System.Drawing.Size(200, 18);
            this.labelChoixCritere.TabIndex = 15;
            this.labelChoixCritere.Text = "Choisissez le critère à noter :";
            // 
            // groupBoxCritere
            // 
            this.groupBoxCritere.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBoxCritere.Controls.Add(this.buttonNoter);
            this.groupBoxCritere.Controls.Add(this.comboBoxNotes);
            this.groupBoxCritere.Controls.Add(this.labelChoixCritere);
            this.groupBoxCritere.Controls.Add(this.listBox_Criteres);
            this.groupBoxCritere.Controls.Add(this.buttonAccueil);
            this.groupBoxCritere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCritere.Location = new System.Drawing.Point(341, 6);
            this.groupBoxCritere.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCritere.Name = "groupBoxCritere";
            this.groupBoxCritere.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCritere.Size = new System.Drawing.Size(320, 281);
            this.groupBoxCritere.TabIndex = 16;
            this.groupBoxCritere.TabStop = false;
            this.groupBoxCritere.Text = "Les critères";
            // 
            // buttonNoter
            // 
            this.buttonNoter.Location = new System.Drawing.Point(8, 226);
            this.buttonNoter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNoter.Name = "buttonNoter";
            this.buttonNoter.Size = new System.Drawing.Size(120, 43);
            this.buttonNoter.TabIndex = 18;
            this.buttonNoter.Text = "Noter";
            this.buttonNoter.UseVisualStyleBackColor = true;
            this.buttonNoter.Click += new System.EventHandler(this.buttonNoter_Click);
            // 
            // comboBoxNotes
            // 
            this.comboBoxNotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNotes.FormattingEnabled = true;
            this.comboBoxNotes.Items.AddRange(new object[] {
            "Choisir une note",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxNotes.Location = new System.Drawing.Point(8, 191);
            this.comboBoxNotes.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxNotes.Name = "comboBoxNotes";
            this.comboBoxNotes.Size = new System.Drawing.Size(265, 26);
            this.comboBoxNotes.TabIndex = 16;
            this.comboBoxNotes.SelectedIndexChanged += new System.EventHandler(this.comboBoxNotes_SelectedIndexChanged);
            // 
            // FormNoter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 305);
            this.Controls.Add(this.groupBoxCritere);
            this.Controls.Add(this.groupBoxNoter);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNoter";
            this.Text = "FormNoter";
            this.Load += new System.EventHandler(this.FormNoter_Load_1);
            this.groupBoxNoter.ResumeLayout(false);
            this.groupBoxNoter.PerformLayout();
            this.groupBoxCritere.ResumeLayout(false);
            this.groupBoxCritere.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNoter;
        private System.Windows.Forms.Label labelChoixNote;
        private System.Windows.Forms.Button buttonAccueil;
        private System.Windows.Forms.Label labelChoixCritere;
        private System.Windows.Forms.ListBox listBox_Criteres;
        private System.Windows.Forms.GroupBox groupBoxCritere;
        private System.Windows.Forms.Button buttonNoter;
        private System.Windows.Forms.ComboBox comboBoxNotes;
        private System.Windows.Forms.ComboBox comboBoxCandidatures;
        private System.Windows.Forms.ComboBox comboBoxOffre;
        private System.Windows.Forms.Label labelOffre;
    }
}