using System;

namespace projectPBO
{
    public class Pemesan
    {
        public string nama;
        string noTelp;
        string alamat;
        // public string pesanan;

        public Pemesan(string nama, string noTelp, string alamat)
        {
            this.nama = nama;
            this.noTelp = noTelp;
            this.alamat = alamat;
        }

        // public void pelanggan(string pesanan)
        // {
        //     this.pesanan = pesanan;
        // }
        
        public void infoPemesan()
        {
            Console.WriteLine("DATA PEMESAN");
            Console.WriteLine("Nama Pemesan: " + nama);
            Console.WriteLine("Nomor Telepon Pemesan: " + noTelp);
        }

        public void infoPemesan(string tujuan)
        {
            Console.WriteLine("akan dikirim menuju " + alamat);
        }
    }
}