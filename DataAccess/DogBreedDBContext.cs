
using Microsoft.EntityFrameworkCore;
using Jijon_ExamenP3.Utilidades;
using Jijon_ExamenP3.Modelos;

namespace Jijon_ExamenP3.DataAccess
{
    public class DogBreedDBContext : DbContext
    {
        public DbSet<DogBreedM> DogBreeds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conexionDB = $"Filename={ConexionDB.DevolverRuta("dogBreed.db")}";
            optionsBuilder.UseSqlite(conexionDB);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DogBreedM>(entity =>
            {
                entity.HasKey(col => col.IdDog);
                entity.Property(col => col.IdDog).IsRequired().ValueGeneratedOnAdd();
            });
        }

    }
}
    