using System;

public class Yunus : IHayvan
{
    //Virtual metod = kalıtımla gelen ve türetilmiş sınıfta override edilebilen metod.
    public virtual bool soyuTukendiMi()
    {
        // Yunusun nesli tukenmediginden false dondurecek
        return false;
    }
    public string sinif()
    {
        return "Memeliler";
    }
    public virtual string tur()
    {
        return "Yunus";
    }
    public bool uremeYaparMi()
    {
        return true;
    }
    public string zehirliMi()
    {
        return "Zehirsiz";
    }
}