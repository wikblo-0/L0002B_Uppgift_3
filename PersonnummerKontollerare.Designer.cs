namespace L0002B_Uppgift_3
{
    partial class PersonnummerKontollerare
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
            this.labelFörnamn = new System.Windows.Forms.Label();
            this.labelEfternamn = new System.Windows.Forms.Label();
            this.labelPersonnummer = new System.Windows.Forms.Label();
            this.textBoxFörnamn = new System.Windows.Forms.TextBox();
            this.textBoxEfternamn = new System.Windows.Forms.TextBox();
            this.textBoxPersonnummer = new System.Windows.Forms.TextBox();
            this.buttonKontrollera = new System.Windows.Forms.Button();
            this.buttonTillbaka = new System.Windows.Forms.Button();
            this.textBoxResultat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFörnamn
            // 
            this.labelFörnamn.AutoSize = true;
            this.labelFörnamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFörnamn.Location = new System.Drawing.Point(27, 104);
            this.labelFörnamn.Name = "labelFörnamn";
            this.labelFörnamn.Size = new System.Drawing.Size(96, 25);
            this.labelFörnamn.TabIndex = 0;
            this.labelFörnamn.Text = "Förnamn:";
            // 
            // labelEfternamn
            // 
            this.labelEfternamn.AutoSize = true;
            this.labelEfternamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEfternamn.Location = new System.Drawing.Point(27, 156);
            this.labelEfternamn.Name = "labelEfternamn";
            this.labelEfternamn.Size = new System.Drawing.Size(107, 25);
            this.labelEfternamn.TabIndex = 1;
            this.labelEfternamn.Text = "Efternamn:";
            // 
            // labelPersonnummer
            // 
            this.labelPersonnummer.AutoSize = true;
            this.labelPersonnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPersonnummer.Location = new System.Drawing.Point(27, 204);
            this.labelPersonnummer.Name = "labelPersonnummer";
            this.labelPersonnummer.Size = new System.Drawing.Size(159, 25);
            this.labelPersonnummer.TabIndex = 2;
            this.labelPersonnummer.Text = "Personnummer*:";
            // 
            // textBoxFörnamn
            // 
            this.textBoxFörnamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFörnamn.Location = new System.Drawing.Point(207, 101);
            this.textBoxFörnamn.Name = "textBoxFörnamn";
            this.textBoxFörnamn.Size = new System.Drawing.Size(232, 30);
            this.textBoxFörnamn.TabIndex = 3;
            // 
            // textBoxEfternamn
            // 
            this.textBoxEfternamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxEfternamn.Location = new System.Drawing.Point(207, 153);
            this.textBoxEfternamn.Name = "textBoxEfternamn";
            this.textBoxEfternamn.Size = new System.Drawing.Size(232, 30);
            this.textBoxEfternamn.TabIndex = 4;
            // 
            // textBoxPersonnummer
            // 
            this.textBoxPersonnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPersonnummer.Location = new System.Drawing.Point(207, 201);
            this.textBoxPersonnummer.Name = "textBoxPersonnummer";
            this.textBoxPersonnummer.Size = new System.Drawing.Size(232, 30);
            this.textBoxPersonnummer.TabIndex = 5;
            // 
            // buttonKontrollera
            // 
            this.buttonKontrollera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonKontrollera.Location = new System.Drawing.Point(292, 262);
            this.buttonKontrollera.Name = "buttonKontrollera";
            this.buttonKontrollera.Size = new System.Drawing.Size(132, 34);
            this.buttonKontrollera.TabIndex = 6;
            this.buttonKontrollera.Text = "Kontrollera";
            this.buttonKontrollera.UseVisualStyleBackColor = true;
            this.buttonKontrollera.Click += new System.EventHandler(this.buttonKontrollera_Click);
            // 
            // buttonTillbaka
            // 
            this.buttonTillbaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonTillbaka.Location = new System.Drawing.Point(696, 387);
            this.buttonTillbaka.Name = "buttonTillbaka";
            this.buttonTillbaka.Size = new System.Drawing.Size(98, 39);
            this.buttonTillbaka.TabIndex = 7;
            this.buttonTillbaka.Text = "Tillbaka";
            this.buttonTillbaka.UseVisualStyleBackColor = true;
            this.buttonTillbaka.Click += new System.EventHandler(this.buttonTillbaka_Click);
            // 
            // textBoxResultat
            // 
            this.textBoxResultat.Enabled = false;
            this.textBoxResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxResultat.Location = new System.Drawing.Point(489, 104);
            this.textBoxResultat.Multiline = true;
            this.textBoxResultat.Name = "textBoxResultat";
            this.textBoxResultat.Size = new System.Drawing.Size(281, 192);
            this.textBoxResultat.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "*Ska anges med 10 eller 12 siffror och utan skiljetecken.";
            // 
            // PersonnummerKontollerare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResultat);
            this.Controls.Add(this.buttonTillbaka);
            this.Controls.Add(this.buttonKontrollera);
            this.Controls.Add(this.textBoxPersonnummer);
            this.Controls.Add(this.textBoxEfternamn);
            this.Controls.Add(this.textBoxFörnamn);
            this.Controls.Add(this.labelPersonnummer);
            this.Controls.Add(this.labelEfternamn);
            this.Controls.Add(this.labelFörnamn);
            this.Name = "PersonnummerKontollerare";
            this.Text = "Personnummer-kontrollerare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFörnamn;
        private System.Windows.Forms.Label labelEfternamn;
        private System.Windows.Forms.Label labelPersonnummer;
        private System.Windows.Forms.TextBox textBoxFörnamn;
        private System.Windows.Forms.TextBox textBoxEfternamn;
        private System.Windows.Forms.TextBox textBoxPersonnummer;
        private System.Windows.Forms.Button buttonKontrollera;
        private System.Windows.Forms.Button buttonTillbaka;
        private System.Windows.Forms.TextBox textBoxResultat;
        private System.Windows.Forms.Label label1;
    }
}

