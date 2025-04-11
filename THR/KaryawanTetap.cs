using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THR
{
    class KaryawanTetap : Karyawan
    {
        private double Bonus = 500000;
        public KaryawanTetap(string nama, string id)
        {
            Nama = nama;
            ID = id + DateTime.Now.ToString("dd");
            Console.WriteLine($"Nama Karyawan Tetap: {Nama}");
            Console.WriteLine($"ID Card Karyawan Tetap: {ID}");
        }
        public override void HitungGaji(double gajiPokok)
        {
            GajiPokok = gajiPokok;
            double TotalGaji = GajiPokok + Bonus;
            Console.WriteLine($"Gaji {Nama} bulan ini sebesar {TotalGaji}");
        }
    }
}
