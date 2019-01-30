namespace AppEvalWindows
{
    partial class FormAccueil
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
            this.groupBoxAccueil = new System.Windows.Forms.GroupBox();
            this.buttonConsulter = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelBienvenue = new System.Windows.Forms.Label();
            this.groupBoxAccueil.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAccueil
            // 
            this.groupBoxAccueil.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBoxAccueil.Controls.Add(this.buttonConsulter);
            this.groupBoxAccueil.Controls.Add(this.button2);
            this.groupBoxAccueil.Controls.Add(this.button1);
            this.groupBoxAccueil.Controls.Add(this.labelBienvenue);
            this.groupBoxAccueil.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAccueil.Name = "groupBoxAccueil";
            this.groupBoxAccueil.Size = new System.Drawing.Size(361, 168);
            this.groupBoxAccueil.TabIndex = 0;
            this.groupBoxAccueil.TabStop = false;
            this.groupBoxAccueil.Text = "Accueil";
            // 
            // buttonConsulter
            // 
            this.buttonConsulter.Location = new System.Drawing.Point(124, 68);
            this.buttonConsulter.Name = "buttonConsulter";
            this.buttonConsulter.Size = new System.Drawing.Size(108, 66);
            this.buttonConsulter.TabIndex = 3;
            this.buttonConsulter.Text = "Noter une candidature";
            this.buttonConsulter.UseVisualStyleBackColor = true;
            this.buttonConsulter.Click += new System.EventHandler(this.buttonNoter_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 66);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ajouter un critère";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonAjout_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Consulter les candidatures";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonConsulter_Click);
            // 
            // labelBienvenue
            // 
            this.labelBienvenue.AutoSize = true;
            this.labelBienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenue.Location = new System.Drawing.Point(103, 16);
            this.labelBienvenue.Name = "labelBienvenue";
            this.labelBienvenue.Size = new System.Drawing.Size(158, 18);
            this.labelBienvenue.TabIndex = 0;
            this.labelBienvenue.Text = "Bienvenue sur AppEval";
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 192);
            this.Controls.Add(this.groupBoxAccueil);
            this.Name = "FormAccueil";
            this.Text = "AppEval - Accueil ";
            this.Load += new System.EventHandler(this.FormAccueil_Load);
            this.groupBoxAccueil.ResumeLayout(false);
            this.groupBoxAccueil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAccueil;
        private System.Windows.Forms.Label labelBienvenue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonConsulter;
    }
}