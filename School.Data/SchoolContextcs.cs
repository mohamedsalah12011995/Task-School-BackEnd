using Microsoft.EntityFrameworkCore;
using School.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Data
{
   public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }


        public DbSet<SchoolInfo> Schools { get; set; }
        public DbSet<Classes> Classes { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Seasons> Seasons { get; set; }
        /// <summary>
        /// On Model Creating For Relathionship  configuration between DbSets 
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
    }
}
