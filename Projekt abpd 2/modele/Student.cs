namespace Projekt_abpd_2.modele;

public class Student : Uzytkownik
{
    public override int LimitWypozyczen => 2;

    public Student(string imie, string nazwisko) : base(imie, nazwisko)
    {
        
    }
}