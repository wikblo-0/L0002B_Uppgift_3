//Wiktoria Blomgren Strandberg
//wikblo-0@student.ltu.se
//L0002B Uppgift 3

namespace L0002B_Uppgift_3
{
    internal class Person
    {
        private string förnamn, efternamn, personnummer;//Personens förnamn, efternamn och personnummer.

        public Person(string förnamn, string efternamn, string personnummer)//Konstruktor.
        {
            Förnamn = förnamn;
            Efternamn = efternamn;
            Personnummer = personnummer;
        }

        public string Förnamn//Setter och getter för personens förnamn.
        {
            get => förnamn;
            set => förnamn = value;
        }

        public string Efternamn//Setter och getter för personens efternamn.
        {
            get => efternamn;
            set => efternamn = value;
        }

        public string Personnummer//Setter och getter för personens personnummer.
        {
            get => personnummer;
            set => personnummer = value;
        }
    }
}