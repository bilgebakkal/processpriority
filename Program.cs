
using System;

namespace MatematikselHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matematiksel ifadeyi girin:");
            string ifade = Console.ReadLine();

            double sonuc = Hesapla(ifade);
            Console.WriteLine("Sonuç: " + sonuc);
        }

        static double Hesapla(string ifade)
        {
            try
            {
                return Convert.ToDouble(new System.Data.DataTable().Compute(ifade, null));
            }
            catch (Exception)
            {
                Console.WriteLine("Geçersiz bir ifade girdiniz.");
                return 0;
            }
        }
    }
}

