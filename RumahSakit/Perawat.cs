using System;
using System.Collections.Generic;
using System.Text;

namespace RumahSakit
{
    public class Perawat : TenagaMedis
    {
        public Perawat(string nama, int umur, string spesialisasi) : base(nama, umur, spesialisasi) { }
        public void CekPasien()
        {
            Console.WriteLine($"Perawat spesialis {spesialisasi} bernama {nama} sedang mengecek seorang pasien.");
        }
        public override void Aktivitas()
        {
            Console.WriteLine($"Perawat spesialis {spesialisasi} bernama {nama} yang berumur {umur} tahun sedang mengganti infus pasien.");
        }
    }
}
