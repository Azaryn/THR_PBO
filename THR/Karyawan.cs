using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THR
{
    abstract class Karyawan
    {
        private string _Nama;
        private string _ID;
        private double _GajiPokok;

        public string Nama
        {
            get { return _Nama; }
            set { _Nama = value; }
        }
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public double GajiPokok
        {
            get { return _GajiPokok; }
            set { _GajiPokok = value; }
        }
        public abstract void HitungGaji(double gajiPokok);
    }
}
