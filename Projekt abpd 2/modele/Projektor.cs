namespace Projekt_abpd_2.modele;

public class Projektor : Sprzet
{
    public int Jasnosc { get; set; }
    public string Rozdzielczosc { get; set; }

    public Projektor(string nazwa, int jasnosc, string rozdzielczosc) : base(nazwa)
    {
        Jasnosc = jasnosc;
        Rozdzielczosc =  rozdzielczosc;
    }
}