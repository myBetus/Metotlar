using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 20;
            urun1.Aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 70;
            urun2.Aciklama = " diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi + " " + urun.Fiyati + " " + urun.Aciklama);
                Console.WriteLine("----------------------------------------------------------------");
            
            }
            Console.WriteLine("--------------METOTLAR----------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1); 
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("armut", "yeşil armut", 12,9);


        }
    }
}
