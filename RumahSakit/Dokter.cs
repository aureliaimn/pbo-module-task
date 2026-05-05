 using System;
using System.Collections.Generic;
using System.Text;

namespace RumahSakit
{
    public class Dokter : TenagaMedis
    {
        public Dokter(string nama, int umur, string spesialisasi) : base(nama, umur, spesialisasi) { }
        public void Diagnosa()
        {
            Console.WriteLine($"Dokter spesialis {spesialisasi} bernama {nama} sedang mendiagnosa pasien.");
        }
        public override void Aktivitas()
        {
            Console.WriteLine($"Dokter spesialis {spesialisasi} bernama {nama} yang berumur {umur} tahun sedang beristirahat.");
        }
    }
}
