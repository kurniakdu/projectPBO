using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppNetCoreEf.Entities
{
    public class pesananOrang
    {
        public string namaPemesan { get; set; }
        public string telpPemesan { get; set; }
        public string alamatPesanan { get; set; }
        public int banyakPesanan { get; set; }
        public int durasiPesanan { get; set; }
    }
}
