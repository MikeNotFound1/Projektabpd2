namespace Projekt_abpd_2.modele;

public abstract class Uzytkownik
{
    private static int _licznik = 1;
    public int Id { get; }
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public abstract int LimitWypozyczen { get; }

    public Uzytkownik(string imie, string nazwisko)
    {
        Imie = imie;
        Nazwisko = nazwisko;
    }
}