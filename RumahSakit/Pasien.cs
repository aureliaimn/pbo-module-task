using System;
using System.Collections.Generic;
using System.Text;

namespace RumahSakit
{
    public class Pasien : Orang
    {
        public string keluhan;

        public Pasien(string nama, int umur, string keluhan) : base(nama, umur)
        {
            this.keluhan = keluhan;
        }
        public void CekKeluhan()
        {
            Console.WriteLine($"Keluhan dari pasien atas nama {nama} adalah {keluhan}.");
        }
        public override void Aktivitas()
        {
            Console.WriteLine($"Pasien atas nama {nama} sedang menunggu pemeriksaan.");
        }
    }
}
