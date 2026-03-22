namespace Projekt_abpd_2.modele;

public class Wypozyczenie
{
    public Uzytkownik Uzytkownik { get; set; }
    public Sprzet Sprzet { get; set; }
    public DateTime DataWypozyczenia { get; set; }
    public DateTime TerminZwrotu { get; set; }
    public DateTime? DataZwrotu { get; set; }
    public decimal Kara { get; set; } = 0;
    public bool PoTerminie => DataZwrotu.HasValue ? DataZwrotu > TerminZwrotu : DateTime.Now > TerminZwrotu;
}