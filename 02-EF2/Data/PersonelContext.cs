using _02_Ef.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Ef.Data
{
    internal class PersonelContext:DbContext
    {
        public DbSet<Personel> Personller { get; set; }

        public DbSet<Bolum> Bolumler { get; set; }

        //public DbSet<>

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data source=.;initial catalog=YY2_PersonelDB;integrated security=true;trust server certificate=true");
        }



    }
}

