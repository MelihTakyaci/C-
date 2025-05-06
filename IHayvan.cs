using System;

public interface IHayvan
{
    // omurgalılar, memeliler v.s
    public string sinif();
    // hayvanin adi
    public string tur();
    // Yumurtlama dogurma v.s
    public bool uremeYaparMi();
    public bool soyuTukendiMi();
    public string zehirliMi();
}