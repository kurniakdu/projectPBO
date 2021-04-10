using System;

namespace coba3
{
    public class Pesanan
    {
        double jumlahPesanan;
        double hargaSatuan;
        double waktuProduksiPerLusin;

        public double harga(double jumlahPesanan, double hargaSatuan)
        {
            double jumlahHarga = jumlahPesanan*hargaSatuan;
            return jumlahHarga;
        }

        public double percepatan(double asli, double req, double harga)
        {
            double totalHarga = 0;
            totalHarga = harga + (1 - req/asli) * harga;
            return totalHarga;
        }

        public double totalWaktu(double jumlahProduksi, double waktuProduksiPerLusin)
        {
            double totalWaktuProduksi = 0;
            if (jumlahProduksi%12 == 0)
            {
                totalWaktuProduksi = (jumlahProduksi/12) * waktuProduksiPerLusin;
            }
            else
            {
                int produksi = (int)jumlahProduksi/12;
                totalWaktuProduksi = (produksi + 1) * waktuProduksiPerLusin;
            }
            return totalWaktuProduksi;
        }

        public void dataPesanan(double jumlahHarga, double lamaProduksi)
        {
            jumlahHarga = harga(jumlahPesanan, hargaSatuan);
            Console.WriteLine($"\nJumlah harga pesanan adalah {jumlahHarga}");
            lamaProduksi = totalWaktu(jumlahPesanan, waktuProduksiPerLusin);
            Console.WriteLine($"Durasi produksi adalah {lamaProduksi} hari");
        }

        public bool mauCepat(double lamaProduksi, double jumlahHarga, double reqHari)
        {
            Console.WriteLine("\nApakah ada mau mempercepat durasi produksi? (ya/tidak)");
            string ans = Console.ReadLine();
            if (ans == "ya")
            {
                Console.WriteLine("Masukan permintaan durasi (dalam hari)!");
                reqHari = Convert.ToDouble(Console.ReadLine());
                if (reqHari<lamaProduksi)
                {
                    jumlahHarga = percepatan(lamaProduksi, reqHari, jumlahHarga);
                    return true;
                }
                else if(reqHari==lamaProduksi)
                {
                    Console.WriteLine("Durasi produksi tidak berubah");
                    mauCepat(lamaProduksi, jumlahHarga, reqHari);
                }
                else
                {
                    Console.WriteLine("Durasi produksi tidak dipercepat");
                    mauCepat(lamaProduksi, jumlahHarga, reqHari);
                }
            }
            else if (ans != "tidak")
            {
                Console.WriteLine("Pilihan tidak dipahami. Maksud Anda apa woi?!");
            }
            return false;
        }

        public void infoPesanan(string produk, double totalHarga, double durasi)
        {
            Console.WriteLine("\nDATA PESANAN");
            Console.WriteLine("Jenis produk pesanan: " + produk);
            Console.WriteLine("Jumlah harga pesanan: " + totalHarga);
            Console.WriteLine("Durasi produksi pesanan: " + durasi);
        }
    }
}