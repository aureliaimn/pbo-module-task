using System;
using System.Collections.Generic;
using System.Text;

namespace RumahSakit
{
    public class PasienAnak : Pasien
    {
        public PasienAnak(string nama, int umur, string keluhan) : base(nama, umur, keluhan) { }
        public void Menangis()
        {
            Console.WriteLine($"Pasien anak bernama {nama} sedang menangis.");
        }
        public override void Aktivitas()
        {
            Console.WriteLine($"Pasien anak bernama {nama} berumur {umur} tahun dengan keluhan {keluhan} sedang menunggu obatnya.");
        }
    }
}
