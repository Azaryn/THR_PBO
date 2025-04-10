using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THR
{
    class KaryawanMagang : Karyawan
    {
        public KaryawanMagang(string nama, string id) : base()
        {
            Nama = nama;
            ID = id + DateTime.Now.ToString("dd");
            Console.WriteLine($"Nama Karyawan Magang: {Nama}");
            Console.WriteLine($"ID Card Karyawan Magang: {ID}");
        }
        public override void HitungGaji(double gajiPokok)
        {
            GajiPokok = gajiPokok;
            Console.WriteLine($"Nama {Nama} bulan ini sebesar {GajiPokok}");
        }
    }
}
