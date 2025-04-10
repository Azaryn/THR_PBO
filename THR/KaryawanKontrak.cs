using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THR
{
    class KaryawanKontrak : Karyawan
    {
        private double Potongan = 200000;
        public KaryawanKontrak(string nama, string id) : base()
        {
            Nama = nama;
            ID = id + DateTime.Now.ToString("dd");
            Console.WriteLine($"Nama Karyawan Kotrak: {Nama}");
            Console.WriteLine($"ID Card Karyawan Kotrak: {ID}");
        }
        public override void HitungGaji(double gajiPokok)
        {
            GajiPokok = gajiPokok;
            double TotalGaji = GajiPokok - Potongan;
            Console.WriteLine($"Gaji {Nama} bulan ini sebesar {TotalGaji}");
        }
    }
}
