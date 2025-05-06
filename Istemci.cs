using System;

public class Istemci
{
    public Istemci(IHayvan hayvan)
    {
        Console.WriteLine("Hayvan Türü:" + hayvan.tur());
        Console.WriteLine();
        Console.WriteLine("Soyu tükendi mi?" + hayvan.soyuTukendiMi());
        Console.WriteLine();
        Console.WriteLine("Hayvan zehirli mi?" + hayvan.zehirliMi());
    }
}