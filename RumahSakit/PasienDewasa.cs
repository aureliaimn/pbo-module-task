using System;
using System.Collections.Generic;
using System.Text;

namespace RumahSakit
{
    public class PasienDewasa : Pasien
    {
        public PasienDewasa(string nama, int umur, string keluhan) : base(nama, umur, keluhan) { }
        public void Konsultasi()
        {
            Console.WriteLine($"Pasien dewasa atas nama {nama} sedang berkonsultasi ke dokter.");
        }
        public override void Aktivitas()
        {
            Console.WriteLine($"Pasien dewasa bernama {nama} berumur {umur} tahun dengan keluhan {keluhan} sedang menunggu jadwal operasi.");
        }
    }
}
