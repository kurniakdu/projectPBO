using System.IO.Compression;
using System;

namespace projectPBO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selamat Datang di AN/DERAN");
            Console.WriteLine("=================================");
            Console.WriteLine("Masukan nama Anda!");
            string nama = Console.ReadLine();
            Console.WriteLine("Masukan nomor telepon Anda!");
            string noTelp = Console.ReadLine();
            Console.WriteLine("Masukan alamat pengiriman pesanan!");
            string alamat = Console.ReadLine();

            Pemesan pelanggan = new Pemesan(nama, noTelp, alamat);
        }
    }
}
