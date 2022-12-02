using System;
using System.Collections.Generic;

public interface Kompozyt
{
    public void Renderuj();

    void DodajElement(Kompozyt element);

    void UsunElement(Kompozyt element);
}

public class Lisc : Kompozyt
{
    public string nazwa { get; set; }

    public void DodajElement(Kompozyt element)
    {
        throw new NotImplementedException();
    }

    public void Renderuj()
    {
        Console.WriteLine(nazwa + " renderowanie...");
    }

    public void UsunElement(Kompozyt element)
    {
        throw new NotImplementedException();
    }

    // konstruktor
}

public class Wezel : Kompozyt
{
    private List<Kompozyt> Lista = new List<Kompozyt>();

    public string nazwa { get; set; }

    public void Renderuj()
    {
        Console.WriteLine(nazwa + " rozpoczęcie renderowania");

        foreach (var item in Lista)
        {
            item.Renderuj();
        }

        Console.WriteLine(nazwa + " zakończenie renderowania");
    }

    public void DodajElement(Kompozyt element)
    {
        Lista.Add(element);
    }

    public void UsunElement(Kompozyt element)
    {
        Lista.Remove(element);
    }
}

public class MainClass
{
    public static void Main(string[] args)
    {
        Wezel korzen = new Wezel();
        korzen.nazwa = "Korzeń";

        Lisc lisc11 = new Lisc();
        lisc11.nazwa = "Liść 1.1";
        korzen.DodajElement(lisc11);

        Wezel wezel2 = new Wezel();
        wezel2.nazwa = "Węzeł 2";
        korzen.DodajElement(wezel2);

        Lisc lisc21 = new Lisc();
        lisc21.nazwa = "Liść 2.1";
        wezel2.DodajElement(lisc21);

        Lisc lisc22 = new Lisc();
        lisc22.nazwa = "Liść 2.2";
        wezel2.DodajElement(lisc22);

        Lisc lisc23 = new Lisc();
        lisc23.nazwa = "Liść 2.3";
        wezel2.DodajElement(lisc23);

        Wezel wezel3 = new Wezel();
        wezel3.nazwa = "Węzeł 3";
        korzen.DodajElement(wezel3);

        Lisc lisc31 = new Lisc();
        lisc31.nazwa = "Liść 3.1";
        wezel3.DodajElement(lisc31);

        Lisc lisc32 = new Lisc();
        lisc32.nazwa = "Liść 3.2";
        wezel3.DodajElement(lisc32);

        Wezel wezel33 = new Wezel();
        wezel33.nazwa = "Węzeł 3.3";
        wezel3.DodajElement(wezel33);

        Lisc lisc33 = new Lisc();
        lisc33.nazwa = "Liść 3.3.1";
        wezel33.DodajElement(lisc33);

        korzen.Renderuj();
    }
}
