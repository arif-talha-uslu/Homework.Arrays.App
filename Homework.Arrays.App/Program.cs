using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iki.Boyutlu.Diziler.App
{
    class Program
    {
        static void Main(string[] args)//ARIF TALHA USLU 203801009 || FROM: GAZI UNIVERSITY
        {
            Console.Write("Toplam öğrenci sayısını giriniz: ");
            byte mevcut = byte.Parse(Console.ReadLine());

            string[,] ogrenciler = new string[mevcut + 1, 6];//TODO: DİZİYİ TANIMLAMA
            ogrenciler[0, 0] = "Ad";
            ogrenciler[0, 1] = "Soyad";
            ogrenciler[0, 2] = "Vize";
            ogrenciler[0, 3] = "Final";
            ogrenciler[0, 4] = "Ort";
            ogrenciler[0, 5] = "Harf Notu";

            for (int i = 1; i < ogrenciler.GetLength(0); i++)//TODO: HER SATIR İÇİN DEĞER ATAMA
            {
                double vize=0;//her satırda not değerleri sıfırlanmalı
                double final=0;//sütunlar arasında işlem olduğundan
                double ort=0;//satır bölümünde tanımladım
                Console.WriteLine(" ");
                for (int j = 0; j < ogrenciler.GetLength(1); j++)//TODO: HER SÜTUN İÇİN DEĞER ATAMA
                {
                    switch (j)
                    {
                        case 0:
                            Console.Write($"{i}. Öğrencinin Adını Giriniz: ");
                            ogrenciler[i, j] = Console.ReadLine();
                            break;

                        case 1:
                            Console.Write($"{i}. Öğrencinin Soyadını Giriniz: ");
                            ogrenciler[i, j] = Console.ReadLine();
                            break;

                        case 2:
                            Console.Write($"{i}. Öğrencinin Vize Notunu Giriniz(Sayıyla): ");
                            vize = double.Parse(Console.ReadLine());//ondalık işlem yapabilmek için double tipinde alıyorum
                            ogrenciler[i, j] = Convert.ToString(vize);//dizimiz string olduğu için, atama yaparken stringe dönüştürüyorum
                            break;

                        case 3:
                            Console.Write($"{i}. Öğrencinin Final Notunu Giriniz(Sayıyla): ");
                            final = double.Parse(Console.ReadLine());
                            ogrenciler[i, j] = Convert.ToString(final);
                            break;

                        case 4:
                            ort = Ortalama(vize, final);//ORTALAMA ALMA METODUMUZU ÇAĞIRDIM
                            ogrenciler[i, j] = Convert.ToString(ort);
                            break;

                        case 5:
                            ogrenciler[i, j] = Harf(ort);//HARF NOTU METODUMUZU ÇAĞIRDIM
                            break;

                        default:
                            break;
                    }
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("-----------------------------------------------------------------------");
            for (int i = 0; i < ogrenciler.GetLength(0); i++)//TODO: DİZİYİ YAZDIRMA
            {
                for (int j = 0; j < ogrenciler.GetLength(1); j++)
                {
                    Console.Write(ogrenciler[i, j] + "\t\t");
                }
                Console.WriteLine(" ");
            }
        }

        static double Ortalama(double vize, double final)//TODO: ORTALAMA METODU
        {
            double ortalama = (vize * 40) / 100 + (final * 60) / 100;
            return ortalama;
        }

        static string Harf(double ortalama)//TODO: HARF NOTU METODU
        {
            string harfnotu = "bos";
            double not = (ortalama * 4) / 100;

            if (4 >= not && not > 3.5){harfnotu = "AA";}

            else if (3.5 >= not && not > 3){harfnotu = "BA";}

            else if (3 >= not && not > 2.5){harfnotu = "BB";}

            else if (2.5 >= not && not > 2){harfnotu = "CB";}

            else if (2 >= not && not > 1.5){harfnotu = "CC";}

            else if (1.5 >= not && not > 1){harfnotu = "DC";}

            else if (1 >= not && not > 0.5){harfnotu = "DD";}

            else if (0.5 >= not && not > 0){harfnotu = "FD";}

            else if (not == 0){harfnotu = "FF";}

            return harfnotu;
        }
    }
}
