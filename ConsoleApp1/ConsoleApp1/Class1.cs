using System;

namespace MobilApp
{
    internal class Mobil
    {
        //fields
        private string _warna;
        private float _jumlahPintu;
        private string _merek;
        private string _model;
        private float _tahunKeluaran;

        // Properti mobil
        public string Warna
        {
            get { return _warna; }
            set { _warna = value; }
        }

        public float JumlahPintu
        {
            get { return _jumlahPintu; }
            set { _jumlahPintu = value; }
        }

        public string Merek
        {
            get { return _merek; }
            set { _merek = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public float TahunKeluaran
        {
            get { return _tahunKeluaran; }
            set { _tahunKeluaran = value; }
        }

        // Method mobil
        public void HitungKecepatan(int jarak, int waktu)
        {
            double kecepatan = (double)jarak / waktu;
            Console.WriteLine($"Kecepatan mobil adalah {kecepatan} km/jam");
        }

        public void Klakson()
        {
            Console.WriteLine("Bunyi Klakson    : Pimp! Pimp!");
        }

        public void TampilInfo()
        {
            Console.WriteLine($"Merek Mobil      : {Merek}");
            Console.WriteLine($"Dengan model     : {Model}");
            Console.WriteLine($"Variasi warna    : {Warna}");
            Console.WriteLine($"Jumlah Pintu     : {JumlahPintu} pintu");
            Console.WriteLine($"Keluaran tahun   : {TahunKeluaran}");
        }
    }
}
