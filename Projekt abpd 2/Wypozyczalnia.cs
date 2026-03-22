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

    public void Wypozycz(int userId, int sprzetId)
    {
        var uzytkownik = _uzytkownicy.FirstOrDefault(u => u.Id == userId);
        var sprzet = _ekwipunek.FirstOrDefault(s => s.Id == sprzetId);

        if (!sprzet.CzyDostepny)
        {
            Console.WriteLine("Sprzet jest zajety");
            return;
        }

        int liczbaWypozyczonych = _wypozyczenia.Count(w => w.Uzytkownik.Id == userId);
        if (liczbaWypozyczonych >= uzytkownik.LimitWypozyczen)
        {
            Console.WriteLine("Limit wypozyczen osiagniety");
            return;
        }

        sprzet.CzyDostepny = false;
        _wypozyczenia.Add(new Wypozyczenie
        {
            Uzytkownik = uzytkownik,
            Sprzet = sprzet,
            DataWypozyczenia = DateTime.Now,
            TerminZwrotu = DateTime.Now.AddDays(7)
        });
    }

    public void Zwroc(int sprzetId)
    {
        var sprzet = _ekwipunek.FirstOrDefault(s => s.Id == sprzetId);
        var wypozyczenie = _wypozyczenia.FirstOrDefault(w => w.Sprzet.Id == sprzetId);

        wypozyczenie.DataZwrotu = DateTime.Now;
        sprzet.CzyDostepny = true;

        if (wypozyczenie.PoTerminie)
        {
            int dniSpoznienia = (wypozyczenie.DataZwrotu.Value - wypozyczenie.DataWypozyczenia).Days;
            Console.WriteLine($"Kara za spoznienie: {dniSpoznienia * KaraZaDzien}");
        }
    }

    public void OznaczJakoNiedostepny(int sprzetId)
    {
        var sprzet = _ekwipunek.FirstOrDefault(s => s.Id == sprzetId);
        sprzet.CzyDostepny = false;
    }

}