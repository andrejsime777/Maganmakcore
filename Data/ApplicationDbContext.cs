using Maganmakcore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maganmakcore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Proizvod> Proizvodi { get; set; }
        public DbSet<Kategorija_Proizvod> kategorija_Proizvodi { get; set; }
        public DbSet<Brz_link> Brzi_linkovi { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Kontakt> Kontakti { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Programm> Programi { get; set; }
        public DbSet<Kategorija_Program> kategorija_Programi { get; set; }
        public DbSet<Pocetna> sliki_pocetna { get; set; }

    }
}
