using System;

namespace projectPBO
{
    public class Pesanan
    {
            

        public double percepatan(double asli, double req, double harga)
        {
            double totalHarga = 0;
            totalHarga = harga + (1 - req/asli) * harga;
            return totalHarga;
        }
    }
}