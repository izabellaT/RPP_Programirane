using System;

namespace Basketball
{
    class Program
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());

            double kecove = 0;
            kecove = tax - 40 * tax / 100;

            double ekip = 0;
            ekip = kecove - 20 * kecove / 100;

            double topka = 0;
            topka = ekip * 1/4 ;

            double aksesoari = 0;
            aksesoari = topka * 1/5  ;

            double suma = 0;
            suma = kecove + ekip + topka + aksesoari + tax;

            Console.WriteLine($"{suma:f2}");
        }
    }
}
