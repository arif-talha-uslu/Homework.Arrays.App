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
            int mevcut = int.Parse(Console.ReadLine());

            string[,] ogrenciler = new string[mevcut + 1, 6];//TODO: DİZİYİ TANIMLAMA
            ogrenciler[0, 0] = "Ad";
            ogrenciler[0, 1] = "Soyad";
            ogrenciler[0, 2] = "Vize";
            ogrenciler[0, 3] = "Final";
            ogrenciler[0, 4] = "Ort";
            ogrenciler[0, 5] = "Harf Notu";

            for (int i = 1; i < ogrenciler.GetLength(0); i++)//TODO: HER SATIR İÇİN DEĞER ATAMA
            {
                string vize = "";
                string final = "";
                Console.WriteLine(" ");
                for (int j = 0; j < ogrenciler.GetLength(1); j++)//TODO: HER SÜTUN İÇİN DEĞER ATAMA
                {
                    double vizenot;
                    double finalnot;
                    double ort;
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
                            vize = Console.ReadLine();
                            ogrenciler[i, j] = vize;
                            break;

                        case 3:
                            Console.Write($"{i}. Öğrencinin Final Notunu Giriniz(Sayıyla): ");
                            final = Console.ReadLine();
                            ogrenciler[i, j] = final;
                            break;

                        case 4:
                            vizenot = Convert.ToDouble(vize);//Değişken tipini şimdilik işlem yapabilmek için,
                            finalnot = Convert.ToDouble(final);//Double tipine dönüştürüyorum

                            ort = Ortalama(vizenot, finalnot);//ORTALAMA ALMA METODUMUZU ÇAĞIRDIM

                            string ortString = Convert.ToString(ort);//Burada da dizi string tipinde olduğu için stringe geri dönüştürüyorum
                            ogrenciler[i, j] = ortString;
                            break;

                        case 5:
                            vizenot = Convert.ToDouble(vize);
                            finalnot = Convert.ToDouble(final);

                            ort = Ortalama(vizenot, finalnot);
                           
                            ogrenciler[i, j] = Harf(ort);//HARF NOTU METODUMUZU ÇAĞIRDIM
                            break;

                        default:
                            break;
                    }
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------------------------------------------------------------");
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
            double bir = (vize * 40) / 100;
            double iki = (final * 60) / 100;
            double sonuc = bir + iki;
            return sonuc;
        }

        static string Harf(double ortalama)//TODO: HARF NOTU METODU
        {
            string harfnotu = "bos";
            double not = (ortalama * 4) / 100;
            if (4 >= not && not > 3.5)
            {
                harfnotu = "AA";
            }
            else if (3.5 >= not && not > 3)
            {
                harfnotu = "BA";
            }
            else if (3 >= not && not > 2.5)
            {
                harfnotu = "BB";
            }
            else if (2.5 >= not && not > 2)
            {
                harfnotu = "CB";
            }
            else if (2 >= not && not > 1.5)
            {
                harfnotu = "CC";
            }
            else if (1.5 >= not && not > 1)
            {
                harfnotu = "DC";
            }
            else if (1 >= not && not > 0.5)
            {
                harfnotu = "DD";
            }
            else if (0.5 >= not && not > 0)
            {
                harfnotu = "FD";
            }
            else if (not == 0)
            {
                harfnotu = "FF";
            }
            return harfnotu;
        }
    }
}
