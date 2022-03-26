using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sifreGuvenlikUygulamasi
{
    internal class KarakterKontrol
    {
        public int bonusPuan = 0;
        public int buyukSayisi=0;
        public int kucukSayisi=0;
        public int rakamSayisi=0;
        public int sembolSayisi = 0;

        public int sembollerSayisi(string sifre)
        {
            char[] semboller = "/*-+,;`.:<>|~¨@€₺é^#'+$%&/{([)]=}?*-_".ToCharArray();
            for (int i = 0; i < sifre.Length; i++)
            {
                for (int j = 0; j < semboller.Length; j++)
                {
                    if (sifre[i] == semboller[j])
                    {
                        sembolSayisi++;
                        if (sembolSayisi == 2) { return sembolSayisi; }

                    }

                }

            }
            return sembolSayisi;
        }
        


        public int buyukHarfSayisi(string sifre)
        {
            char[] buyukHarfler = "ABCÇDEFGĞHIİJKLMNOÖPQRSŞTUÜVWXYZ".ToCharArray();

            for (int i = 0; i < sifre.Length; i++)
            {
                for (int j = 0; j < buyukHarfler.Length; j++)
                {
                    if (sifre[i] == buyukHarfler[j])
                    {
                        buyukSayisi++;
                        if (buyukSayisi == 2) { return buyukSayisi; }

                    }

                }

            }
            return buyukSayisi;
        }
        public int kucukHarfSayisi(string sifre)
        {
            char[] kucukHarfler = "abcçdefghıijklmnoöprsştuüvyzxwq".ToCharArray();
            for (int i = 0; i < sifre.Length; i++)
            {
                for (int j = 0; j < kucukHarfler.Length; j++)
                {
                    if (sifre[i] == kucukHarfler[j])
                    {
                        kucukSayisi++;
                        if (kucukSayisi == 2) { return kucukSayisi; }
                    }
                }

            }
            return kucukSayisi;
        }
        public int RakamSayisi(string sifre)
        {
            char[] rakamlar = "0123456789".ToCharArray();
            for (int i = 0; i < sifre.Length; i++)
            {
                for (int j = 0; j < rakamlar.Length; j++)
                {
                    if (sifre[i] == rakamlar[j])
                    {
                        rakamSayisi++;
                        if (rakamSayisi == 2) { return rakamSayisi; }
                        
                    }
                }

            }
            return rakamSayisi;
        }
        

        public int genelPuanHesaplama()
        {
            return buyukSayisi * 10 + kucukSayisi * 10 + rakamSayisi * 10+sembolSayisi*10 + bonusPuan;
        }
    }











}
