using System;

namespace MobilApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil = new Mobil();

            // Set properti mobil
            mobil.Warna = "Putih";
            mobil.JumlahPintu = 4;
            mobil.Merek = "Kijang";
            mobil.Model = "Innova";
            mobil.TahunKeluaran = 2015;

            // Panggil method mobil
            mobil.TampilInfo();
            mobil.Klakson();
            mobil.HitungKecepatan(160, 2);

            Console.ReadKey();
        }
    }
}

