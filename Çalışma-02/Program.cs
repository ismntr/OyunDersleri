﻿using System;
namespace Usem.Calisma01
{
    class OzelProgram
    {
        static void Main()
        {
            string deger;
            string sonDeger;

            // Giriş
            deger = Giris();

            // İşlemler
            sonDeger = Proses(deger);

            // Çıkış işlemler
            Cikis(sonDeger);
        }

        static string Giris()
        {
            string girisM;
            // Giriş işlemleri
            Console.WriteLine("Giriş Yapınız...");
            girisM = Console.ReadLine();
            
            Console.ReadLine();
            // uzunluk hesaplama

            // Console.WriteLine(uzunluk);

            // koşul?  en az 3 karakter

            

            if (Gecerli(girisM)) {
                
                // koşul TRUE doğru ise çalıştırılır

            } else {
                // koşul FALSE yanlış ise çalıştırılır

            }




            return girisM;
        }


        static bool Gecerli (string metin){
            bool bitti = true;
            
            int uzunluk = metin.Length;

            
            return bitti;
        }



        static string Proses(string g)
        {
            // String işlemler
            string cikisM;
            cikisM = "Giriş :  " + g;
            return cikisM;

        }

        static void Cikis(string c)
        {
            // Çıkış İşlemler
            Console.WriteLine(c);
        }
    }
}

