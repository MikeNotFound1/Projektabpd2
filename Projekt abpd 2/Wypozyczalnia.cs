using Projekt_abpd_2.modele;

namespace Projekt_abpd_2;

public class Wypozyczalnia
{
    private readonly List<Sprzet> _ekwipunek = new();
    private readonly List<Uzytkownik> _uzytkownicy = new();
    private readonly List<Wypozyczenie> _wypozyczenia = new();

    private const decimal KaraZaDzien = 10;

    public void DodajSprzet(Sprzet sprzet) => _ekwipunek.Add(sprzet);
    public void DodajUzytkownika(Uzytkownik uzytkownik) => _uzytkownicy.Add(uzytkownik);

    public void WyswietlCalyEkwipunek()
    {
        Console.WriteLine("Id | Nazwa | Dostepnosc");
        foreach (var e in _ekwipunek)
        {
            Console.WriteLine($"{e.Id} | {e.Nazwa} | {e.CzyDostepny}");
        }
    }

    public void WyswietlDostepnyEkwipunek()
    {
        Console.WriteLine("Id | Nazwa");
        foreach (var e in _ekwipunek)
        {
            if (e.CzyDostepny)
                Console.WriteLine($"{e.Id} | {e.Nazwa}");
        }
    }
   
}