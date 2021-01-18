using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            Musteri m2 = new Musteri();

            m1.musteriId = 1;
            m1.musteriAdi = "Elif";
            m1.musteriSoyadi = "Unal";
            m1.musteriNo = 1732837;

            m2.musteriId = 2;
            m2.musteriAdi = "Sukriye";
            m2.musteriSoyadi = "Karaca";
            m2.musteriNo = 178243874;

            Musteri[] musteriler = new Musteri[] {m1,m2 };

            for (int i = 0; i < musteriler.Length; i++)
            {
                Console.WriteLine(musteriler[i].musteriId + " " + musteriler[i].musteriAdi + " " + musteriler[i].musteriSoyadi + " " + musteriler[i].musteriNo);
            }
            Ekle ekle = new Ekle();
            ekle.Eklee(3,"beyza","karaca",27387);

            sil sil = new sil();
            sil.Sil(m1);


        }
           
    }
}
