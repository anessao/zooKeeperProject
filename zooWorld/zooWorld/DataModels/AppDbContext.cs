using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace zooWorld.DataModels
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("ZooWorld")
        {}

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Environment> Environments { get; set; }
        public DbSet<ZooKeeper> ZooKeepers { get; set; }
    }
}