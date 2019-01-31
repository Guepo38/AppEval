namespace AppEvalWindows
{
    partial class FormCoeff
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
            this.groupBoxCoeff = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAjoutCoeff = new System.Windows.Forms.Button();
            this.groupBoxCoeff.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCoeff
            // 
            this.groupBoxCoeff.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxCoeff.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBoxCoeff.Controls.Add(this.comboBox1);
            this.groupBoxCoeff.Controls.Add(this.label1);
            this.groupBoxCoeff.Controls.Add(this.buttonAjoutCoeff);
            this.groupBoxCoeff.Location = new System.Drawing.Point(10, 12);
            this.groupBoxCoeff.Name = "groupBoxCoeff";
            this.groupBoxCoeff.Size = new System.Drawing.Size(271, 104);
            this.groupBoxCoeff.TabIndex = 0;
            this.groupBoxCoeff.TabStop = false;
            this.groupBoxCoeff.Text = "Coefficient";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(145, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Coefficient pour ce critère : ";
            // 
            // buttonAjoutCoeff
            // 
            this.buttonAjoutCoeff.Location = new System.Drawing.Point(145, 70);
            this.buttonAjoutCoeff.Name = "buttonAjoutCoeff";
            this.buttonAjoutCoeff.Size = new System.Drawing.Size(82, 28);
            this.buttonAjoutCoeff.TabIndex = 2;
            this.buttonAjoutCoeff.Text = "Valider";
            this.buttonAjoutCoeff.UseVisualStyleBackColor = true;
            this.buttonAjoutCoeff.Click += new System.EventHandler(this.buttonAjoutCoeff_Click);
            // 
            // FormCoeff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 128);
            this.Controls.Add(this.groupBoxCoeff);
            this.Name = "FormCoeff";
            this.Text = "Ajouter un coefficient";
            this.groupBoxCoeff.ResumeLayout(false);
            this.groupBoxCoeff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCoeff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAjoutCoeff;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}