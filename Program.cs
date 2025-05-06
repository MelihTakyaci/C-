using System;

namespace Polimorfizm
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int rastgeleSayi = random.Next(1,5);
            IHayvan rastgeleHayvan = rastgeleHayvanUret(rastgeleSayi);

            Yunus yunus = new Yunus();
            CinNehirYunusu cinNehirYunusu = new CinNehirYunusu();

            KralKobra kralKobra = new KralKobra();
            HintKralKobrasi hintKralKobrasi = new HintKralKobrasi();

            // KralKobra kralKobra2 = new KralKobra();
            // KralKobra kralKobra3 = new KralKobra();

            Istemci istemci = new Istemci(hintKralKobrasi);

        }
        public static IHayvan rastgeleHayvanUret(int rastgeleSayi)
        {
            if(rastgeleSayi == 1)
            {
                Yunus yunus = new Yunus();
                return yunus;
            }
            else if(rastgeleSayi == 2){
                CinNehirYunusu cinNehirYunusu = new CinNehirYunusu();
                return cinNehirYunusu;
            }
            else if(rastgeleSayi == 3){
                KralKobra kralKobra = new KralKobra();
                return kralKobra;
            }
            else
            {
                Yunus yunus = new Yunus();
                return yunus;
            }
        }
    }
}