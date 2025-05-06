public class HintKralKobrasi : KralKobra
{
    public override string zehirliMi()
    {
        return "Çok Çok Zehirli";
    }
    public override string tur()
    {
        return "Hint Kral Kobrasi";
    }

    // interface'ye ek metod
    public int HintKralKobrasinaOzgunMetod()
    {
        return 30;
    }
}