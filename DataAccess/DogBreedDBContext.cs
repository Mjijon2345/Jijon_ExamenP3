using Jijon_ExamenP3.ContextDB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jijon_ExamenP3.DataAccess
{
    internal class DogBreedDBContext : DbContext
    {
        
        public DbSet<DogBreed> DogBreeds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=myapp.db");
        }
    }
}
    

