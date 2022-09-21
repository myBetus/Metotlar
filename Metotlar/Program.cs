using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "armut";
            urun1.Fiyati = 25;
            urun1.Aciklama = "bebek gibiii";
            Urun urun2 = new Urun();
            urun2.Adi = "Portakal";
            urun2.Fiyati = 30;
            urun2.Aciklama = "turuncuuuu";
            Urun[] urunlerim = new Urun[] { urun1, urun2 };
            foreach (Urun urun in urunlerim)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------------------");
                
            }
            Console.WriteLine("-----------------metotlar-----------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("armut", "yeşil", 12, 10);
        }
       
    } 

}
