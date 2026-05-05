using System;
using System.Collections.Generic;
using System.Text;

namespace RumahSakit
{
    public class TenagaMedis : Orang
    {
        public string spesialisasi;

        public TenagaMedis(string nama, int umur, string spesialisasi) : base(nama, umur)
        {
            this.spesialisasi = spesialisasi;
        }
        public void CekSpesialis()
        {
            Console.WriteLine($"{nama} merupakan spesialis {spesialisasi}.");
        }
        public override void Aktivitas()
        {
            Console.WriteLine($"{nama} sedang memonitor pasien.");
        }
    }
}
