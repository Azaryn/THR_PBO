using System.Text.RegularExpressions;
using System.Threading.Channels;

class Program
{
    static void Main()
    {
        do
        {

            Console.WriteLine("==================================");
            Console.WriteLine("Selamat Datang di Perusahaan Y4NT0");
            Console.WriteLine("==================================");

            Console.Write("Masukkan Nama Anda: ");
            string nama_karyawan = Console.ReadLine()!;

            Console.WriteLine("[1] Karyawan Tetap");
            Console.WriteLine("[2] Karyawan Kontrak");
            Console.WriteLine("[3] Karyawan Magang");
            Console.Write("Masukkan ID Anda (1 digit): ");
            string id_karyawan = Console.ReadLine()!;

            switch (id_karyawan)
            {
                case "1":
                    Console.Write("Masukkan Gaji Pokokmu: ");
                    double gajiTetap = Convert.ToDouble(Console.ReadLine());
                    KaryawanTetap Ktetap = new KaryawanTetap(nama_karyawan, id_karyawan);
                    Ktetap.HitungGaji(gajiTetap);

                    break;
                case "2":
                    Console.Write("Masukkan Gaji Pokokmu: ");
                    double gajiKontrak = Convert.ToDouble(Console.ReadLine());
                    KaryawanKontrak Kkontrak = new KaryawanKontrak(nama_karyawan, id_karyawan);
                    Kkontrak.HitungGaji(gajiKontrak);
                    break;
                case "3":
                    Console.Write("Masukkan Gajimu: ");
                    double gajimagang = Convert.ToDouble(Console.ReadLine());
                    KaryawanMagang Kmagang = new KaryawanMagang(nama_karyawan,id_karyawan);
                    Kmagang.HitungGaji(gajimagang);
                    break;
                default:
                    Console.WriteLine("Jabatan Tidak ada, Silakan coba lagi.");
                    break;
            }
            Console.WriteLine("Apakah mau melihat karyawan lain? [Y?N]: ");
        } while (Console.ReadLine()?.ToUpper() == "Y");
        Console.WriteLine("Terimakasih, Bye! ^0^");

    }
}
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
class KaryawanTetap : Karyawan
{
    private double Bonus = 500000;
    public KaryawanTetap(string nama,string id) : base()
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