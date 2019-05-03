using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsipemrog2293
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan krysatu = new Karyawan();

            krysatu.Nik = "33445566";
            krysatu.Nama = "Waluyo";
            krysatu.GajiBulanan = 2000000;

            Karyawan krydua = new Karyawan();

            krydua.Nik = "66554433";
            krydua.Nama = "Tumijo";
            krydua.GajiBulanan = 3000000;

            Console.WriteLine("No. \tNIK/nama\t\tGaji Bulanan");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1. \t{0} {1}\t\t{2}", krysatu.Nik, krysatu.Nama, krysatu.GajiBulanan);
            Console.WriteLine("1. \t{0} {1}\t\t{2}", krydua.Nik, krydua.Nama, krydua.GajiBulanan);
            Console.WriteLine("\n\n");
            Console.WriteLine("Asiqqq kenaikan gaji 10% nih!!");
            Console.WriteLine("\n");
            Console.WriteLine("No. \tNIK/nama\t\tGaji Bulanan");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1. \t{0} {1}\t\t{2}", krysatu.Nik, krysatu.Nama, krysatu.GajiBulanan + (krysatu.GajiBulanan * 0.10));
            Console.WriteLine("1. \t{0} {1}\t\t{2}", krydua.Nik, krydua.Nama, krydua.GajiBulanan + (krysatu.GajiBulanan * 0.10));
            Console.ReadKey();
        }

    }
}
