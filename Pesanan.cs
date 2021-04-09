using System;

namespace projectPBO
{
    public class Pesanan
    {
        double jumlahPesanan;
        double hargaSatuan;

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
    }
}