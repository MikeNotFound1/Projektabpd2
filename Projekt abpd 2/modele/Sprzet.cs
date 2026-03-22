namespace Projekt_abpd_2.modele;

public abstract class Sprzet
{
    private static int _licznik = 1;

    public int Id { get; }
    public string Nazwa { get; set; }
    public bool CzyDostepny { get; set; } = true;

    public Sprzet(string nazwa)
    {
        Id = _licznik++;
        Nazwa = nazwa;
    }
}