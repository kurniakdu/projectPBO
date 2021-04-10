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

            Console.WriteLine("\nPilihan pesanan:\n- Kaos\n- Belum ada");
            Console.WriteLine("\nPilih produk!");
            string orderan = Console.ReadLine();
            Console.WriteLine("Masukan jumlah pesanan: ");
            string jumlahPesanan = Console.ReadLine();
            double lamaProduksi = 0;
            double reqHari = 0;
            double bayarWe = 0;

            if (orderan == "Kaos")
            {
                Kaos pesanan1 = new Kaos(Convert.ToDouble(jumlahPesanan));
                pesanan1.dataPesanan(ref bayarWe, ref lamaProduksi);
                bool adaReq = pesanan1.mauCepat(lamaProduksi, ref bayarWe, ref reqHari); 
                if (adaReq == true) 
                {
                    Console.WriteLine("Data pesanan telah diperbaharui");
                    Console.WriteLine("\nKONFIRMASI PEMESANAN\n");
                    pelanggan.infoPemesan();
                    pesanan1.infoPesanan(orderan, bayarWe, reqHari);
                    pelanggan.infoPemesan(alamat);
                    penutup();
                }
                else
                {
                    Console.WriteLine("\nKONFIRMASI PEMESANAN\n");
                    pelanggan.infoPemesan();
                    pesanan1.infoPesanan(orderan, bayarWe, lamaProduksi);
                    pelanggan.infoPemesan(alamat);
                    penutup();
                }
            }
            else
            {
                Console.WriteLine("Belom tersedia guys, mohon maap.");
                Console.WriteLine("\nKONFIRMASI PEMESANAN\n");
                pelanggan.infoPemesan();
                Console.WriteLine("\nDATA PESANAN\nJenis produk pesanan: "+orderan+"(tidak tersedia)");
                pelanggan.infoPemesan(alamat);
                penutup();
            }

            void penutup(){
                Console.WriteLine("\nTerima kasih sudah memesan ^^\n");
            }
        }
    }
}
