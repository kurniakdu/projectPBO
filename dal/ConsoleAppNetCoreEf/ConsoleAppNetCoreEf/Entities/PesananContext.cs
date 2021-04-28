using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppNetCoreEf.Entities
{
    public class PesananContext : DbContext
    {
        public DbSet<pesananOrang> Orderan { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source=(localdb)\mssqllocaldb; Onotial catalog=OrdeDb;");
        }
        
    }
}
