namespace Projekt_abpd_2.modele;

public class Aparat : Sprzet
{
    public string Matryca { get; set; }
    public int SrednicaObiektywu { get; set; }

    public Aparat(string nazwa, string matryca, int srednicaObiektywu) : base(nazwa)
    {
        Matryca = matryca;
        SrednicaObiektywu = srednicaObiektywu;
    }
}