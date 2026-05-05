using System;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Channels;

namespace RumahSakit
{
    class Program
    {
        static void Main()
        {
            rumahSakit rs = new rumahSakit("BINA SEHAT");

            Dokter dok1 = new Dokter("dr. Bobby", 68, "Jantung");
            Perawat per1 = new Perawat("Aini", 36, "Keperawatan Onkologi");
            PasienAnak anak1 = new PasienAnak("Nauli", 5, "rabies");
            PasienDewasa dew1 = new PasienDewasa("Subaru", 47, "sakit gigi");
            TenagaMedis medis1 = new TenagaMedis("Chesa", 35, "UGD");
            Pasien pasien1 = new Pasien("Aurelia", 19, "pusing");

            rs.TambahOrang(dok1);
            rs.TambahOrang(per1);
            rs.TambahOrang(anak1);
            rs.TambahOrang(dew1);
            rs.TambahOrang(medis1);
            rs.TambahOrang(pasien1);
            rs.DaftarOrang();

            Console.WriteLine("===== AKTIVITAS =====");
            dok1.Aktivitas();
            per1.Aktivitas();
            anak1.Aktivitas();
            dew1.Aktivitas();
            medis1.Aktivitas();
            pasien1.Aktivitas();
            Console.WriteLine();

            Console.WriteLine("===== METHOD =====");
            medis1.CekSpesialis();
            dok1.Diagnosa();
            per1.CekPasien();
            anak1.Menangis();
            dew1.Konsultasi();
            pasien1.CekKeluhan();
        }
    }
}