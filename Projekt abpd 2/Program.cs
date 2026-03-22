using Projekt_abpd_2;
using Projekt_abpd_2.modele;

var wypozyczalnia = new Wypozyczalnia();
bool end = false;

while (!end)
{
    Console.WriteLine("\n Opcje wyboru:");
    Console.WriteLine("1. Dodaj Studenta");
    Console.WriteLine("2. Dodaj Pracownika");
    Console.WriteLine("3. Dodaj Laptop");
    Console.WriteLine("4. Dodaj Aparat");
    Console.WriteLine("5. Dodaj Projektor");
    Console.WriteLine("6. Lista calego sprzetu");
    Console.WriteLine("7. Lista dostepnego sprzetu");
    Console.WriteLine("8. Wypozycz");
    Console.WriteLine("9. Zwroc");
    Console.WriteLine("10. Oznacz jako niedostepne");
    Console.WriteLine("11. Lista aktywnych wypozyczen");
    Console.WriteLine("12. Lista przeterminowanych wypozyczen");
    Console.WriteLine("13. Raport");
    Console.WriteLine("0. Wyjscie");
    Console.WriteLine("Wybierz opcje: ");

    string opcja = Console.ReadLine();

    switch (opcja)
    {
        case "1":
            Console.WriteLine("Imie: ");
            string imie = Console.ReadLine();
            Console.WriteLine("Nazwisko: ");
            string nazwisko = Console.ReadLine();
            wypozyczalnia.DodajUzytkownika(new Student(imie, nazwisko));
            break;
        case "2":
            Console.WriteLine("Imie: ");
            imie = Console.ReadLine();
            Console.WriteLine("Nazwisko: ");
            nazwisko = Console.ReadLine();
            wypozyczalnia.DodajUzytkownika(new Pracownik(imie, nazwisko));
            break;
        case "3":
            Console.WriteLine("Nazwa: ");
            string nazwa = Console.ReadLine();
            Console.WriteLine("Ram: ");
            int ram = int.Parse(Console.ReadLine());
            Console.WriteLine("Procesor: ");
            string procesor = Console.ReadLine();
            wypozyczalnia.DodajSprzet(new Laptop(nazwa, ram, procesor));
            break;
        case "4":
            Console.WriteLine("Nazwa: ");
            nazwa = Console.ReadLine();
            Console.WriteLine("Matryca: ");
            string matryca = Console.ReadLine();
            Console.WriteLine("Srednica obiektywu: ");
            int srednica = int.Parse(Console.ReadLine());
            wypozyczalnia.DodajSprzet(new Aparat(nazwa, matryca, srednica));
            break;
        case "5":
            Console.WriteLine("Nazwa: ");
            nazwa = Console.ReadLine();
            Console.WriteLine("Jasnosc: ");
            int jasnosc = int.Parse(Console.ReadLine());
            Console.WriteLine("Rozdzielczosc: ");
            string rozdzielczosc = Console.ReadLine();
            wypozyczalnia.DodajSprzet(new Projektor(nazwa, jasnosc, rozdzielczosc));
            break;
        case "6":
            wypozyczalnia.WyswietlCalyEkwipunek();
            break;
        case "7":
            wypozyczalnia.WyswietlDostepnyEkwipunek();
            break;
        case "8":
            Console.WriteLine("Podaj id uzytkownika: ");
            int userId = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj id sprzetu: ");
            int sprzetId = int.Parse(Console.ReadLine());
            wypozyczalnia.Wypozycz(userId, sprzetId);
            break;
        case "9":
            Console.WriteLine("Podaj id sprzetu: ");
            sprzetId = int.Parse(Console.ReadLine());
            wypozyczalnia.Zwroc(sprzetId);
            break;
        case "10":
            Console.WriteLine("Podaj id sprzetu: ");
            sprzetId = int.Parse(Console.ReadLine());
            wypozyczalnia.OznaczJakoNiedostepny(sprzetId);
            break;
        case "11":
            Console.WriteLine("Podaj id uzytkownika: ");
            userId = int.Parse(Console.ReadLine());
            wypozyczalnia.PokazSprzetUzytkownika(userId);
            break;
        case "12":
            wypozyczalnia.PokazPrzeterminowane();
            break;
        case "13":
            wypozyczalnia.WyswietlRaport();
            break;
        default:
            Console.WriteLine("Brak opcji nr " + opcja);
            break;
    }
}