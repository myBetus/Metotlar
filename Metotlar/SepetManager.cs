using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention=isimlendirme kuralı
        public void Ekle(Urun urun)
        {
            Console.WriteLine("SEPETE EKLENDİ : "+urun.Adi);
             
        }

        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdeti)
        {
            Console.WriteLine("SEPETE EKLENDİ : " + urunAdi );
        }
    }
}
