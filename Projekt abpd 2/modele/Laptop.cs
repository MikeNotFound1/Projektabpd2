namespace Projekt_abpd_2.modele;

public class Laptop : Sprzet
{
    public int Ram { get; set; }
    public string Procesor { get; set; }
    
    public Laptop(string nazwaProcesor, int ram, string procesor) :  base(nazwaProcesor)
    {
        Ram = ram;
        Procesor = procesor;
    }
}