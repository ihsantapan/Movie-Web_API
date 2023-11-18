using Microsoft.EntityFrameworkCore;
using Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repositories.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Oyuncu> Oyuncular { get; set; }
        public DbSet<Film> Filmler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\\\MSSQLLocalDB;Database=MovieAPI;Trusted_Connection=True;");
        }

    }
}
