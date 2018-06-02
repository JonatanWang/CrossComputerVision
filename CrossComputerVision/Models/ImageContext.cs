using System;
using Microsoft.EntityFrameworkCore;

namespace CrossComputerVision.Models {

    public class ImageContext : DbContext {

        public DbSet<ImageData> ImagesList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Data Source=ComputerVision.db");
        }
    }
}