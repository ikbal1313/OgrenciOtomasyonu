using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _170924_3
{
    internal class Metodlar
    {
        public static string GetString(string metin, int min=int.MinValue, int max=int.MaxValue)
        {
            string txt = string.Empty;  
            bool hata = false;
            do
            {

                Console.Write(metin);
                txt = Console.ReadLine();
                if (string.IsNullOrEmpty(txt))
                {
                    Console.WriteLine("Değer boş bırakılamaz");
                    hata = true;
                }

                else
                {
                    if (txt.Length< min || txt.Length > max)
                    {
                        Console.WriteLine("Lütfen min. {0}, max. {1} karakter giriniz", min,max);
                        hata = true;
                    }
                    else if (!IsOnlyLetter(txt.Replace(" ","")))
                    {
                        Console.WriteLine("Lütfen sadece harf giriniz");
                        hata = true;
                    }
                    else
                    {
                        hata = false;
                    }
                }

            } while (hata);
            return txt;

        }

        private static bool IsOnlyLetter(string txt)
        {
            foreach (var character in txt)
            {
                if (!char.IsLetter(character))
                {
                    return false;
                }
            }
            return true;
        }
        public static int GetInt(string metin, int min = int.MinValue, int max = int.MaxValue)
        {
            int sayi = 0;
            bool hata = false;
            do
            {
                Console.Write(metin);
                try
                {
                    sayi = int.Parse(Console.ReadLine());
                    if (sayi>= min&&sayi<=max)
                    {
                        hata = false;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen min {0}, max {1} aralığında değer giriniz",min,max);
                        hata = true;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            } while (hata);
            return sayi;

             
        }

        public static double GetDouble(string metin, double min = double.MinValue, double max = double.MaxValue)
        {
            double sayi= 0;
            bool hata = false;
            do
            {
                Console.Write(metin);
                try
                {
                    sayi = double.Parse(Console.ReadLine());
                    if (sayi>=min&& sayi<=max)
                    {
                        hata = false;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen min.{0},max{1} aralığında sayı giriniz",min,max);
                        hata = true;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    hata= true;
                }
            } while (hata);

            return sayi;
        }

        public static DateTime GetDateTime(string metin, int minYear, int maxYear)
        {
            DateTime date = DateTime.Now;
            bool hata = false;

            do
            {
                Console.Write(metin);
                try
                {
                    date = DateTime.Parse(Console.ReadLine());
                    if (date.Year>= minYear && date.Year <= maxYear)
                    {
                        hata = false;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen min. {0},max{1} yılları arasında bir değer giriniz",minYear,maxYear);
                        hata = true;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    hata= true;
                }
            } while (hata);
            return date;

        }

    } 
}
