using System;

public class KralKobra : IHayvan
{
    // burada virtuala gerek yok
     public bool soyuTukendiMi()
    {
        return false;
    }
    public string sinif()
    {
        return "Sürüngenler";
    }
    public virtual string tur()
    {
        return "Yılan";
    }
    public bool uremeYaparMi()
    {
        return true;
    }
    public virtual string zehirliMi()
    {
        return "Zehirli";
    }
}