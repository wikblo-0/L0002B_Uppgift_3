//Wiktoria Blomgren Strandberg
//wikblo-0@student.ltu.se
//L0002B Uppgift 3

using System;
using System.Windows.Forms;

namespace L0002B_Uppgift_3
{
    public partial class PersonnummerKontollerare : Form
    {
        private string inputPersonnummer;//Inmatat personnummer.

        public PersonnummerKontollerare()//Initialiserar.
        {
            InitializeComponent();
        }

        private void buttonTillbaka_Click(object sender, EventArgs e)// Val "tillbaka".
        {
            Start start = new Start();
            start.Show();//Visar startmeny-fönstret.
            this.Close();//Döljer formulär-fönstret.
        }

        private void buttonKontrollera_Click(object sender, EventArgs e)//Val "kontrollera".
        {
            string inputFörnamn = textBoxFörnamn.Text;//Inmatat förnamn.
            string inputEfternamn = textBoxEfternamn.Text;//Inmatat efternamn.
            inputPersonnummer = textBoxPersonnummer.Text;//Inmatat personnummer.
            long personnummer;//Används för att kontrollera att personnummret innehåller, och endast innehåller, siffror.

            if (inputFörnamn.Length != 0)//Kontrollerar att fältet förnamn inte är tomt.
            {
                if (inputEfternamn.Length != 0)//Kontrollerar att fältet efternamn inte är tomt.
                {
                    if (long.TryParse(inputPersonnummer, out personnummer) && //Kontrollerar att fältet personnummer innehåller, och endast innehåller, siffror.
                        (inputPersonnummer.Length == 10 || inputPersonnummer.Length == 12))//Kontrollerar att längden på inmatat personummer är 10 eller 12 tecken.
                    {
                        Person person = new Person(inputFörnamn, inputEfternamn, inputPersonnummer);//Skapar person baserat på input.
                        string kontrollPersonnummer;//Används för att skriva ut om personnumret är korrekt eller inkorrekt.
                        string kön;//Används för att skriva ut personens kön.

                        if (kontrollAvPersonnummer() == true)//Om personnumret är korrekt.
                        {
                            kontrollPersonnummer = "korrekt";
                        }
                        else//Om personnumret är inkorrekt.
                        {
                            kontrollPersonnummer = "inkorrekt";
                        }

                        if (kontrollAvKön() == true)//Om personen är en kvinna.
                        {
                            kön = "kvinna";
                        }
                        else//Om personen är en man.
                        {
                            kön = "man";
                        }
                        
                        textBoxResultat.Text = person.Förnamn + Environment.NewLine + person.Efternamn +
                            Environment.NewLine + person.Personnummer + Environment.NewLine +
                            Environment.NewLine + "Personnummret är " + kontrollPersonnummer + "." +
                            Environment.NewLine + "Personen är en " + kön + ".";//Skriver ut inmatad information samt resultatet av kontrolleringen i en multiline textbox.
                    }
                    else//Om personnumret inte innehåller, eller innehåller annat än, siffror och/eller om längden är fel.
                    {
                        MessageBox.Show("Personnummer ska, och ska endast, innehålla 10 eller 12 siffor.", 
                            "Kontrollera personnummer", MessageBoxButtons.OK, MessageBoxIcon.Error);//Återkoppling i messagebox.
                    }
                }
                else//Om efternamn-fältet lämnas tomt.
                {
                    MessageBox.Show("Efternamn får ej lämnas tomt.", "Kontrollera efternamn",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);//Återkoppling i messagebox.
                }
            }
            else//Om förnamn-fältet lämnas tomt.
            {
                MessageBox.Show("Förnamn får ej lämnas tomt.", "Kontrollera förnamn",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);//Återkoppling i messagebox.
            }
        }

        private Boolean kontrollAvPersonnummer()//Kontrollerar inmatat personnummer enligt 21Algoritmen.
        {
            string personnummer10;//Inmatat personnummer med 10 siffror.

            if (inputPersonnummer.Length == 12)//Kortar ned inmatat personnummer till 10 siffror.
            {
                personnummer10 = inputPersonnummer.Remove(0, 2);//Tar bort 2 första siffrorna.
            }
            else//Om personnumret redan är skrivet med 10 siffror.
            {
                personnummer10 = inputPersonnummer;
            }

            //Multiplicerar varannan siffra med 2. "- '0'" krävs för konvertering från char till int.
            int siffra1 = (personnummer10[0] - '0') * 2;
            int siffra2 = personnummer10[1] - '0';
            int siffra3 = (personnummer10[2] - '0') * 2;
            int siffra4 = personnummer10[3] - '0';
            int siffra5 = (personnummer10[4] - '0') * 2;
            int siffra6 = personnummer10[5] - '0';
            int siffra7 = (personnummer10[6] - '0') * 2;
            int siffra8 = personnummer10[7] - '0';
            int siffra9 = (personnummer10[8] - '0') * 2;
            int siffra10 = personnummer10[9] - '0';

            int kontrolltal = (siffra1 / 10) + (siffra1 % 10) + siffra2 + (siffra3 / 10) + 
                (siffra3 % 10) + siffra4 + (siffra5 / 10) + (siffra5 % 10) + siffra6 + 
                (siffra7 / 10) + (siffra7 % 10) + siffra8 + (siffra9 / 10) + (siffra9 % 10) + 
                siffra10;//Siffersummorna beräknas och adderas.

            if (kontrolltal % 10 == 0)//Kontrollerar att kontrolltalet är jämnt delbart med 10.
            {
                return true;//Personnumret är korrekt.
            }
            else//Om kontrolltalet ej är jämnt delbart med 10.
            {
                return false;//Personnumret är inkorrekt.
            }
        }

        private Boolean kontrollAvKön()//Kontrollerar personens kön baserat på personnumret.
        {
            char könsiffra = inputPersonnummer[inputPersonnummer.Length - 2];//Anger vilken siffra som ska kontrolleras.

            if (Convert.ToInt32(könsiffra) % 2 == 0)//Kontrollerar om siffran är jämn eller udda.
            {
                return true;//Kvinna
            }
            else
            {
                return false;//Man
            }
        }
    }
}
