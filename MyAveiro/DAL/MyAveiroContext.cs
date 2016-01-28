using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyAveiro.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace  MyAveiro.DAL
{
    public class MyAveiroContext : DbContext
    {
    
        public MyAveiroContext() : base("MyAveiroContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Database.SetInitializer<MyAveiroContext>(null);
        }

        public DbSet<Utilities> Utilities { get; set; }

        public DbSet<UtilitiesTypes> UtilitiesTypes { get; set; }
        public DbSet<RestTypes> RestTypes { get; set; }
        public DbSet<FoodTypes> FoodTypes { get; set; }
        public DbSet<FunTypes> FunTypes { get; set; }
        public DbSet<EventTypes> EventTypes { get; set; }

    }
}