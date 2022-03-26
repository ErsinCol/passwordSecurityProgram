using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sifreGuvenlikUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
               
                KarakterKontrol kontrol = new KarakterKontrol();
                Console.WriteLine("Şifre giriniz: ");
                string password=Console.ReadLine();
                for (int i = 0; i < password.Length; i++)
                {
                    if (password[i] == ' ')
                    {
                        Console.WriteLine("Şifre boşluk içermemeli");
                        Console.ReadLine();
                        return;
                    }
                }


                if (password.Length >= 9)
                {

                    if (password.Length == 9)
                    {
                    kontrol.bonusPuan +=10;
                    }
                    if ( kontrol.buyukHarfSayisi(password) == 0 || kontrol.kucukHarfSayisi(password) == 0 || kontrol.RakamSayisi(password)==0 || kontrol.sembollerSayisi(password)==0)
                    {
                        Console.WriteLine("Şifre bir rakam,büyük harf ve küçük harf içermelidir. Tekrar Deneyiniz...");
                        Console.ReadLine();
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Şifre 9 karakterden daha kısa uzunlukta olamaz...");
                    Console.ReadLine();
                    return;
                }

            if (kontrol.genelPuanHesaplama() < 70)
            {
                Console.WriteLine("Şifre zayıf, tekrar deneyiniz.");
            }
            else if (kontrol.genelPuanHesaplama() >= 70 && kontrol.genelPuanHesaplama() < 90)
            {
                Console.WriteLine("Şifre olağan, kabul edildi.");
            }
            else
            {
                Console.WriteLine("Şifre çok güçlü, kabul edildi");
            }

            Console.WriteLine("büyük harf: " + kontrol.buyukSayisi + " kucuk harf: " + kontrol.kucukSayisi + " rakam sayısı: " + kontrol.rakamSayisi+ " sembol sayısı: "+ kontrol.sembolSayisi);
            Console.ReadKey();
        }
    }
}
    
