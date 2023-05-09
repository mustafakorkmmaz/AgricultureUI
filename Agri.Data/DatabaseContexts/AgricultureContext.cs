using Agri.Entity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Agri.Data.DatabaseContexts
{
    public class AgricultureContext:IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-S7P89NR\MSSQLSERVER01;Initial Catalog= AgriCulture;
            User ID=MustafaKorkmaz;Password=3262398;");
        }
        public DbSet<Stuff> Calisanlar { get; set; }
        public DbSet<Address> Adressler { get; set; }
        public DbSet<News> Haberler { get; set; }
        public DbSet<Service> Servisler { get; set; }
        public DbSet<Contact> Iletisim { get; set; }
        public DbSet<Image> Resimler { get; set; }
        public DbSet<SocialMedia> SosyalMedyaHesaplari { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<City> Cities { get; set; }
        
    }
}
