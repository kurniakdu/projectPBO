using System;
// using coba1;
// using coba2; //hampir berhasil :')
// using coba3;
using coba4; //AKHIRNYA BERHASIL !! 

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

            Console.WriteLine("\nPilihan pesanan:\n- Kaos\n- Kemeja\n- Jas");
            Console.WriteLine("\nPilih produk!");
            string orderan = Console.ReadLine();
            Console.WriteLine("Masukan jumlah pesanan: ");
            string jumlahPesanan = Console.ReadLine();
            double lamaProduksi = 0;
            double reqHari = 0;
            double bayarWe = 0;
            // Pesanan pesanan;
            

            if (orderan == "Kaos")
            {
                Kaos pesanan = new Kaos(Convert.ToDouble(jumlahPesanan));
                pesanan.dataPesanan(ref bayarWe, ref lamaProduksi);
                pelanggan.order(orderan, Convert.ToDouble(jumlahPesanan), bayarWe, lamaProduksi);
                bool adaReq = pesanan.mauCepat(lamaProduksi, ref bayarWe, ref reqHari); 
                if (adaReq == true) 
                {
                    pelanggan.editOrder(reqHari,  bayarWe);
                    Console.WriteLine("\nData pesanan telah diperbaharui.");
                    pelanggan.detailOrderan();
                    // konfirm(orderan, bayarWe, reqHari, alamat);
                    // Console.WriteLine("\nKONFIRMASI PEMESANAN");
                    // Console.WriteLine("=================================\n");
                    // pelanggan.infoPemesan();
                    // pesanan.infoPesanan(orderan, bayarWe, reqHari);
                    // pelanggan.infoPemesan(alamat);
                    penutup();
                }
                else
                {
                    pelanggan.detailOrderan();
                    // konfirm(orderan, bayarWe, lamaProduksi, alamat);
                    // Console.WriteLine("\nKONFIRMASI PEMESANAN");
                    // Console.WriteLine("=================================\n");
                    // pelanggan.infoPemesan();
                    // pesanan.infoPesanan(orderan, bayarWe, lamaProduksi);
                    // pelanggan.infoPemesan(alamat);
                    penutup();
                }
            }
            else if (orderan == "Kemeja")
            {
                Kemeja pesanan = new Kemeja(Convert.ToDouble(jumlahPesanan));
                pesanan.dataPesanan(ref bayarWe, ref lamaProduksi);
                pelanggan.order(orderan, Convert.ToDouble(jumlahPesanan), bayarWe, lamaProduksi);
                bool adaReq = pesanan.mauCepat(lamaProduksi, ref bayarWe, ref reqHari); 
                if (adaReq == true) 
                {
                    pelanggan.editOrder(reqHari,  bayarWe);
                    Console.WriteLine("\nData pesanan telah diperbaharui.");
                    pelanggan.detailOrderan();
                    // konfirm(orderan, bayarWe, reqHari, alamat);
                    // Console.WriteLine("\nKONFIRMASI PEMESANAN");
                    // Console.WriteLine("=================================\n");
                    // pelanggan.infoPemesan();
                    // pesanan.infoPesanan(orderan, bayarWe, reqHari);
                    // pelanggan.infoPemesan(alamat);
                    penutup();
                }
                else
                {
                    pelanggan.detailOrderan();
                    // konfirm(orderan, bayarWe, lamaProduksi, alamat);
                    // Console.WriteLine("\nKONFIRMASI PEMESANAN");
                    // Console.WriteLine("=================================\n");
                    // pelanggan.infoPemesan();
                    // pesanan.infoPesanan(orderan, bayarWe, lamaProduksi);
                    // pelanggan.infoPemesan(alamat);
                    penutup();
                }
            }
            else
            {
                Console.WriteLine("\nMohon maaf, produk belum tersedia.");
                Console.WriteLine("\nKONFIRMASI PEMESANAN");
                Console.WriteLine("=================================\n");
                pelanggan.infoPemesan();
                Console.WriteLine("\nDATA PESANAN\nJenis produk pesanan: " + orderan + " (belum tersedia)");
                // pelanggan.infoPemesan(alamat);
                // penutup();
                Console.WriteLine("\nMohon maaf atas ketidak-nyamanannya.");
            }

            // void konfirm(object pesanan, string jenis, double harga, double durasi, string alamat)
            // {
            //     Console.WriteLine("\nKONFIRMASI PEMESANAN\n");
            //     pelanggan.infoPemesan();
            //     pesanan.infoPesanan(orderan, bayarWe, reqHari);
            //     pelanggan.infoPemesan(alamat);
            //     penutup();
            // }

            void penutup(){
                Console.WriteLine("\nTerima kasih sudah memesan ^^\n");
            }
        }
    }
}
