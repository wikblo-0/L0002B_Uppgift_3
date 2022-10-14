namespace L0002B_Uppgift_3
{
    partial class Start
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
            this.labelVälkommen = new System.Windows.Forms.Label();
            this.buttonKontrolleraPersonnummer = new System.Windows.Forms.Button();
            this.buttonAvsluta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelVälkommen
            // 
            this.labelVälkommen.AutoSize = true;
            this.labelVälkommen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelVälkommen.Location = new System.Drawing.Point(91, 118);
            this.labelVälkommen.Name = "labelVälkommen";
            this.labelVälkommen.Size = new System.Drawing.Size(614, 36);
            this.labelVälkommen.TabIndex = 0;
            this.labelVälkommen.Text = "Välkommen till personnummer-kontrolleraren!";
            // 
            // buttonKontrolleraPersonnummer
            // 
            this.buttonKontrolleraPersonnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonKontrolleraPersonnummer.Location = new System.Drawing.Point(244, 225);
            this.buttonKontrolleraPersonnummer.Name = "buttonKontrolleraPersonnummer";
            this.buttonKontrolleraPersonnummer.Size = new System.Drawing.Size(298, 35);
            this.buttonKontrolleraPersonnummer.TabIndex = 1;
            this.buttonKontrolleraPersonnummer.Text = "Kontrollera personnummer";
            this.buttonKontrolleraPersonnummer.UseVisualStyleBackColor = true;
            this.buttonKontrolleraPersonnummer.Click += new System.EventHandler(this.buttonKontrolleraPersonnummer_Click);
            // 
            // buttonAvsluta
            // 
            this.buttonAvsluta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAvsluta.Location = new System.Drawing.Point(344, 301);
            this.buttonAvsluta.Name = "buttonAvsluta";
            this.buttonAvsluta.Size = new System.Drawing.Size(101, 35);
            this.buttonAvsluta.TabIndex = 2;
            this.buttonAvsluta.Text = "Avsluta";
            this.buttonAvsluta.UseVisualStyleBackColor = true;
            this.buttonAvsluta.Click += new System.EventHandler(this.buttonAvsluta_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAvsluta);
            this.Controls.Add(this.buttonKontrolleraPersonnummer);
            this.Controls.Add(this.labelVälkommen);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVälkommen;
        private System.Windows.Forms.Button buttonKontrolleraPersonnummer;
        private System.Windows.Forms.Button buttonAvsluta;
    }
}