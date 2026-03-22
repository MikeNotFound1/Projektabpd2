namespace Projekt_abpd_2.modele;

public class Pracownik : Uzytkownik
{
    public override int LimitWypozyczen => 5;

    public Pracownik(string imie, string nazwisko) : base(imie, nazwisko)
    {
        
    }
}