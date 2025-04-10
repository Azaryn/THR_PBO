using System.Text.RegularExpressions;
using System.Threading.Channels;
using THR;
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