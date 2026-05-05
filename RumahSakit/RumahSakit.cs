using System;
using System.Collections.Generic;
using System.Text;

namespace RumahSakit
{
    public class rumahSakit
    {
        public string namaRS;
        public List<Orang> daftarOrang = new List<Orang>();

        public rumahSakit(string namaRS)
        {
            this.namaRS = namaRS;
        }
        public void TambahOrang(Orang orang)
        {
            daftarOrang.Add(orang);
        }

        public void DaftarOrang()
        {
            Console.WriteLine($"====== DAFTAR ORANG DI RUMAH SAKIT {namaRS} ======");
            foreach (var orang in daftarOrang)
            {
                orang.InfoOrang();
                Console.WriteLine(" ");
            }
        }
    }
}
