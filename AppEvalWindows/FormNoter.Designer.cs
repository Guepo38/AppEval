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
            this.listBox2 = new System.Windows.Forms.ListBox();
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
            this.groupBoxNoter.Location = new System.Drawing.Point(10, 5);
            this.groupBoxNoter.Name = "groupBoxNoter";
            this.groupBoxNoter.Size = new System.Drawing.Size(240, 228);
            this.groupBoxNoter.TabIndex = 0;
            this.groupBoxNoter.TabStop = false;
            this.groupBoxNoter.Text = "Noter une candidature";
            this.groupBoxNoter.Enter += new System.EventHandler(this.groupBoxNoter_Enter);
            // 
            // comboBoxOffre
            // 
            this.comboBoxOffre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOffre.FormattingEnabled = true;
            this.comboBoxOffre.Location = new System.Drawing.Point(9, 55);
            this.comboBoxOffre.Name = "comboBoxOffre";
            this.comboBoxOffre.Size = new System.Drawing.Size(191, 23);
            this.comboBoxOffre.TabIndex = 3;
            this.comboBoxOffre.SelectedIndexChanged += new System.EventHandler(this.comboBoxOffre_SelectedIndexChanged);
            // 
            // labelOffre
            // 
            this.labelOffre.AutoSize = true;
            this.labelOffre.Location = new System.Drawing.Point(6, 27);
            this.labelOffre.Name = "labelOffre";
            this.labelOffre.Size = new System.Drawing.Size(135, 15);
            this.labelOffre.TabIndex = 2;
            this.labelOffre.Text = "Selectionnez une offre :";
            // 
            // comboBoxCandidatures
            // 
            this.comboBoxCandidatures.FormattingEnabled = true;
            this.comboBoxCandidatures.Location = new System.Drawing.Point(9, 155);
            this.comboBoxCandidatures.Name = "comboBoxCandidatures";
            this.comboBoxCandidatures.Size = new System.Drawing.Size(191, 23);
            this.comboBoxCandidatures.TabIndex = 1;
            // 
            // labelChoixNote
            // 
            this.labelChoixNote.AutoSize = true;
            this.labelChoixNote.Location = new System.Drawing.Point(6, 134);
            this.labelChoixNote.Name = "labelChoixNote";
            this.labelChoixNote.Size = new System.Drawing.Size(194, 15);
            this.labelChoixNote.TabIndex = 0;
            this.labelChoixNote.Text = "Choisissez la candidature à noter :";
            // 
            // buttonAccueil
            // 
            this.buttonAccueil.Location = new System.Drawing.Point(116, 184);
            this.buttonAccueil.Name = "buttonAccueil";
            this.buttonAccueil.Size = new System.Drawing.Size(90, 35);
            this.buttonAccueil.TabIndex = 13;
            this.buttonAccueil.Text = "Quitter";
            this.buttonAccueil.UseVisualStyleBackColor = true;
            this.buttonAccueil.Click += new System.EventHandler(this.buttonAccueil_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(6, 55);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(200, 94);
            this.listBox2.TabIndex = 14;
            // 
            // labelChoixCritere
            // 
            this.labelChoixCritere.AutoSize = true;
            this.labelChoixCritere.Location = new System.Drawing.Point(3, 27);
            this.labelChoixCritere.Name = "labelChoixCritere";
            this.labelChoixCritere.Size = new System.Drawing.Size(163, 15);
            this.labelChoixCritere.TabIndex = 15;
            this.labelChoixCritere.Text = "Choisissez le critère à noter :";
            // 
            // groupBoxCritere
            // 
            this.groupBoxCritere.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBoxCritere.Controls.Add(this.buttonNoter);
            this.groupBoxCritere.Controls.Add(this.comboBoxNotes);
            this.groupBoxCritere.Controls.Add(this.labelChoixCritere);
            this.groupBoxCritere.Controls.Add(this.listBox2);
            this.groupBoxCritere.Controls.Add(this.buttonAccueil);
            this.groupBoxCritere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCritere.Location = new System.Drawing.Point(256, 5);
            this.groupBoxCritere.Name = "groupBoxCritere";
            this.groupBoxCritere.Size = new System.Drawing.Size(240, 228);
            this.groupBoxCritere.TabIndex = 16;
            this.groupBoxCritere.TabStop = false;
            this.groupBoxCritere.Text = "Les critères";
            // 
            // buttonNoter
            // 
            this.buttonNoter.Location = new System.Drawing.Point(6, 184);
            this.buttonNoter.Name = "buttonNoter";
            this.buttonNoter.Size = new System.Drawing.Size(90, 35);
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
            "5"});
            this.comboBoxNotes.Location = new System.Drawing.Point(6, 155);
            this.comboBoxNotes.Name = "comboBoxNotes";
            this.comboBoxNotes.Size = new System.Drawing.Size(200, 23);
            this.comboBoxNotes.TabIndex = 16;
            this.comboBoxNotes.SelectedIndexChanged += new System.EventHandler(this.comboBoxNotes_SelectedIndexChanged);
            // 
            // FormNoter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 248);
            this.Controls.Add(this.groupBoxCritere);
            this.Controls.Add(this.groupBoxNoter);
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
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupBoxCritere;
        private System.Windows.Forms.Button buttonNoter;
        private System.Windows.Forms.ComboBox comboBoxNotes;
        private System.Windows.Forms.ComboBox comboBoxCandidatures;
        private System.Windows.Forms.ComboBox comboBoxOffre;
        private System.Windows.Forms.Label labelOffre;
    }
}