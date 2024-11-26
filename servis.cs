using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
             }
            




            

class ServisUygulamasi
        {
            
            public class Ogrenci
            {
                public string Ad { get; set; }
                public string Soyad { get; set; }
                public int Yas { get; set; }
                public string Adres { get; set; }
                public string ServisRota { get; set; }

                public Ogrenci(string ad, string soyad, int yas, string adres, string servisRota)
                {
                    Ad = ad;
                    Soyad = soyad;
                    Yas = yas;
                    Adres = adres;
                    ServisRota = servisRota;
                }

                public void BilgileriYazdir()
                {
                    Console.WriteLine($"Ad: {Ad} | Soyad: {Soyad} | Yaş: {Yas} | Adres: {Adres} | Servis Rota: {ServisRota}");
                }
            }

            static void Main()
            {
                int kapasiteLimit = 10;  
                List<Ogrenci> ogrenciListesi = new List<Ogrenci>(); 
                bool devamEt = true;

                while (devamEt)
                {
                    Console.WriteLine("\n--- Okul Servisi Uygulaması ---");
                    Console.WriteLine("1 - Öğrenci Kaydı");
                    Console.WriteLine("2 - Servise Kayıtlı Öğrencileri Listele");
                    Console.WriteLine("3 - Çıkış");
                    Console.Write("Bir seçenek girin (1-3): ");

                    int secim = Convert.ToInt32(Console.ReadLine());

                    switch (secim)
                    {
                        case 1:
                            
                            if (ogrenciListesi.Count < kapasiteLimit)
                            {
                                Console.WriteLine("\n--- Öğrenci Kaydı ---");

                                Console.Write("Öğrencinin Adını girin: ");
                                string ad = Console.ReadLine();

                                Console.Write("Öğrencinin Soyadını girin: ");
                                string soyad = Console.ReadLine();

                                Console.Write("Öğrencinin Yaşını girin: ");
                                int yas = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Öğrencinin Adresini girin: ");
                                string adres = Console.ReadLine();

                                Console.Write("Servisin rotasını girin (örneğin: A-B-C): ");
                                string servisRota = Console.ReadLine();

                               
                                Ogrenci yeniOgrenci = new Ogrenci(ad, soyad, yas, adres, servisRota);
                                ogrenciListesi.Add(yeniOgrenci);

                                Console.WriteLine("\nÖğrenci kaydedildi.");
                            }
                            else
                            {
                                Console.WriteLine("Kapasite dolmuş. Yeni öğrenci kaydı yapılamaz.");
                            }
                            break;

                        case 2:
                            
                            Console.WriteLine("\n--- Servise Kayıtlı Öğrenciler ---");
                            if (ogrenciListesi.Count == 0)
                            {
                                Console.WriteLine("Servise kayıtlı öğrenci bulunmamaktadır.");
                            }
                            else
                            {
                                foreach (var ogrenci in ogrenciListesi)
                                {
                                    ogrenci.BilgileriYazdir();
                                }
                            }
                            break;

                        case 3:
                            
                            Console.WriteLine("Uygulamadan çıkılıyor...");
                            devamEt = false;
                            break;

                        default:
                            Console.WriteLine("Geçersiz seçenek. Lütfen 1 ile 3 arasında bir seçenek girin.");
                            break;
                    }
                }
            }
        }

    }
}
 