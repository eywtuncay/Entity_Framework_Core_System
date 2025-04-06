using _08_Ornek.Models;
using _08_Ornek.Models.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _08_Ornek.Data
{
    internal class SahafContext : DbContext
    {
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<KitapYazar> KitapYazarlar { get; set; }
        public DbSet<Barkod> Barkodlar { get; set; }
        public DbSet<Yayinevi> Yayinevleri { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=.;initial catalog=Sahaf;integrated security=true;trust server certificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Configurations kullanmak için 2 yöntem

            //1. Yöntem --> Kaç tane CFG sınıfı var ise hepsi tanımlanmalıdır.
            modelBuilder.ApplyConfiguration(new Kitap_CFG());


            //Mecbur kalmadıkça bir aşağıdaki gibi kullanma
            modelBuilder.Entity<Yayinevi>()
                .Property(x => x.Ad)
                .HasMaxLength(150)
                .HasColumnType("varchar");


            //2. Yöntem Model Builder --> Kendisi otomatik olarak configurationsları bulur. (Kolay yöntem)
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            modelBuilder.ApplyConfiguration(new Kategori_CFG());


        }
    }
}
