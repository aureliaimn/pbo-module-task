using System;
using System.Collections.Generic;
using System.Text;

namespace RumahSakit
{
    public class Orang
    {
        public string nama;
        public int umur;

        public Orang(string nama, int umur)
        {
            this.nama = nama;
            this.umur = umur;
        }
        public virtual void Aktivitas()
        {
            Console.WriteLine($"{nama} sedang berada di Rumah Sakit.");
        }

        public void InfoOrang()
        {
            Console.WriteLine($"Nama : {nama}, Umur : {umur} tahun.");
        }
    }
}
