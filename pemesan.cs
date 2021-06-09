using System;
// using System.ComponentModel.DataAnnotations.Schema;
// using System.Data.SqlTypes;

namespace projectPBO
{
    public class Pemesan
    {
        public string nama;
        string noTelp;
        string alamat;
        public string pesanan;
        public double jumlah;
        double harga;
        double durasi;

        public Pemesan(string nama, string noTelp, string alamat)
        {
            this.nama = nama;
            this.noTelp = noTelp;
            this.alamat = alamat;
        }

        public void order(string pesanan, double jumlah, double harga, double durasi)
        {
            this.pesanan = pesanan;
            this.jumlah = jumlah;
            this.harga = harga;
            this.durasi = durasi;
        }

        public void editOrder(double durasi, double harga)
        {
            this.durasi = durasi;
            this.harga = harga;
        }

        // // Table("Orderan");
        // public void inputData()
        // {

        // }

        public void infoPemesan()
        {
            Console.WriteLine("DATA PEMESAN");
            Console.WriteLine("Nama Pemesan: " + nama);
            Console.WriteLine("Nomor Telepon Pemesan: " + noTelp);
        }

        // public void infoPemesan(string tujuan)
        // {
        //     Console.WriteLine("akan dikirim menuju " + alamat);
        // }

        public void detailOrderan()
        {
            Console.WriteLine("\nKONFIRMASI PEMESANAN");
            Console.WriteLine("=================================\n");
            Console.WriteLine("DATA PEMESAN");
            Console.WriteLine("Nama Pemesan: " + nama);
            Console.WriteLine("Nomor Telepon Pemesan: " + noTelp);
            Console.WriteLine("\nDATA PESANAN");
            Console.WriteLine("Jenis produk pesanan: " + pesanan);
            Console.WriteLine("Banyak pesanan: " + jumlah);
            Console.WriteLine("Jumlah harga pesanan: " + harga);
            Console.WriteLine("Durasi produksi pesanan: " + durasi);
            Console.WriteLine("akan dikirim menuju " + alamat);
        }
    }
}