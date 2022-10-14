//Wiktoria Blomgren Strandberg
//wikblo-0@student.ltu.se
//L0002B Uppgift 3

using System;
using System.Windows.Forms;

namespace L0002B_Uppgift_3
{
    public partial class Start : Form
    {
        public Start()//Initialiserar.
        {
            InitializeComponent();
        }

        private void buttonKontrolleraPersonnummer_Click(object sender, EventArgs e)//Val "kontrollera personnummer".
        {
            PersonnummerKontollerare personnummerKontrollerare = new PersonnummerKontollerare();
            personnummerKontrollerare.Show();//Visar formulär-fönstret.
            this.Hide();//Döljer startmeny-fönstret.
        }

        private void buttonAvsluta_Click(object sender, EventArgs e)//Val "avsluta".
        {
            Environment.Exit(0);//Avslutar programmet.
        }
    }
}