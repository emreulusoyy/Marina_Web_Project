using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-VO9M4VR\\SQLEXPRESS;initial catalog=DbMarina; integrated security=true");
        }

        public DbSet<Galeri> Galeris { get; set; }
        public DbSet<Hakkında> Hakkındas { get; set; }
        public DbSet<Hizmetler> Hizmetlers { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Misyonumuz> Misyonumuzs { get; set; }
        public DbSet<Vizyonumuz> Vizyonumuzs { get; set; }

    }
}