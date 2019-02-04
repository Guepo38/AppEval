namespace AppEvalWindows
{
    partial class FormLogin
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
            this.groupBoxConnexion = new System.Windows.Forms.GroupBox();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.groupBoxConnexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConnexion
            // 
            this.groupBoxConnexion.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBoxConnexion.Controls.Add(this.buttonQuitter);
            this.groupBoxConnexion.Controls.Add(this.textBoxPassword);
            this.groupBoxConnexion.Controls.Add(this.textBoxLogin);
            this.groupBoxConnexion.Controls.Add(this.labelPassword);
            this.groupBoxConnexion.Controls.Add(this.labelLogin);
            this.groupBoxConnexion.Controls.Add(this.buttonConnexion);
            this.groupBoxConnexion.Location = new System.Drawing.Point(8, 14);
            this.groupBoxConnexion.Name = "groupBoxConnexion";
            this.groupBoxConnexion.Size = new System.Drawing.Size(367, 209);
            this.groupBoxConnexion.TabIndex = 0;
            this.groupBoxConnexion.TabStop = false;
            this.groupBoxConnexion.Text = "Se connecter";
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(96, 133);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(90, 35);
            this.buttonConnexion.TabIndex = 0;
            this.buttonConnexion.Text = "Valider";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(50, 50);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(88, 13);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Nom de compte :";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(50, 88);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(77, 13);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Mot de passe :";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(144, 47);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(138, 20);
            this.textBoxLogin.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(144, 85);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(138, 20);
            this.textBoxPassword.TabIndex = 4;
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(192, 133);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(90, 35);
            this.buttonQuitter.TabIndex = 5;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 235);
            this.Controls.Add(this.groupBoxConnexion);
            this.Name = "FormLogin";
            this.Text = "Page de connexion";
            // this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.groupBoxConnexion.ResumeLayout(false);
            this.groupBoxConnexion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConnexion;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.Button buttonQuitter;
    }
}